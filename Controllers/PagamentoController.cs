using AziendaEdile02.Models;
using Microsoft.AspNetCore.Mvc;

namespace AziendaEdile02.Controllers
{
    public class PagamentoController : Controller
    {
        public IActionResult Index()
        {
            return View(DataStorage.Pagamenti);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Pagamento pagamento)
        {
            DataStorage.Pagamenti.Add(pagamento);
            return RedirectToAction("Index");
        }
    }
}
