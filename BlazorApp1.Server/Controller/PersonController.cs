using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp.Shared;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorApp1.Server.Controller
{
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        // GET: api/<controller>
        [HttpGet]
        [Route("all")]
        public IEnumerable<PersonModel> GetPeople()
        {
            var output = new List<PersonModel>
            {
                new PersonModel {FirstName="Tim", LastName="Correy", AccountBalance=19.45M },
                new PersonModel {FirstName="Mary", LastName="Jones", AccountBalance=105.87M },
                new PersonModel {FirstName="John", LastName="Smith", AccountBalance=115.32M }
            };
            return output;
        }
        [HttpPost]
        public void Post(PersonModel person)
        {

        }

      
    }
}
