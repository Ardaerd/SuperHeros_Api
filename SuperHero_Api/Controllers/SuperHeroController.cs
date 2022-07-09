using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private static List<SuperHero> heroes = new List<SuperHero>() {
            new SuperHero
            {
                Name = "Spider-Man",
                FirstName = "Peter",
                LastName = "Parker",
                Place = "New York City"
            },
            new SuperHero
            {
                Name = "Iron-Man",
                FirstName = "Tony",
                LastName = "Stark",
                Place = "New York City"
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            return Ok(heroes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<SuperHero>>> Get(int id)
        {
            var hero = heroes.Find(h => h.id == id);

            if (hero == null)
                return BadRequest("Hero not found.");

            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            heroes.Add(hero);
            return Ok(heroes);
        }



      

    }
}
