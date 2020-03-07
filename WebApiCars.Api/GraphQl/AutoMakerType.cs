using GraphQL.Types;
using WebApiCars.Domain;

namespace WebApiCars.Api.GraphQl
{
    public class AutoMakerType : ObjectGraphType<AutoMaker>
    {
        public AutoMakerType()
        {
            Name = "Produto";

            Field(x => x.Name).Description("Name of Auto Maker");
        }
    }
}