using System.Collections.Generic;

namespace JiraExport.Interfaces {
    public interface IPostRequest {
        string Post(string body, object parameters = null);
    }
}