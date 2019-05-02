using RestSharp;

namespace JiraExport.Interfaces {
    public interface IRequestFactory
    {
        IRestRequest Create();
    }
}