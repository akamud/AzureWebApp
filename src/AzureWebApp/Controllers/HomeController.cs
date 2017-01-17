using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AzureWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly BloggingContext context;
        private readonly ILogger logger;

        public HomeController(BloggingContext context, ILogger<Startup> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public IActionResult Index()
        {
            logger.LogInformation("Página inicial");
            return View();
        }

        public IActionResult About()
        {
            logger.LogInformation("Página About");

            try
            {
                logger.LogInformation("Buscando por Blogs");
                var blog = context.Blogs.First(x => x.Titulo == "Titulo");
            }
            catch (Exception ex)
            {
                ViewBag.Erro = true;
                logger.LogError(new EventId(), "Erro na busca do blog", ex);
            }

            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            logger.LogInformation("Página de contatos");
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
