using System.Collections.Generic;
using WebApplication1.Entities;

namespace WebApplication1.Models
{
    public class AllProducts
    {
        public List<Drink> Drinks { get; set; }
        public List<FastFood> FastFoods { get; set; }
        public List<HotMeal> HotMeals { get; set; }

        public AllProducts()
        {

        }

        public AllProducts(List<Drink> drinks, List<FastFood> fastFoods, List<HotMeal> hotMeals)
        {
            Drinks = drinks;
            FastFoods = fastFoods;
            HotMeals = hotMeals;
        }
    }
}
