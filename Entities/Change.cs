using System;

namespace JiraExport.Entities {
    public class Change {
        public string StatusFrom {get;}
        public string StatusTo {get;}
        public string Author {get;}
        public DateTime Date {get;}
    }
}