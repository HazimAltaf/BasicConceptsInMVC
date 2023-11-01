using System.Web.Mvc;

namespace Basics_New.Controllers
{
    public class NewController : Controller
    {
        #region Only Calling Controller Without View and Model
        // GET: New
        public string Index()
        {
            return "Welcome to Reno Softwares";
        }
        public int Number()
        {
            return (10 + 20);
        }
        public string EmployeeProfile(int id)
        {
            string profile = string.Empty;
            if (id == 0)
            {
                profile = "Reno";
            }
            else if (id == 1)
            {
                profile = "Hazim";
            }
            else
            {
                profile = "No Record Found";
            }
            return profile;
        }
        public string Address(int id, string department)
        {
            return "id =" + id + " " + "department =" + department;
        }
        public string Nullable(int id, int? code = null)
        {
            return "id=" + id + " " + "code=" + code;
        }
        public string Game(string fname, string lname)
        {
            if (fname != null && lname == null)
            {
                return "Your First Name Is = " + fname;
            }
            else if (fname == null && lname != null)
            {
                return "Your Last Name is = " + lname;
            }
            else if (fname != null && lname != null)
            {
                return "Your First Name Is = " + fname + " and " + "Last Name is = " + lname;
            }
            else
            {
                return "Record Not Found";
            }
        }

        #endregion

        #region Controller With View

        public ActionResult ControllerWithView()
        {
            return View("Rename");
        }
        public ActionResult School()
        {
            return View();
        }
        public ActionResult About()
        {
            return View("AboutUs");
        }
        public ActionResult Contact()
        {
            return View("ContactUs");
        }
        #endregion
    }
}