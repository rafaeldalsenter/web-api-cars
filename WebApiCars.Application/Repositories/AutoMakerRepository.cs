using System.Collections.Generic;
using System.Linq;
using WebApiCars.CrossCutting;
using WebApiCars.CrossCutting.Dtos;
using WebApiCars.CrossCutting.Extensions;

namespace WebApiCars.Application.Repositories
{
    public class AutoMakerRepository : IAutoMakerRepository
    {
        private readonly WebApiCarsContext _context;

        public AutoMakerRepository(WebApiCarsContext context)
        {
            _context = context;
        }

        public IEnumerable<AutoMakerDto> Get(string name = null, string country = null) =>
            _context.AutoMakers
                .Where(x => name.IsNullOrWhiteSpace() || x.Name.Contains(name))
                .Where(x => country.IsNullOrWhiteSpace() || x.Country.Contains(country))
                .Select(x => new AutoMakerDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Country = x.Country
                })
                .ToList();
    }
}