using Basics_New.Models;
using System.Web.Mvc;

namespace Basics_New.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var data = GetEmployeeData();
            return View(data);  // or return View("calling view having different name",data);
        }
        private Employee GetEmployeeData()
        {
            return new Employee()
            {
                Id = 1,
                Name = "Hazim",
                Address = "Altaf"
            };
        }
    }
}