using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCars.CrossCutting;

namespace WebApiCars.Api.GraphQl
{
    public class EatMoreQuery : ObjectGraphType
    {
        public EatMoreQuery(WebApiCarsContext webApiCarsContext)
        {
            Field<ListGraphType<AutoMakerType>>(
                "AutoMakers",
                resolve: context =>
                {
                    return webApiCarsContext.AutoMakers;
                });
        }
    }
}