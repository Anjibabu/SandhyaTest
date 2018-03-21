using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class ElevatorsandConveyingSystemsController : Controller
    {
        // GET: ElevatorsandConveyingSystems
        public ActionResult Index()
        {
            Log.Info("Elevators and ConveyingSystems Controller Started"); 
            return View();
        }
    }
}