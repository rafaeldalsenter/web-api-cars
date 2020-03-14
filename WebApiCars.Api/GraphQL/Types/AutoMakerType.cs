using GraphQL.Types;
using WebApiCars.CrossCutting.Dtos;
using WebApiCars.Domain;

namespace WebApiCars.Api.GraphQL.Types
{
    public class AutoMakerType : ObjectGraphType<AutoMakerDto>
    {
        public AutoMakerType()
        {
            Name = "AutoMaker";
            Field(x => x.Id, type: typeof(IdGraphType));
            Field(x => x.Name);
            Field(x => x.Country);
        }
    }
}