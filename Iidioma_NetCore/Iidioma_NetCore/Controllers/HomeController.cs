using Iidioma_NetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Diagnostics;

namespace Iidioma_NetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer _localizer;

        public HomeController(IStringLocalizer localizer)
        {
            _localizer = localizer;
        }

        //A configuração abaixo, utiliza o arquivo idioma.resx para obter as traduções, no caso o IStringLocalizer<SharedResource>, porém pode ser trabalhoso ter que editar arquivo por arquivo para adicionar uma nova chave
        //a forma usada agora é obtida os dados através de um arquivo json, onde todos os idioma são contidos dentro dele services.AddJsonLocalization();
        // porém, ambas as funcionalidades atendem ...

        /*public HomeController(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
        }*/

        public IActionResult Index()
        {
            ViewBag.PageTitle = _localizer["Index_Page_Title"];
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
