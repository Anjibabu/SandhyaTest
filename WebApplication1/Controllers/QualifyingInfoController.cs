using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOSBPM.Models;


namespace DOSBPM.Controllers
{
    public class QualifyingInfoController : Controller
    {
        // GET: QualifyingInfo
        public ActionResult Index()
        {
            QualifyingInfo qualifyingInfo = new QualifyingInfo();
            {
                new QualifyingInfo { TransactionType = "New" };
                new QualifyingInfo { TransactionType = "Demo" };

            }
            
             return View(qualifyingInfo);
        }
    }
}