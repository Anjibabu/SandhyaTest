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
            QualifyingInfoModel qualifyingInfo = new QualifyingInfoModel();
            {
                new QualifyingInfoModel { TransactionType = "New" };
                new QualifyingInfoModel { TransactionType = "Demo" };

            }
            
             return View(qualifyingInfo);
        }
    }
}