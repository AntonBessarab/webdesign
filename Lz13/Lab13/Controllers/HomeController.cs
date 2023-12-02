using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using Lab13.Models;
using Lab13.Data;


namespace Lab13.Controllers
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
            IEnumerable<Film> books = _dbContext.Films;
            ViewBag.Books = books;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Create(Film film)
        {
            if(film !=null)
            {
                _dbContext.Films.Add(film);
                _dbContext.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]

        public IActionResult Buy(int? id)
        {
            ViewBag.FilmId = id ?? 0;
            return View();
        }

        [HttpPost]

        public string Buy(Purchase purchase) 
        {
            purchase.Date = DateTime.Now;

            _dbContext.Purchase.Add(purchase);
            _dbContext.SaveChanges();
            return "Дякуємо ," + purchase.Person + ",за купівлю!";
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