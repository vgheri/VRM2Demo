using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VRM2Demo.Models
{
    public class Vendor
    {
        public string Id { get; set; }
        public string PathToLogo { get; set; }
        public string Name { get; set; }
        public string Activity { get; set; }
        public string Address { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<Document> Documents { get; set; }
        public List<Photo> Photos { get; set; }
    }
}