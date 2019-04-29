using System.Collections.Generic;

namespace JiraExport.Interfaces {
    public interface IPutRequest {
        string Put(string body, object parameters = null);
    }
}