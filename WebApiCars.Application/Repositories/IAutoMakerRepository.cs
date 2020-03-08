using System.Collections.Generic;
using WebApiCars.Domain;

namespace WebApiCars.Application.Repositories
{
    public interface IAutoMakerRepository
    {
        public IEnumerable<AutoMaker> Get();
    }
}