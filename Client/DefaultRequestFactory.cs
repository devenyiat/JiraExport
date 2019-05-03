using System.Collections.Generic;
using System.Linq;
using JiraExport.Extensions;
using JiraExport.Interfaces;
using RestSharp;

namespace JiraExport.Client
{
    public class DefaultRequestFactory : IRequestFactory
    {

        private IEnumerable<string> _urlSegments;
        private string _resource;

        public DefaultRequestFactory(string resource, IEnumerable<string> urlSegments) {
            _resource = resource;
            _urlSegments = urlSegments;
        }

        public IRestRequest Create(object parameters, string body)
        {
            var request = new RestRequest(_resource);
            AddParameters(request, parameters.ToDictionary());
            AddBody(request, body);
            return request;
        }

        private void AddParameters(IRestRequest request, IDictionary<string, string> parameters) {
            foreach (var key in parameters.Keys)
            {
                if (_urlSegments.Contains(key))
                {
                    request.AddUrlSegment(key, parameters[key]);
                }
                else
                {
                    request.AddQueryParameter(key, parameters[key]);
                }
            }
        }

        private void AddBody(IRestRequest request, string body) {
            if (body != null)
            {
                request.AddJsonBody(body);
            }
        }
    }
}