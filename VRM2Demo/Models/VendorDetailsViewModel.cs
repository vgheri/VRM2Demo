using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VRM2Demo.Models
{
    public class VendorDetailsViewModel
    {
        public Vendor Vendor { get; set; }
        public List<string> Activities
        {
            get { return new List<string>() { "IT services", "Activity B", "Activity C" }; }
            private set { this.Activities = value; }
        }

    }
}