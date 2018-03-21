using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class BaseController : Controller
    {
        public SelectList GetTransactionTypes()
        {
            return new SelectList(appdbEntities.L_TransactionType, "TransType_ID", "TransType_Name");
        }
        DEV_CODES_APPDBEntities appdbEntities = new DEV_CODES_APPDBEntities();
        public SelectList GetStates()
        {
            return new SelectList(appdbEntities.L_State, "State_ID", "State_Name");
        }
        public SelectList GetCountries()
        {
            return new SelectList(appdbEntities.L_Country, "Country_ID", "Country_Name");
        }

        public SelectList GetCounties()
        {
            return new SelectList(appdbEntities.L_County, "County_ID", "County_Name");
        }

    }
}