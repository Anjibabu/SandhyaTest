using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class AccessibilityController : Controller
    {
        // GET: Accessibility
        
        public ActionResult Index()
        {
            Log.Info("Accessibility Controller Started");
            return View();
        }
       
    }    
}