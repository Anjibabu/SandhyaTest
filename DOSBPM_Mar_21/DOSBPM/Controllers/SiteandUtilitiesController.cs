using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class SiteandUtilitiesController : Controller
    {
        // GET: SiteandUtilities
        public ActionResult Index()
        {
            Log.Info("Site and Utilities Controller Started");

            List<SelectListItem>
        objItem = new List<SelectListItem>
            ()
            {
            new SelectListItem{Text="Select",Value="0", Selected=true},
            new SelectListItem{Text="aaaa",Value="1"},
            new SelectListItem{Text="xxxx",Value="2"},
            };
            ViewBag.ListItem = objItem;
            return View();
        }
    }
}