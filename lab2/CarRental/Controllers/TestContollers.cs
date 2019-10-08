using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;




namespace CarRental.Controllers
{

    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()

        {
            return View();
        }
        public IActionResult Homework2()
        {
            int num = 12;
            List<int> dividers = new List<int>();



            return Json(dividers);


        }


    }


}