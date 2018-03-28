using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class BaseController : Controller
    {
		public DEV_CODES_APPDBEntities db
		{
			get
			{
				return new DEV_CODES_APPDBEntities();
			}
		}
		public SelectList GetTransactionTypes()
		{
			return new SelectList(db.L_TransactionType, "TransType_ID", "TransType_Name");
		}
		public SelectList GetProperTyOwnerTypes()
		{
			return new SelectList(db.L_TransactionType , "TransType_ID", "TransType_Name");
		}
		public SelectList GetStates()
		{
			return new SelectList(db.L_State, "State_ID", "State_Name");
		}
		public SelectList GetCountries()
		{
			return new SelectList(db.L_Country, "Country_ID", "Country_Name");
		}

		public SelectList GetCounties()
		{
			return new SelectList(db.L_County, "County_ID", "County_Name");
		}

	}
}