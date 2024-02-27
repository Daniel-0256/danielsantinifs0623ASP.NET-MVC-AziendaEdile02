using AziendaEdile02.Models;
using Microsoft.AspNetCore.Mvc;

namespace AziendaEdile02.Controllers
{
    public class DipendenteController : Controller
    {
        public IActionResult Index()
        {
            return View(DataStorage.Dipendenti);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Dipendente dipendente)
        {
            DataStorage.Dipendenti.Add(dipendente);
            return RedirectToAction("Index");
        }
    }
}
