using System;
using System.Linq;
using WebApiCars.CrossCutting;
using WebApiCars.CrossCutting.Dtos;
using WebApiCars.Domain.Base;

namespace WebApiCars.Application.Services
{
    public abstract class BaseServices<TDto, TDomain>
        where TDto : BaseDto
        where TDomain : BaseDomain
    {
        private readonly WebApiCarsContext _context;

        public BaseServices(WebApiCarsContext context)
        {
            _context = context;
        }

        public abstract TDomain Builder(TDto dto);

        public abstract void AddToContext(TDomain domain);

        public TDto Create(TDto dto)
        {
            dto.Id = Guid.NewGuid();

            var domain = Builder(dto);

            if (!domain.IsValid())
            {
                dto.Valid = false;
                dto.Message = string.Join(',', domain.ErrorMessages.ToArray());
                return dto;
            }

            AddToContext(domain);
            _context.SaveChanges();

            dto.Valid = true;

            return dto;
        }
    }
}