using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOSBPM.Models
{
    public class StructrualDesign
    {      
        //Truss Style Construcation
        public string txtCCD { get; set; }
        public string txtCIS { get; set; }
        public string txtPgNo { get; set; }
        public string txtApplicantComments { get; set; }
        public string txtBackOffComments { get; set; }

        //Structural Design Information
        public string txt1CCD { get; set; }
        public string txt1CIS { get; set; }
        public string txt1PgNo { get; set; }
        public string txt1ApplicantComments { get; set; }
        public string txt1BackOffComments { get; set; }

        //Floor Live Load Occupancy
        public string txtFloorLiveLoad { get; set; }

        //Risk Category
        public string ddlRiskCategory { get; set; }
        public string txt2CCD { get; set; }
        public string txt2CIS { get; set; }
        public string txt2PgNo { get; set; }
        public string txt2ApplicantComments { get; set; }
        public string txt2BackOffComments { get; set; }

        //Roof Live Load
        public string txtProvidedRoofLL { get; set; }
        public string txtAllowedRoofLL { get; set; }
        public string txt3CCD { get; set; }
        public string txt3CIS { get; set; }
        public string txt3PgNo { get; set; }
        public string txt3ApplicantComments { get; set; }
        public string txt3BackOffComments { get; set; }

        //Dead Load
        public string txtProvidedDeadL { get; set; }
        public string txtAllowedDeadL { get; set; }
        public string txt4CCD { get; set; }
        public string txt4CIS { get; set; }
        public string txt4PgNo { get; set; }
        public string txt4ApplicantComments { get; set; }
        public string txt4BackOffComments { get; set; }

        //Snow Load
        public string txtProvidedSnowL { get; set; }
        public string txtAllowedSnowL { get; set; }
        public string txt5CCD { get; set; }
        public string txt5CIS { get; set; }
        public string txt5PgNo { get; set; }
        public string txt5ApplicantComments { get; set; }
        public string txt5BackOffComments { get; set; }

        //Wind Load
        public string txtProvidedWindL { get; set; }
        public string txtAllowedWindL { get; set; }
        public string txt6CCD { get; set; }
        public string txt6CIS { get; set; }
        public string txt6PgNo { get; set; }
        public string txt6ApplicantComments { get; set; }
        public string txt6BackOffComments { get; set; }

        //Earthquake Loads
        public string txtProvidedEarthQuakeL { get; set; }
        public string txtAllowedEarthQuakeL { get; set; }
        public string txt7CCD { get; set; }
        public string txt7CIS { get; set; }
        public string txt7PgNo { get; set; }
        public string txt7ApplicantComments { get; set; }
        public string txt7BackOffComments { get; set; }

        //Seismic Design Category
        public string ddlSeismic { get; set; }      
        public string txt8CCD { get; set; }
        public string txt8CIS { get; set; }
        public string txt8PgNo { get; set; }
        public string txt8ApplicantComments { get; set; }
        public string txt8BackOffComments { get; set; }

        //Soil Lateral Load
        public string txtProvidedSoilLL { get; set; }
        public string txtAllowedSoilLL { get; set; }
        public string txt9CCD { get; set; }
        public string txt9CIS { get; set; }
        public string txt9PgNo { get; set; }
        public string txt9ApplicantComments { get; set; }
        public string txt9BackOffComments { get; set; }

        //Rain Load
        public string txtProvidedRainL { get; set; }
        public string txtAllowedRainL { get; set; }
        public string txt10CCD { get; set; }
        public string txt10CIS { get; set; }
        public string txt10PgNo { get; set; }
        public string txt10ApplicantComments { get; set; }
        public string txt10BackOffComments { get; set; }

        //Flood Load
        public string txtProvidedFloodL { get; set; }
        public string txtAllowedFloodL { get; set; }
        public string txt11CCD { get; set; }
        public string txt11CIS { get; set; }
        public string txt11PgNo { get; set; }
        public string txt11ApplicantComments { get; set; }
        public string txt11BackOffComments { get; set; }

        //Other Load
        public string txtProvidedOtherL { get; set; }
        public string txtAllowedOtherL { get; set; }
        public string txt12CCD { get; set; }
        public string txt12CIS { get; set; }
        public string txt12PgNo { get; set; }
        public string txt12ApplicantComments { get; set; }
        public string txt12BackOffComments { get; set; }

        //Load Value 
        public string txtProvidedLaodVal { get; set; }
        public string txtAllowedLaodVal { get; set; }
        public string txt13CCD { get; set; }
        public string txt13CIS { get; set; }
        public string txt13PgNo { get; set; }
        public string txt13ApplicantComments { get; set; }
        public string txt13BackOffComments { get; set; }

        //Load Combinations 
        public string txtProvidedLaodCombi { get; set; }
        public string txtAllowedLaodCombi { get; set; }
        public string txt14CCD { get; set; }
        public string txt14CIS { get; set; }
        public string txt14PgNo { get; set; }
        public string txt14ApplicantComments { get; set; }
        public string txt14BackOffComments { get; set; }

    }
}