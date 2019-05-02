using System.Collections.Generic;
using JiraExport.Client;
using JiraExport.Extensions;
using JiraExport.Interfaces;
using RestSharp;

namespace JiraExport.Endpoints {
    public class Organization : ServiceBase, IGetRequest, IPostRequest, IDeleteRequest
    {
        protected override string Resource {get;} = "servicedesk/{serviceDeskId}/organization";

        public IRestResponse Get(object parameters = null)
        {
            return GetBase(parameters);
        }

        public IRestResponse Post(string body = null, object parameters = null)
        {
            return PostBase(body, parameters);
        }

        public IRestResponse Delete(string body = null, object parameters = null)
        {
            return DeleteBase(body, parameters);
        }
    }
}