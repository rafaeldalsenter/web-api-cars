using GraphQL.Types;
using WebApiCars.CrossCutting.Dtos;

namespace WebApiCars.Api.GraphQL.Types
{
    public class AutoMakerType : ObjectGraphType<AutoMakerDto>
    {
        public AutoMakerType()
        {
            Name = "AutoMaker";
            Field(x => x.Id, type: typeof(IdGraphType));
            Field(x => x.Name, type: typeof(StringGraphType));
            Field(x => x.Country, type: typeof(StringGraphType));
        }
    }
}