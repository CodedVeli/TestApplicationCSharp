using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new IndexModel();
            model.Persons = new List<Person>
            {
                new Person { Value = "jack", Name = "Jack" },
                new Person { Value = "lucy", Name = "Lucy" },
                new Person { Value = "tom" , Name = "Tom" },
                new Person { Value = "hernan" , Name = "Hernán" },
                new Person { Value = "marino" , Name = "Marino" },
            };
            return View(model);
        }

        public void OnBlur()
        {
            Console.WriteLine("blur");
        }

        public void OnFocus()
        {
            Console.WriteLine("focus");
        }

        public void OnSelectedItemChangedHandler(Person value)
        {
            Console.WriteLine($"selected: {value?.Name}");
        }

        public void OnSearch(string value)
        {
            Console.WriteLine($"search: {value}");
        }
    }

    public class IndexModel
    {
        public List<Person> Persons { get; set; }
        public string SelectedValue { get; set; }
        public Person SelectedItem { get; set; }
    }

    public class Person
    {
        public string Value { get; set; }
        public string Name { get; set; }
    }
}