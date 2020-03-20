using GraphQL;
using GraphQL.Types;
using WebApiCars.Api.GraphQL.Types;
using WebApiCars.Application.Services;
using WebApiCars.CrossCutting.Dtos;

namespace WebApiCars.Api.GraphQL
{
    public class ApiMutation : ObjectGraphType
    {
        public ApiMutation(IAutoMakerServices autoMakerServices, ICarServices carServices)
        {
            Name = "Mutation";

            Field<AutoMakerType>(
                "createautomaker",
                description: "Create a new Automaker",
                arguments: new QueryArguments(
                    new QueryArgument<AutoMakerInputType> { Name = "input" }
                ),
                resolve: (context) =>
                {
                    var dto = autoMakerServices.Create(context.GetArgument<AutoMakerDto>("input"));

                    if (dto.Valid) return dto;

                    throw new ExecutionError(dto.Message);
                }
            );

            Field<CarType>(
                "createcar",
                description: "Create a new Car",
                arguments: new QueryArguments(
                    new QueryArgument<CarInputType> { Name = "input" }
                ),
                resolve: (context) =>
                {
                    var dto = carServices.Create(context.GetArgument<CarDto>("input"));

                    if (dto.Valid) return dto;

                    throw new ExecutionError(dto.Message);
                }
            );
        }
    }
}