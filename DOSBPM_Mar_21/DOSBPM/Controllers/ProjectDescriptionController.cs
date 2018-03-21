using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class ProjectDescriptionController : Controller
    {
        // GET: ProjectDescription
        public ActionResult Index()
        {
            Log.Info("Project Description Controller Started");
            return View();
        }
    }
}