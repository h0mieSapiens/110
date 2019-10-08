using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarRental.Models;

namespace CarRental.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }
        
    }
}