using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core.Models;
using ASP.NET_Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core.Controllers
{
    public class HomeController: Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel()
            {
                Pies = pies.ToList(),
                Title = "Welcome to Bethany's Pie Shop"
            };

            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();

            return View(pie);
        }
    }
}
