using System.Collections.Generic;
using RestSharp;

namespace JiraExport.Interfaces {
    public interface IPostRequest {
        IRestResponse Post(string body, object parameters = null);
    }
}