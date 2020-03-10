using Data.Config;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            try
            {
                //_context.ItensDoPedido.AddRange(
                //    new ItemDoPedido() { IdDoPedido = 1, NomeDoItem = "Oculos Rayban" },
                //    new ItemDoPedido() { IdDoPedido = 1, NomeDoItem = "Mouse Log" },
                //    new ItemDoPedido() { IdDoPedido = 1, NomeDoItem = "Notebook Daten" },
                //    new ItemDoPedido() { IdDoPedido = 1, NomeDoItem = "Samsumg J2" },
                //    new ItemDoPedido() { IdDoPedido = 1, NomeDoItem = "Mochila Volkano" }
                //    );

                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }

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
