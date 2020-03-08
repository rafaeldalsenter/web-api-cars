using GraphQL.Types;
using WebApiCars.Application.Repositories;

namespace WebApiCars.Api.GraphQl
{
    public class ApiQuery : ObjectGraphType
    {
        public ApiQuery(IAutoMakerRepository autoMakerRepository)
        {
            Field<ListGraphType<AutoMakerType>>(
                "automakers",
                resolve: context => autoMakerRepository.Get()
            );
        }
    }
}