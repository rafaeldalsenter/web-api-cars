using WebApiCars.CrossCutting.Dtos;

namespace WebApiCars.Application.Services
{
    public interface ICarServices
    {
        CarDto Create(CarDto dto);
    }
}