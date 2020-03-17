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
            Name = "Mutation";

            Field<AutoMakerInputType>(
                "createautomaker",
                description: "Create a new Automaker",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<AutoMakerInputType>> { Name = "automaker" }
                ),
                resolve: context =>
                {
                    //return autoMakerServices.Create(context.GetArgument<AutoMakerDto>("automaker"));
                    return new AutoMakerInputType { };
                }

            );
        }
    }
}