using System.Collections.Generic;
using RestSharp;

namespace JiraExport.Interfaces {
    public interface IPutRequest {
        IRestResponse Put(string body, object parameters = null);
    }
}