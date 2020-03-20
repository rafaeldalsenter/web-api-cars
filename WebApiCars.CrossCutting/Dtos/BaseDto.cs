using System;

namespace WebApiCars.CrossCutting.Dtos
{
    public abstract class BaseDto
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public bool Valid { get; set; }
    }
}