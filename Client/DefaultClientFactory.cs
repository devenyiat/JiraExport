using JiraExport.Interfaces;
using RestSharp;

namespace JiraExport.Client {
    public class DefaultClientFactory : IClientFactory
    {
        public IRestClient Create()
        {
            throw new System.NotImplementedException();
        }
    }
}