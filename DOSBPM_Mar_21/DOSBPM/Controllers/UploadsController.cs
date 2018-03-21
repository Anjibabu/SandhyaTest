using DOSBPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class UploadsController : Controller
    {
        // GET: Uploads
        public ActionResult Index()
        {
            Log.Info("Uploads Controller Started");

            return View();
        }
        [HttpPost]
        public JsonResult Index(string Prefix)
        {
            //Note : you can bind same list from database  

            //return Json(db.Countries.Where(c => c.Name.StartsWith(term)).Select(a => new { label = a.Name }), JsonRequestBehavior.AllowGet);
        
        List<Uploads> ObjList = new List<Uploads>()
            {

                new Uploads {Id=1,CityName="Latur" },
                new Uploads {Id=2,CityName="Mumbai" },
                new Uploads {Id=3,CityName="Pune" },
                new Uploads {Id=4,CityName="Delhi" },
                new Uploads {Id=5,CityName="Dehradun" },
                new Uploads {Id=6,CityName="Noida" },
                new Uploads {Id=7,CityName="New Delhi" }

        };
            //Searching records from list using LINQ query  
            var uploadCityList = (from N in ObjList
                            where N.CityName.StartsWith(Prefix)
                            select new { N.CityName });
            return Json(uploadCityList, JsonRequestBehavior.AllowGet);
        }
    }
}
