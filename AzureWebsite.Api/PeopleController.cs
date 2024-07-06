using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AzureWebsite.Api.Models;

namespace AzureWebsite.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private static readonly List<Person> _people = new List<Person>
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
