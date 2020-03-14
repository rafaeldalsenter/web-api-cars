namespace WebApiCars.CrossCutting.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);
    }
}