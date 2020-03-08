using System.Collections.Generic;
using WebApiCars.CrossCutting.Dtos;
using WebApiCars.Domain;

namespace WebApiCars.Application.Repositories
{
    public interface IAutoMakerRepository
    {
        public IEnumerable<AutoMakerDto> Get();
    }
}