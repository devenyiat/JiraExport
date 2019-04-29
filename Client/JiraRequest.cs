using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JiraExport.Extensions;
using RestSharp;

namespace JiraExport.Client {
    public abstract class JiraRequest {

        protected abstract string Endpoint {get;}
        protected IEnumerable<string> UrlSegments {get;} = Enumerable.Empty<string>();

        private RestClient JiraRestClient = new RestClient("baseUrl");

        protected string PutBase(string body, Dictionary<string, string> parameters) {
            throw new NotImplementedException();
        }

        protected IRestResponse GetBase(object parameters) {
            var request = new RestRequest();
            var parametersDict = parameters.ToDictionary();
            foreach (var key in parametersDict.Keys) {
                if (UrlSegments.Contains(key)) {
                    request.AddUrlSegment(key, parametersDict[key].ToString());
                }
                else {
                    request.AddQueryParameter(key, parametersDict[key].ToString());
                }
            }
            return JiraRestClient.Execute(request, Method.GET);
        }

        protected string DeleteBase(string body, object parameters) {
            throw new NotImplementedException();
        }

        protected string PostBase(string body, object parameters) {
            throw new NotImplementedException();
        }
    }
}