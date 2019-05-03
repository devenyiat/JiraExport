using System.Collections.Generic;
using JiraExport.Interfaces;
using RestSharp;

namespace JiraExport.Client {
    public class DefaultClientFactory : IClientFactory
    {

        private static Dictionary<string, IRestClient> _client;

        static DefaultClientFactory() {
            _client = new Dictionary<string, IRestClient>();
        }

        public IRestClient Create(string baseUrl)
        {
            if (!_client.ContainsKey(baseUrl)) {
                _client.Add(baseUrl, new RestClient(baseUrl));
            }
            return _client[baseUrl];
        }
    }
}