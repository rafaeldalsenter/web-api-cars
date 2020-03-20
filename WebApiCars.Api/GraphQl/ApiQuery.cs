using GraphQL.Types;
using WebApiCars.Api.GraphQL.Types;
using WebApiCars.Application.Repositories;

namespace WebApiCars.Api.GraphQL
{
    public class ApiQuery : ObjectGraphType
    {
        public ApiQuery(IAutoMakerRepository autoMakerRepository, ICarRepository carRepository)
        {
            Name = "Query";

            Field<ListGraphType<AutoMakerType>>(
                "automakers",
                description: "Automakers from Memory Database",
                arguments: new QueryArguments(
                    new QueryArgument<StringGraphType> { Name = "name", Description = "Name of automaker" },
                    new QueryArgument<StringGraphType> { Name = "country", Description = "Country of automaker" }
                ),
                resolve: context =>
                    autoMakerRepository.Get(context.GetArgument<string>("name"),
                        context.GetArgument<string>("country"))
            );

            Field<ListGraphType<CarType>>(
                "cars",
                description: "Cars from Memory Database",
                arguments: new QueryArguments(
                    new QueryArgument<IntGraphType> { Name = "year", Description = "Year of car" },
                    new QueryArgument<StringGraphType> { Name = "model", Description = "Model of car" }
                ),
                resolve: context =>
                    carRepository.Get(context.GetArgument<short?>("year"),
                        context.GetArgument<string>("model"))
                );
        }
    }
}