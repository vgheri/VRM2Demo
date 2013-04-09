using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRM2Demo.Models
{
    public class Document
    {
        // Physical id of the document. This is unique
        public string Id { get; set; }
        // Logic id of the document, not unique
        public string DocumentId { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public string Path { get; set; }
    }
}
