using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Models
{
    public class Payment
    {
        public double AmountDue { get; set; }
        public double AmountRequired { get; set; }
        public double OverPayment { get; set; }
        public double RefundDue { get; set; }

        public string PayeeFirstName { get; set; }
        public string PayeeMiddleName { get; set; }
        public string PayeeLastName { get; set; }
        public string PayeeSuffix { get; set; }
        public string PayeeBusineessName { get; set; }
        public string PayeeAddressLine1 { get; set; }
        public string PayeeAdressLine2 { get; set; }
        public string PayeeCity { get; set; }
        public string PayeeState { get; set; }
        public string PayeeZipCode { get; set; }
        public int Zip4 { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string PaymentType { get; set; }

        public IEnumerable<SelectListItem> PaymentTypes { get; set; }


    }
}