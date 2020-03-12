using GraphQL.Types;
using WebApiCars.Application.Repositories;

namespace WebApiCars.Api.GraphQL
{
    public class ApiQuery : ObjectGraphType
    {
        public ApiQuery(IAutoMakerRepository autoMakerRepository)
        {
            Name = "Query";

            Field<ListGraphType<AutoMakerType>>(
                "automakers",
                resolve: (context) => autoMakerRepository.Get()
            );

            //  Field<PlayerType>(
            //"player",
            //arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
            //resolve: context => playerRepository.Get(context.GetArgument<int>("id")));
        }
    }
}