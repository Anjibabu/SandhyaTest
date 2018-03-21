using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Models
{
    public class Summary
    {
        
        public string County { get; set; }
        public IEnumerable<SelectListItem> Counties { get; set; }
    }
}