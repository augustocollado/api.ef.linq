using System.Collections.Generic;
using System.Linq;
using api.ef.linq.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.ef.linq.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : ControllerBase
    {
        [HttpGet]
        public IList<Country> Get()
        {
            return new trackingContext().Country.ToList();
        }
        
        [HttpPost]
        public void Post([FromBody] Country country)
        {
            var context = new trackingContext();

            var newCountry = new Country
            {
                Name = country.Name
            };

            context.Add<Country>(newCountry);
            context.SaveChanges();
        }

        [HttpPut]
        public void Put([FromBody] Country updatedCountry)
        {
            var context = new trackingContext();

            var country = context.Country.Where(c => c.Id == updatedCountry.Id).SingleOrDefault();
            country.Name = updatedCountry.Name;

            context.Update<Country>(country);
            context.SaveChanges();
        }

        [HttpDelete]
        public void Delete([FromBody] Country deletedCountry)
        {
            var context = new trackingContext();

            var country = context.Country.Where(c => c.Id == deletedCountry.Id).SingleOrDefault();
            
            context.Remove<Country>(country);
            context.SaveChanges();
        }

    }
}