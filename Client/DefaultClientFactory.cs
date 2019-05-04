using System.Collections.Generic;
using JiraExport.Interfaces;
using RestSharp;

namespace JiraExport.Client {
    public class DefaultClientFactory : IClientFactory
    {

        private string _baseUrl;
        private static Dictionary<string, IRestClient> _clients;

        static DefaultClientFactory() {
            _clients = new Dictionary<string, IRestClient>();
        }

        public DefaultClientFactory(string baseUrl) {
            _baseUrl = baseUrl;
        }

        public IRestClient Create()
        {
            if (_clients.ContainsKey(_baseUrl)) {
                _clients.Add(_baseUrl, new RestClient(_baseUrl));
            }
            return _clients[_baseUrl];
        }
    }
}