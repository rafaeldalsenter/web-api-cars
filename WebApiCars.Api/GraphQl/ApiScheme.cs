using GraphQL;
using GraphQL.Types;

namespace WebApiCars.Api.GraphQL
{
    public class ApiScheme : Schema
    {
        public ApiScheme(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<ApiQuery>();
            Mutation = resolver.Resolve<ApiMutation>();
        }
    }
}