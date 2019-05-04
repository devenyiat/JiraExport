using JiraExport.Client;

namespace JiraExport.Services
{
    public abstract class JiraServiceBase : ServiceBase
    {
        public JiraServiceBase() : base("https://helpdesk.hu.cre.insim.biz")
        {
        }
    }
}