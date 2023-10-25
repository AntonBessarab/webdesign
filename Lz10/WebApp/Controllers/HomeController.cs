using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using WebApp.Models;
using WebApp.Data;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;


        public HomeController(ApplicationDbContext dbContext)

        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            IEnumerable<Book> books = _dbContext.Books;
            ViewBag.Books = books;
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