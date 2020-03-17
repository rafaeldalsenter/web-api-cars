using GraphQL.Types;
using WebApiCars.CrossCutting.Dtos;

namespace WebApiCars.Api.GraphQL.Types
{
    public class AutoMakerInputType : InputObjectGraphType<AutoMakerDto>
    {
        public AutoMakerInputType()
        {
            Name = "AutoMakerInput";
            Field(x => x.Name, type: typeof(StringGraphType));
            Field(x => x.Country, type: typeof(StringGraphType));
        }
    }
}