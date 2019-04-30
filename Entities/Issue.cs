using System;
using System.Collections.Generic;
using System.Linq;

namespace JiraExport.Entities {
    public class Issue {
        public string Id {get;}
        public string Status {get;}
        public DateTime Created {get;}
        public List<Change> Changelog {get;}

        public Issue(string id, string status, DateTime created, List<Change> changelog) {
            Id = id;
            Status = status;
            Created = created;
            Changelog = changelog;
        }

        public List<string> ToCsvLines() {
            var lines = new List<string>();
            var changeCount = Changelog.Count;
            DateTime refDate;

            if (changeCount != 0) {
                for (int i = 0; i < changeCount; i++) {
                    var change = Changelog[i];
                    refDate = i == 0 ? Created : Changelog[i-1].Date;
                    lines.Add($"{Id},{change.StatusFrom},{change.StatusTo},{change.Date.Subtract(refDate)}");
                }
            }
            
            refDate = changeCount == 0 ? Created : Changelog.Last().Date;
            lines.Add($"{Id},{Status},,{DateTime.Now.Subtract(refDate)}");
            return lines;
        }
    }
}