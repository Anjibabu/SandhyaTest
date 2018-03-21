using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.MenuHighlight
{
    public static class NavBarHighlight
    {
        public static string IsActive(this HtmlHelper html,string Mainmenu,

                                      string control,

                                      string action)

        {

            var routeData = html.ViewContext.RouteData;

            var routeparentmenu = Mainmenu;

            var routeAction = (string)routeData.Values["action"];

            var routeControl = (string)routeData.Values["controller"];
           


            // both must match

            var returnActive = control == routeControl &&

                               action == routeAction &&

                                Mainmenu == routeparentmenu;



            return returnActive ? "active" : "";

        }

        public static MvcHtmlString MenuLink(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName)
        {
            var builder = new TagBuilder("li");

            var currentAction = htmlHelper.ViewContext.RouteData.GetRequiredString("action");
            var currentController = htmlHelper.ViewContext.RouteData.GetRequiredString("controller");

            if (controllerName == currentController && actionName == currentAction)
            {
                builder.AddCssClass("active");
            }

            builder.InnerHtml = htmlHelper.MenuLink(linkText, actionName, controllerName).ToHtmlString();

            return new MvcHtmlString(builder.ToString());
        }




    }
}