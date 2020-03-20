using System;
using System.Collections.Generic;
using WebApiCars.CrossCutting.Dtos;

namespace WebApiCars.Application.Repositories
{
    public interface ICarRepository
    {
        IEnumerable<CarDto> Get(short? year = null, string model = null);

        CarDto Get(Guid id);
    }
}