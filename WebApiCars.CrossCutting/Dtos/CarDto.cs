namespace WebApiCars.CrossCutting.Dtos
{
    public class CarDto : BaseDto
    {
        public string Features { get; set; }
        public string Model { get; set; }
        public short Year { get; set; }
    }
}