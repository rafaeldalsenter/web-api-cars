using System.Collections.Generic;
using System.Linq;
using WebApiCars.CrossCutting;
using WebApiCars.CrossCutting.Dtos;
using WebApiCars.CrossCutting.Extensions;

namespace WebApiCars.Application.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly WebApiCarsContext _context;

        public CarRepository(WebApiCarsContext context)
        {
            _context = context;
        }

        public IEnumerable<CarDto> Get(short? year = null, string model = null)
            => _context.Cars
                .Where(x => !year.HasValue || x.Year.Equals(year))
                .Where(x => model.IsNullOrWhiteSpace() || x.Model.Equals(model))
                .Select(x => new CarDto
                {
                    Id = x.Id,
                    Year = x.Year,
                    Model = x.Model,
                    Features = x.Features
                })
                .ToList();
    }
}