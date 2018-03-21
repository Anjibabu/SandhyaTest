using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Models
{
    public class CodeIntegration
    {
        //public string SelectionAtrium { get; set; }
        public string Atrium { get; set; }
        public string txtCCD { get; set; }
        public string txtCIS { get; set; }

        public class AtriumObject
        {
            public int Id { get; set; }
            public string Text { get; set; }
        }
        
        public IEnumerable<AtriumObject> SelectAtriums = new List<AtriumObject>
        {
            new AtriumObject { Id = 0, Text = "Atriums" },
            new AtriumObject { Id = 1, Text= "Group I-2" },
             new AtriumObject { Id = 2, Text = "Group I-3" },
              new AtriumObject { Id = 3, Text = "Group I-4" }
        };
        //search 
        //search Document

    }
}