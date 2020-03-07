namespace WebApiCars.CrossCutting.Dtos
{
    public abstract class BaseDto
    {
        public string Mensagem { get; set; }
        public bool Valid { get; set; }
    }
}