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

        public HomeController(BloggingContext context, ILoggerFactory loggerFactory)
        {
            this.context = context;
            logger = loggerFactory.CreateLogger<Startup>();
        }

        public IActionResult Index()
        {
            try
            {
                var blog = context.Blogs.First(x => x.Titulo == "Titulo");
            }
            catch (Exception ex)
            {
                logger.LogError(new EventId(), "Erro na busca do blog", ex);
            }

            return View();
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

        public IActionResult Error()
        {
            return View();
        }
    }
}
