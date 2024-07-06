using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureWebsite.Api.Models; // Add this using directive

namespace AzureWebsite.Api
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly List<Person> _people = new List<Person>
        {
            new Person { Id = 1, FirstName = "Jan", LastName = "Nowak", PhoneNumber = "123123" },
            new Person { Id = 2, FirstName = "Marek", LastName = "Kowalski", PhoneNumber = "0" }
        };

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _people;
        }
    }
}
