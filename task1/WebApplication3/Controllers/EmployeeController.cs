using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;

namespace WebApplication3.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext EmployeeContext = new ApplicationDbContext();
        public IActionResult Index()//getAllEmployee
        {
            var Employee = EmployeeContext.Employees.ToList();
            return View("Index",Employee);
        }
    }
}
