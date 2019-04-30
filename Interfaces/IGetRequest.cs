using System.Collections.Generic;
using RestSharp;

namespace JiraExport.Interfaces {
    public interface IGetRequest {
        IRestResponse Get(object parameters = null);
    }
}