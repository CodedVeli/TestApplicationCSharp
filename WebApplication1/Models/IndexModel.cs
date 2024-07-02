using WebApplication1.Controllers;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class IndexModel
    {
        public List<Person> Persons { get; set; }
        public string? SelectedValue { get; set; }
        public Person? SelectedItem { get; set; }
    }

    public class Person
    {
        public string? Value { get; set; }
        public string? Name { get; set; }
    }
}