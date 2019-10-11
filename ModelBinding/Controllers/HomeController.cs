using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class HomeController : Controller
    {


        private IRepostory repostory;

        public HomeController(IRepostory _repostory)
        {
            repostory = _repostory;
        }
        public IActionResult Index(int? id)
        {



            Customers customer;
            if (id.HasValue && (customer = repostory.Get(id.Value)) != null)
            {
                return View(customer);

            }else{


              return NotFound();
            }

            
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View(new Customers());
        }


        [HttpPost]
        public IActionResult Create([Bind(nameof(Customers.FirsNamae), nameof(Customers.FirsNamae))]Customers customer)
             //public IActionResult Create(Customers customer)
        {
            return View("Index", customer);
        }





        public IActionResult Name(String[] names)
        {
            return View(names ?? new string[0]);
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
