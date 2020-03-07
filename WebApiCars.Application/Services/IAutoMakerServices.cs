using WebApiCars.CrossCutting.Dtos;

namespace WebApiCars.Application.Services
{
    public interface IAutoMakerServices
    {
        AutoMakerDto Create(AutoMakerDto dto);
    }
}