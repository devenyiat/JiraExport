using System.Collections.Generic;
using JiraExport.Client;
using JiraExport.Extensions;
using JiraExport.Interfaces;

namespace JiraExport.Endpoints {
    public class Organization : JiraRequest, IGetRequest, IPostRequest, IDeleteRequest
    {
        protected override string Endpoint {get;} = "servicedesk/{serviceDeskId}/organization";

        public string Get(object parameters = null)
        {
            return GetBase(parameters).Content;
        }

        public string Post(string body = null, object parameters = null)
        {
            return PostBase(body, parameters);
        }

        public string Delete(string body = null, object parameters = null)
        {
            return DeleteBase(body, parameters);
        }
    }
}