using Microsoft.AspNetCore.Mvc;
using VendasWebMVC.Models;

namespace VendasWebMVC.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> list = new List<Departament>();
            list.Add(new Departament { id = 1, Name = "Eletronics" });
            list.Add(new Departament { id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}
