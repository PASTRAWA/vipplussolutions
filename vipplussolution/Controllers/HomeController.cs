using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using vipplussolution.Models;

namespace vipplussolution.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (var context = new AppDbContext())
            {
                var turlar = context.Turlar.ToList();
                return View(turlar);
            }
        }

        public IActionResult AddIndex()
        {
            using(var context = new AppDbContext())
            {
                return View();
            }
        }

       public IActionResult Ekle(Tours tur)
        {
            using(var context = new AppDbContext())
            {
                context.Turlar.Add(tur);
                context.SaveChanges();
            }
            return RedirectToAction("Ekle");
        }
    }
}
