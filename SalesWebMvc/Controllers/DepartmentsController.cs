using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Models.Department> list = new List<Models.Department>();
            list.Add(new Models.Department { Id = 1, Name = "Eletronics" });
            list.Add(new Models.Department { Id = 1, Name = "Books" });
            return View(list);
        }
    }
}
