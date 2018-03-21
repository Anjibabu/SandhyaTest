using DOSBPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class CodeIntegrationController : Controller
    {
        // GET: CodeIntegration
        public ActionResult Index()
        {
            Log.Info("Code Integration Controller Started");

            return View(new CodeIntegration());
        }
    }
}