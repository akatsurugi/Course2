using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lecture1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {

        private static readonly string[] Cars = new[]
        {
            "Bono", "Kia", "Lancia", "Raven", "Jet", "Blade", "Venom", "Dusk", "Vader", "Black Bob"
        };

        [HttpGet(Name = "GetCars")]
        public IEnumerable<Cars> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Cars
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Cost = Random.Shared.Next(5000, 200000),
                Name = Cars[Random.Shared.Next(Cars.Length)],
                Description = "Some text for each car",
            })
            .ToArray();
        }



    }
}
