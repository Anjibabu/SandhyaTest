using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class MiscAdditionalInfoController : Controller
    {
        // GET: MiscAdditionalInfo
        public ActionResult Index()
        {
            Log.Info("Misc Additional Info");
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