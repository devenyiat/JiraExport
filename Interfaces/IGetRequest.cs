using System.Collections.Generic;

namespace JiraExport.Interfaces {
    public interface IGetRequest {
        string Get(object parameters = null);
    }
}