using GraphQL.Types;
using WebApiCars.Api.GraphQL.Types;
using WebApiCars.Application.Services;
using WebApiCars.CrossCutting.Dtos;

namespace WebApiCars.Api.GraphQL
{
    public class ApiMutation : ObjectGraphType
    {
        public ApiMutation(IAutoMakerServices autoMakerServices)
        {
            Field<AutoMakerType>(
                "createAutoMaker",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<AutoMakerType>> { Name = "automaker" }
                ),
                resolve: context =>
                    autoMakerServices.Create(context.GetArgument<AutoMakerDto>("automaker"))
            );
        }
    }
}