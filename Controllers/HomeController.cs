using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(GetAllProducts());
        }

        public IActionResult Drinks()
        {

            return View(GetDrinks());
        }

        public IActionResult HotMeals()
        {
            return View(GetHotMeals());
        }

        public IActionResult FastFoods()
        {
            return View(GetFastFoods());
        }

        public List<Drink> GetDrinks()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink
                {
                    Id = 1,
                    Name = "Sirab",
                },

                new Drink
                {
                    Id= 2,
                    Name = "Coca-Cola"
                },

                new Drink
                {
                    Id = 3,
                    Name = "Bizon"
                }
            };

            return drinks;
        }

        public List<HotMeal> GetHotMeals()
        {
            List<HotMeal> hotMeals = new List<HotMeal>
            {
                new HotMeal
                {
                    Id = 1,
                    Name = "Buglama",
                },

                new HotMeal
                {
                    Id= 2,
                    Name = "Jiz-Biz"
                },

                new HotMeal
                {
                    Id = 3,
                    Name = "Kufte Bozbash"
                }
            };

            return hotMeals;
        }

        public List<FastFood> GetFastFoods()
        {
            List<FastFood> fastFoods = new List<FastFood>
            {
                new FastFood
                {
                    Id = 1,
                    Name = "Cheeseburger",
                },

                new FastFood
                {
                    Id= 2,
                    Name = "Chicken Sandwich"
                },

                new FastFood
                {
                    Id = 3,
                    Name = "Fries"
                }
            };

            return fastFoods;
        }
    
        public AllProducts GetAllProducts()
        {
            var all = new AllProducts(GetDrinks(), GetFastFoods(), GetHotMeals());
            return all;
        }
    }
}
