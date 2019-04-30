using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JiraExport.Extensions;
using RestSharp;

namespace JiraExport.Client {
    public abstract class RequestBase {

        protected abstract string Resource {get;}
        protected IEnumerable<string> UrlSegments {get;} = Enumerable.Empty<string>();
        protected string BaseUrl;

        private static RestClient _client;

        public RequestBase(RestClient client) {
            _client = client;
        }

        protected IRestResponse PutBase(string body, Dictionary<string, string> parameters) {
            var request = GetRequest(body, parameters.ToDictionary());
            return _client.Execute(request, Method.PUT);
        }

        protected IRestResponse GetBase(object parameters) {
            var request = GetRequest(null, parameters.ToDictionary());
            return _client.Execute(request, Method.GET);
        }

        protected IRestResponse DeleteBase(string body, object parameters) {
            var request = GetRequest(body, parameters.ToDictionary());
            return _client.Execute(request, Method.DELETE);
        }

        protected IRestResponse PostBase(string body, object parameters) {
            var request = GetRequest(body, parameters.ToDictionary());
            return _client.Execute(request, Method.POST);
        }

        private void Initialize() {
            if (_client == null) {
                _client = new RestClient(BaseUrl);
            }
        }

        private IRestRequest GetRequest(string body, IDictionary<string, string> parameters) {
            var request = new RestRequest(Resource);
            foreach (var key in parameters.Keys) {
                if (UrlSegments.Contains(key)) {
                    request.AddUrlSegment(key, parameters[key]);
                }
                else {
                    request.AddQueryParameter(key, parameters[key]);
                }
            }
            if (body != null) {
                request.AddJsonBody(body);
            }
            return request;
        }
    }
}