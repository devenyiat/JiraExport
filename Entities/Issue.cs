using System;
using System.Collections.Generic;
using System.Linq;

namespace JiraExport.Entities {
    public class Issue {
        public string Id {get;}
        public string Status {get;}
        public DateTime Created {get;}
        public List<Change> Changelog {get;}

        public List<string> ToCsvLines() {
            var lines = new List<string>();
            if (!Changelog.Any()) {
                lines.Add($"{Id},{Status},,{DateTime.Now.Subtract(Created)}");
            }
            else {
                for (int i = 0; i < Changelog.Count; i++) {
                    var change = Changelog[i];
                    var prevDate = i == 0 ? Created : Changelog[i-1].Date;
                    //var nextDate = 
                    lines.Add($"{Id},{change.StatusFrom},{change.StatusTo},");
                }
            }
            return lines;
        }
    }
}