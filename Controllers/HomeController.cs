using DI_Learning.Models;
using Microsoft.AspNetCore.Mvc;

namespace DI_Learning.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository repository;
        private readonly ProductSum productSum;
        public HomeController(IRepository repo, ProductSum psum)
        {
            repository = repo;
            productSum = psum;
        }

        public IActionResult Index()
        {
            //ViewBag.Total = productSum.Total;
            ViewBag.HomeControllerGuid = repository.ToString();
            ViewBag.TotalGuid = productSum.Repository.ToString();
            return View(repository.Products);
        }

        public IActionResult Privacy()
        {
            ViewBag.HomeControllerGuid = repository.ToString();
            ViewBag.TotalGuid = productSum.Repository.ToString();
            return View(repository.Products);
        }

        public IActionResult Error()
        {
            ViewBag.HomeControllerGuid = repository.ToString();
            ViewBag.TotalGuid = productSum.Repository.ToString();
            return View(repository.Products);
        }
    }
}