using System.Collections.Generic;
using System.Linq;
using WebApiCars.CrossCutting;
using WebApiCars.Domain;

namespace WebApiCars.Application.Repositories
{
    public class AutoMakerRepository : IAutoMakerRepository
    {
        private readonly WebApiCarsContext _context;

        public AutoMakerRepository(WebApiCarsContext context)
        {
            _context = context;
        }

        public IEnumerable<AutoMaker> Get() => _context.AutoMakers.ToList();
    }
}