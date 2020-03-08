using GraphQL.Types;
using WebApiCars.CrossCutting.Dtos;
using WebApiCars.Domain;

namespace WebApiCars.Api.GraphQl
{
    public class AutoMakerType : ObjectGraphType<AutoMakerDto>
    {
        public AutoMakerType()
        {
            Field(x => x.Name).Description("Name of Auto Maker");
        }
    }
}