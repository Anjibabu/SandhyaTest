﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class AttestationandSubmitController : Controller
    {
        // GET: AttestationandSubmit
        public ActionResult Index()
        {
            Log.Info("Attestation and Submit Controller Started");

            return View();
        }
    }
}