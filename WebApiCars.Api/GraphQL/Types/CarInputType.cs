using GraphQL.Types;
using WebApiCars.CrossCutting.Dtos;

namespace WebApiCars.Api.GraphQL.Types
{
    public class CarInputType : InputObjectGraphType<CarDto>
    {
        public CarInputType()
        {
            Name = "CarInput";

            Field(x => x.Model, type: typeof(StringGraphType));
            Field(x => x.Features, type: typeof(StringGraphType));
            Field(x => x.Year, type: typeof(IntGraphType));
        }
    }
}