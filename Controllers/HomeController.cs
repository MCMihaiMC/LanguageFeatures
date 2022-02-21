using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<string> results = new List<string>();

            if (Product.GetProducts().Length > 0)
            {
                foreach (Product p in Product.GetProducts())
                {
                    string name = p?.Name;
                    decimal? price = p?.Price;

                    results.Add(string.Format($"Name: {name}, Price: {price}"));
                }

                return View(results);
            }
            else 
                return View(new string[] { "C#", " Language", "Features" });
        }
    }
}
