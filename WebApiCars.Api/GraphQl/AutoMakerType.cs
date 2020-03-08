using GraphQL.Types;
using WebApiCars.Domain;

namespace WebApiCars.Api.GraphQl
{
    public class AutoMakerType : ObjectGraphType<AutoMaker>
    {
        public AutoMakerType()
        {
            Field(x => x.Id, type: typeof(IdGraphType))
                .Description("Id of Auto Maker");

            Field(x => x.Name).Description("Name of Auto Maker");
        }
    }
}