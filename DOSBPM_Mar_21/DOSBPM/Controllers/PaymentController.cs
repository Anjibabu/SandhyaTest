using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOSBPM.Models;

namespace DOSBPM.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult Index()
        {
            Log.Info("Payment Controller Started");
                        
                var objPayment = new Payment();
                objPayment.PaymentTypes = new[]
                {
                    new SelectListItem { Value = "1", Text = "Saratoga" },
                    new SelectListItem { Value = "2", Text = "Albany" },
                    new SelectListItem { Value = "3", Text = "Rensselaer" },
                    new SelectListItem { Value = "4", Text = "Troy" },
                    new SelectListItem { Value = "5", Text = "GreenBush" },
            };
                return View(objPayment);

                
        }
    }
}