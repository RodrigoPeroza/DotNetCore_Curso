﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aula01_MVC.Models;
using Aula01_MVC.Repository;

namespace Aula01_MVC.Controllers
{
    public class HomeController : Controller
    {
        
        private IPeopleRepository _peopleRepository;

        public HomeController(IPeopleRepository repository){
            _peopleRepository = repository;
        }
        
        public IActionResult Index()
        {
            ViewData["Name"] = _peopleRepository.GetNameById(1);
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
