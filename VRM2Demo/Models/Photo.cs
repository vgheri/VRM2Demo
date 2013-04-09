using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRM2Demo.Models
{
    public class Photo
    {
        public string Id { get; set; }
        public string Owner { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime UploadDate { get; set; }
    }
}
