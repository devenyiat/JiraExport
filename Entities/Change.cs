using System;

namespace JiraExport.Entities {
    public class Change {
        public string StatusFrom {get;}
        public string StatusTo {get;}
        public string Author {get;}
        public DateTime Date {get;}

        public Change(string from, string to, string author, DateTime date) {
            StatusFrom = from;
            StatusTo = to;
            Author = author;
            Date = date;
        }
    }
}