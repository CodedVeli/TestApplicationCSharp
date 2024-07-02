using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new IndexModel
            {
                Persons = new List<Person>
                {
                    new Person { Value = "jack", Name = "Jack" },
                    new Person { Value = "lucy", Name = "Lucy" },
                    new Person { Value = "tom", Name = "Tom" },
                    new Person { Value = "hernan", Name = "Hernán" },
                    new Person { Value = "marino", Name = "Marino" },
                }
            };
            return View(model);
        }

        [HttpPost]
        public void OnBlur()
        {
            Console.WriteLine("blur");
        }

        [HttpPost]
        public void OnFocus()
        {
            Console.WriteLine("focus");
        }

        [HttpPost]
        public void OnSelectedItemChangedHandler(string value)
        {
            var person = new Person { Value = value }; // Adjust this as needed to find the correct person
            Console.WriteLine($"selected: {person?.Name}");
        }

        [HttpPost]
        public IActionResult OnSearch(string value)
        {
            var model = new IndexModel
            {
                Persons = Persons.Where(p => p.Name.Contains(value, StringComparison.OrdinalIgnoreCase)).ToList()
            };
            return PartialView("_PersonList", model);
        }

        private List<Person> Persons => new List<Person>
        {
            new Person { Value = "jack", Name = "Jack" },
            new Person { Value = "lucy", Name = "Lucy" },
            new Person { Value = "tom", Name = "Tom" },
            new Person { Value = "hernan", Name = "Hernán" },
            new Person { Value = "marino", Name = "Marino" },
        };
    }
}
