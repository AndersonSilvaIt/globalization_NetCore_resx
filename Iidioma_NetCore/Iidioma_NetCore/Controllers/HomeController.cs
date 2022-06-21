using Iidioma_NetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Diagnostics;

namespace Iidioma_NetCore.Controllers
{
    public class HomeController : Controller
    {
        //Config para usar o arquivo RESX, um arquivo para cada idioma 
        //private readonly IStringLocalizer<SharedResource> _localizer;
        /*public HomeController(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
        }*/
        
        //Config para usar o arquivo json, um único arquivo com todos os idiomas

        private readonly IStringLocalizer _localizer;
        public HomeController(IStringLocalizer localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            ViewBag.PageTitle = _localizer["Index_Page_Title"];
            return View();
        }

        public IActionResult IdiomaDataAnotation()
        {
            
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
