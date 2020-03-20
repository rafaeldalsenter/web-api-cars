using WebApiCars.CrossCutting;
using WebApiCars.CrossCutting.Dtos;
using WebApiCars.Domain;
using WebApiCars.Domain.Builder;

namespace WebApiCars.Application.Services
{
    public class CarServices : BaseServices<CarDto, Car>, ICarServices
    {
        private readonly WebApiCarsContext _context;

        public CarServices(WebApiCarsContext context) : base(context)
        {
            _context = context;
        }

        public override void AddToContext(Car domain) => _context.Cars.Add(domain);

        public override Car Builder(CarDto dto) => new CarBuilder()
            .WithFeatures(dto.Features)
            .WithId(dto.Id)
            .WithModel(dto.Model)
            .WithYear(dto.Year)
            .Build();
    }
}