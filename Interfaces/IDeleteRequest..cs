using System.Collections.Generic;

namespace JiraExport.Interfaces {
    public interface IDeleteRequest {
        string Delete(string body, object parameters = null);
    }
}