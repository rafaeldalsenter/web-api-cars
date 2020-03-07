using System;

namespace WebApiCars.CrossCutting.Dtos
{
    public class AutoMakerDto : BaseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}