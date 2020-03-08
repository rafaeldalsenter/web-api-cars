using GraphQL;
using GraphQL.Types;

namespace WebApiCars.Api.GraphQl
{
    public class ApiScheme : Schema
    {
        public ApiScheme(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<ApiQuery>();
            //Mutation = resolver.Resolve<NHLStatsMutation>();
        }
    }
}