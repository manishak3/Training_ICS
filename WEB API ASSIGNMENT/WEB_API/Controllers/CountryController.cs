using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEB_API.Models;

namespace WEB_API.Controllers
{
    [RoutePrefix("api/user")]
    public class CountryController : ApiController
        {
        static List<Country> countries = new List<Country>
    {

        new Country { id = 1, CountryName = "India", Capital = "Delhi" },
        new Country { id = 2, CountryName = "China", Capital = "Beijing" },
        new Country { id = 3, CountryName = "Saudi Arabia", Capital = "Riyadh" },
       };
   

            // GET: api/Country
            public IHttpActionResult Get()
            {
                return Ok(countries);
            }

            // GET: api/Country/1
            public IHttpActionResult Get(int id)
            {
                var country = countries.FirstOrDefault(c => c.id == id);
                if (country == null)
                {
                    return NotFound();
                }
                return Ok(country);
            }

            // POST: api/Country
            public IHttpActionResult Post([FromBody] Country country)
            {
                country.id = countries.Count + 1;
                countries.Add(country);
                return CreatedAtRoute("DefaultApi", new { id = country.id }, country);
            }

            // PUT: api/Country/1
            public IHttpActionResult Put(int id, [FromBody] Country updatedCountry)
            {
                var country = countries.FirstOrDefault(c => c.id == id);
                if (country == null)
                {
                    return NotFound();
                }

                country.CountryName = updatedCountry.CountryName;
                country.Capital = updatedCountry.Capital;

                return Ok(country);
            }

            // DELETE: api/Country/1
            public IHttpActionResult Delete(int id)
            {
                var country = countries.FirstOrDefault(c => c.id == id);
                if (country == null)
                {
                    return NotFound();
                }

                countries.Remove(country);

                return Ok(country);
            }
        }

    }
