using System.Collections.Generic;
using WebApiCars.CrossCutting.Dtos;

namespace WebApiCars.Application.Repositories
{
    public interface IAutoMakerRepository
    {
        IEnumerable<AutoMakerDto> Get(string name = null, string country = null);
    }
}