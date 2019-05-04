using System.Collections.Generic;
using JiraExport.Client;
using JiraExport.Interfaces;
using RestSharp;

namespace JiraExport.Services.Issue {
    public class IssueById : JiraServiceBase, IGetRequest, IPutRequest, IDeleteRequest
    {
        protected override string Resource { get; } = "/rest/api/2/issue/{issueIdOrKey}";
        protected override IEnumerable<string> UrlSegments {get;} = new [] {"issueIdOrKey"};

        public IRestResponse Delete(string body, object parameters = null)
        {
            return base.DeleteBase(body, parameters);
        }

        public IRestResponse Get(object parameters = null)
        {
            return base.GetBase(parameters);
        }

        public IRestResponse Put(string body, object parameters = null)
        {
            return base.PutBase(body, parameters);
        }
    }
}