using Iidioma_NetCore.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Iidioma_NetCore.Controllers
{
    public class IdiomaDataAnotationController : Controller
    {
        public IActionResult Teste()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Teste(IdiomaDataAnotationVM idiomaDataAnotationVM)
        {
            if (!ModelState.IsValid) return View(idiomaDataAnotationVM);

            return View();
        }
    }
}
