using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JiraExport.Extensions;
using JiraExport.Interfaces;
using RestSharp;

namespace JiraExport.Client {
    public abstract class ServiceBase {

        protected abstract string Resource {get;}
        protected IEnumerable<string> UrlSegments {get;} = Enumerable.Empty<string>();
        protected string BaseUrl;

        private IClientFactory _clientFactory;
        private IRequestFactory _requestFactory;

        public ServiceBase(IClientFactory clientFactory, IRequestFactory requestFactory) {
            _clientFactory = clientFactory;
            _requestFactory = requestFactory;
        }

        public ServiceBase(){
            _clientFactory = new DefaultClientFactory();
            _requestFactory = new DefaultRequestFactory(Resource, UrlSegments);
        }

        protected IRestResponse PutBase(string body, Dictionary<string, string> parameters) {
            var request = _requestFactory.Create(parameters, body);
            return _clientFactory.Create(BaseUrl).Execute(request, Method.PUT);
        }

        protected IRestResponse GetBase(object parameters) {
            var request = _requestFactory.Create(parameters, null);
            return _clientFactory.Create(BaseUrl).Execute(request, Method.GET);
        }

        protected IRestResponse DeleteBase(string body, object parameters) {
            var request = _requestFactory.Create(parameters, body);
            return _clientFactory.Create(BaseUrl).Execute(request, Method.DELETE);
        }

        protected IRestResponse PostBase(string body, object parameters) {
            var request = _requestFactory.Create(parameters, body);
            return _clientFactory.Create(BaseUrl).Execute(request, Method.POST);
        }
    }
}