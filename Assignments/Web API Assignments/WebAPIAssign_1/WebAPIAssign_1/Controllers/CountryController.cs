using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIAssign_1.Models;

namespace WebAPIAssign_1.Controllers
{
    [RoutePrefix("api/user")]
    public class CountryController : ApiController
    {
        static List<Country> countrylist = new List<Country>()
        {
            new Country{ID=1, Cname="India",Ccapital="NewDelhi"},
            new Country{ID=2,Cname="Egypt", Ccapital="Cairo"},
            new Country{ID=3,Cname="Germany", Ccapital="Berlin"},
            new Country{ID=4,Cname="Newzealand",Ccapital="Wellington"},
            new Country{ID=5,Cname="Australia",Ccapital="Canberra"}

        };
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(countrylist);
        }
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var country = countrylist.FirstOrDefault(co => co.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody] Country country)
        {
            if (country == null)
            {
                return BadRequest("Country cannot be null");
            }

            country.ID = countrylist.Count + 1;
            countrylist.Add(country);

            return CreatedAtRoute("DefaultApi", new { id = country.ID }, country);
        }
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody] Country country)
        {
            if (country == null)
            {
                return BadRequest("Country cannot be null");
            }

            var existingCountry = countrylist.FirstOrDefault(co => co.ID == id);
            if (existingCountry == null)
            {
                return NotFound();
            }

            existingCountry.Cname = country.Cname;
            existingCountry.Ccapital = country.Ccapital;

            return Ok(existingCountry);
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var country = countrylist.FirstOrDefault(co => co.ID == id);
            if (country == null)
            {
                return NotFound();
            }

            countrylist.Remove(country);

            return Ok(country);
        }


    }
}
