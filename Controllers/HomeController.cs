using CatFactNetwise.Models;
using CatFactNetwise.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CatFactNetwise.Controllers
{
    public class HomeController : Controller
    {
        protected ICatFactService _service;
        protected IFileService _FileService;
        public HomeController(ICatFactService service, IFileService fileService )
        {
            _FileService = fileService;
            _service = service;
        }
        public  IActionResult Index()
        {
            var test = _service.GetFact();
            _FileService.MessageWriteToFile(test.Result);
            return View();
        }
        public IActionResult GetFact()
        {
            var message = _service.GetFact();
            _FileService.MessageWriteToFile(message.Result);
            ViewBag.Message = message.Result;
            var test = new MessageModel() { Text = message.Result };

            return View("Index", test);
            //return RedirectToAction("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
