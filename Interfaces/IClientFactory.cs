using RestSharp;

namespace JiraExport.Interfaces {
    public interface IClientFactory {
        IRestClient Create(string baseUrl);
    }
}