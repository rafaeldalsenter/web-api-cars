using System;
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

        public AutoMaker GetById(Guid id)
            => _context.AutoMakers.Where(x => x.Id.Equals(id)).FirstOrDefault();
    }
}