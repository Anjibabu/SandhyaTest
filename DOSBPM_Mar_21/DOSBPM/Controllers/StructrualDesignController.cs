using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class StructrualDesignController : Controller
    {
        // GET: StructrualDesign
        public ActionResult Index()
        {
            Log.Info("Structrual Design Controller Started"); 
            return View();
        }
    }
}