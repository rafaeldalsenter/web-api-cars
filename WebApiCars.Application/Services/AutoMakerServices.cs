using System;
using System.Linq;
using WebApiCars.CrossCutting;
using WebApiCars.CrossCutting.Dtos;
using WebApiCars.Domain.Builder;

namespace WebApiCars.Application.Services
{
    public class AutoMakerServices : IAutoMakerServices
    {
        private readonly WebApiCarsContext _context;

        public AutoMakerServices(WebApiCarsContext context)
        {
            _context = context;
        }

        public AutoMakerDto Create(AutoMakerDto dto)
        {
            dto.Id = Guid.NewGuid();

            var domain = new AutoMakerBuilder()
                .WithName(dto.Name)
                .WithId(dto.Id)
                .Build();

            if (!domain.IsValid())
            {
                //dto.Valid = false;
                //dto.Mensagem = string.Join(',', domain.ErrorMessages.ToArray());
                return dto;
            }

            _context.AutoMakers.Add(domain);
            _context.SaveChanges();

            //dto.Valid = true;
            //dto.Mensagem = "Auto maker successfully created.";
            return dto;
        }
    }
}