using System.Collections.Generic;
using RestSharp;

namespace JiraExport.Interfaces {
    public interface IRequestFactory
    {
        IRestRequest Create(object parameters, string body);
    }
}