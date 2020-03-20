using WebApiCars.CrossCutting;
using WebApiCars.CrossCutting.Dtos;
using WebApiCars.Domain;
using WebApiCars.Domain.Builder;

namespace WebApiCars.Application.Services
{
    public class AutoMakerServices : BaseServices<AutoMakerDto, AutoMaker>, IAutoMakerServices
    {
        private readonly WebApiCarsContext _context;

        public AutoMakerServices(WebApiCarsContext context) : base(context)
        {
            _context = context;
        }

        public override void AddToContext(AutoMaker domain) => _context.AutoMakers.Add(domain);

        public override AutoMaker Builder(AutoMakerDto dto) => new AutoMakerBuilder()
                .WithCountry(dto.Country)
                .WithName(dto.Name)
                .WithId(dto.Id)
                .Build();
    }
}