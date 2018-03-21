using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.DirectoryServices;
using DOSBPM.Models;


namespace DOSBPM.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        DirectorySearcher dirSearch = null;
        public ActionResult Index(LogIn logIn)
        {
            if (logIn.UserName != null)
            {
                SearchResult sr = LogInUser(logIn);
                return RedirectToAction("Index", "QualifyingInfo");
            }
            else

                return View();
        }

        [HttpPost]
        public SearchResult LogInUser(LogIn logIn)
        {
            Log.Info("LogIn Controller Started");

            LogIn login = new LogIn();

            SearchResult result = null;
            string lblUsernameDisplay = string.Empty;
            string lblFirstname = string.Empty;
            string lblMiddleName = string.Empty;
            string lblLastName = string.Empty;
            string lblEmailId = string.Empty;

            if (logIn.UserName.Trim().Length != 0 && logIn.Password.Trim().Length != 0)
            {
                result = GetUserInformation(logIn.UserName.Trim(), logIn.Password.Trim(), "dos.state.ny.us");

                if (result.GetDirectoryEntry().Properties["samaccountname"].Value != null)
                    lblUsernameDisplay = "Username : " + result.GetDirectoryEntry().Properties["samaccountname"].Value.ToString();

                if (result.GetDirectoryEntry().Properties["givenName"].Value != null)
                    lblFirstname = "First Name : " + result.GetDirectoryEntry().Properties["givenName"].Value.ToString();

                if (result.GetDirectoryEntry().Properties["initials"].Value != null)
                    lblMiddleName = "Middle Name : " + result.GetDirectoryEntry().Properties["initials"].Value.ToString();

                if (result.GetDirectoryEntry().Properties["sn"].Value != null)
                    lblLastName = "Last Name : " + result.GetDirectoryEntry().Properties["sn"].Value.ToString();

                if (result.GetDirectoryEntry().Properties["mail"].Value != null)
                    lblEmailId = "Email ID : " + result.GetDirectoryEntry().Properties["mail"].Value.ToString();
            }

            return result;
        }

        private SearchResult GetUserInformation(string username, string passowrd, string domain)
        {
            SearchResult rs = null;
            //domain = "dos.state.ny.us";
            domain = "dos.state.ny.us";

            if (username.Trim().IndexOf("@") > 0)
                rs = SearchUserByEmail(GetDirectorySearcher(username, passowrd, domain), username.Trim());
            else
                rs = SearchUserByUserName(GetDirectorySearcher(username, passowrd, domain), username.Trim());

            //if (rs == null)
            //{
            //    lblError.Text = "User not found!!!";
            //}
            return rs;
        }

        private DirectorySearcher GetDirectorySearcher(string username, string passowrd, string domain)
        {
            if (dirSearch == null)
            {
                try
                {
                    dirSearch = new DirectorySearcher(new DirectoryEntry("LDAP://" + domain, username, passowrd));
                }
                catch (DirectoryServicesCOMException e)
                {
                    // lblError.Text = "Connection Creditial is Wrong!!!, please Check.";
                    e.Message.ToString();
                }
                return dirSearch;
            }
            else
            {
                return dirSearch;
            }
        }

        private SearchResult SearchUserByUserName(DirectorySearcher ds, string username)
        {
            ds.Filter = "(&((&(objectCategory=Person)(objectClass=User)))(samaccountname=" + username + "))";

            ds.SearchScope = SearchScope.Subtree;
            ds.ServerTimeLimit = TimeSpan.FromSeconds(90);

            SearchResult userObject = ds.FindOne();

            if (userObject != null)
                return userObject;
            else
                return null;
        }

        private SearchResult SearchUserByEmail(DirectorySearcher ds, string email)
        {
            ds.Filter = "(&((&(objectCategory=Person)(objectClass=User)))(mail=" + email + "))";

            ds.SearchScope = SearchScope.Subtree;
            ds.ServerTimeLimit = TimeSpan.FromSeconds(90);

            SearchResult userObject = ds.FindOne();

            if (userObject != null)
                return userObject;
            else
                return null;
        }
    }
}