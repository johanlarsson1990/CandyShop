﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Candyshop.Models;
using Candyshop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Candyshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICandyRepository _candyRepository;

        public HomeController(ICandyRepository candyRepository)
        {

            _candyRepository = candyRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                CandyOnSale = _candyRepository.GetCandyOnSale
            };

            return View(homeViewModel);
        }
    
    }
}
