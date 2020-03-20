using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCars.CrossCutting.Dtos;

namespace WebApiCars.Api.GraphQL.Types
{
    public class CarType : ObjectGraphType<CarDto>
    {
        public CarType()
        {
            Name = "Car";
            Field(x => x.Id, type: typeof(IdGraphType));
            Field(x => x.Features, type: typeof(StringGraphType));
            Field(x => x.Model, type: typeof(StringGraphType));
            Field(x => x.Year, type: typeof(IntGraphType));
        }
    }
}
