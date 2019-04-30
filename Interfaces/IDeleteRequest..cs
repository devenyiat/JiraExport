using System.Collections.Generic;
using RestSharp;

namespace JiraExport.Interfaces {
    public interface IDeleteRequest {
        IRestResponse Delete(string body, object parameters = null);
    }
}