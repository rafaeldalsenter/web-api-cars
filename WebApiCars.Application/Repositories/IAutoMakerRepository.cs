using System;
using WebApiCars.Domain;

namespace WebApiCars.Application.Repositories
{
    public interface IAutoMakerRepository
    {
        public AutoMaker GetById(Guid id);
    }
}