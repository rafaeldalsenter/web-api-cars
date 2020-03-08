using System.Collections.Generic;
using System.Linq;
using WebApiCars.CrossCutting;
using WebApiCars.CrossCutting.Dtos;

namespace WebApiCars.Application.Repositories
{
    public class AutoMakerRepository : IAutoMakerRepository
    {
        private readonly WebApiCarsContext _context;

        public AutoMakerRepository(WebApiCarsContext context)
        {
            _context = context;
        }

        public IEnumerable<AutoMakerDto> Get() =>
            _context.AutoMakers.Select(x => new AutoMakerDto
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
    }
}