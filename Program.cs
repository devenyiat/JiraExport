using System;
using JiraExport.Services.Issue;

namespace JiraExport
{
    class Program
    {
        static void Main(string[] args)
        {
            var issueService = new IssueById();
            var issue = issueService.Get(new {issueIdOrKey = "NNHOSD-7955"});
            Console.WriteLine(issue.Content);
        }
    }
}
