using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Dynamic;
using VRM2Demo.Models;
using System.Collections.Generic;

namespace VRM2Demo.Controllers
{
    public class HotTowelController : Controller
    {
        //
        // GET: /HotTowel/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Search/

        public JsonResult Search(string name, string companyId, string activityId)
        {
            List<CompanySearchResultViewModel> searchResults = new List<CompanySearchResultViewModel>();
            searchResults.Add(new CompanySearchResultViewModel()
            {
                Id = "123AH",
                Name = "Company A",
                Activity = "IT Services"
            });
            searchResults.Add(new CompanySearchResultViewModel()
            {
                Id = "311AF",
                Name = "Company B",
                Activity = "IT Services"
            });
            searchResults.Add(new CompanySearchResultViewModel()
            {
                Id = "R4SJJA",
                Name = "Company C",
                Activity = "IT Services"
            });
            //string json = Newtonsoft.Json.JsonConvert.SerializeObject(company);
            //return json;
            return Json(searchResults, JsonRequestBehavior.AllowGet);
        }

        //
        // GET: /GetVendor/

        public JsonResult GetVendor(string id)
        {
            Vendor vendor = new Vendor()
            {
                Id = id,
                PathToLogo = Url.Content("~/Content/images/HTML5.png"),
                Name = "Company A",
                Activity = "IT Services",
                Address = "0, Nowhere to be found, Infinite loop, Mars",
                Contacts = BuildDummyContacts(),
                //Documents = BuildDummyDocuments(),
                //Photos = BuildDummyPhotos()
            };
            VendorDetailsViewModel result = new VendorDetailsViewModel()
            {
                Vendor = vendor
            };
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        private List<Contact> BuildDummyContacts()
        {
            var contacts = new List<Contact>();
            var contact1 = new Contact()
            {
                Id = System.Guid.NewGuid().ToString(),
                Name = "Jon Snow",
                Email = "jsnow@blackwatch.com",
                PhoneNumber = "+1555328289"
            };
            var contact2 = new Contact()
            {
                Id = System.Guid.NewGuid().ToString(),
                Name = "Eddard Stark",
                Email = "estark@winterfell.com",
                PhoneNumber = "+1555323212"
            };
            var contact3 = new Contact()
            {
                Id = System.Guid.NewGuid().ToString(),
                Name = "Daenerys Stormborn",
                Email = "dstormborn@qarth.com",
                PhoneNumber = "+155394839821"
            };
            contacts.Add(contact1);
            contacts.Add(contact2);
            contacts.Add(contact3);
            return contacts;
        }
    }
}
