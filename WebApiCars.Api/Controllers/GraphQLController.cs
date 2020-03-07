using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCars.Api.GraphQl;
using WebApiCars.CrossCutting;

namespace WebApiCars.Api.Controllers
{
    [Route("graphql")]
    public class GraphQLController : Controller
    {
        private readonly WebApiCarsContext _context;

        public GraphQLController(WebApiCarsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Post([FromBody]GraphQlQuery query)
        {
            var inputs = query.Variables.ToInputs();

            var schema = new Schema()
            {
                Query = new EatMoreQuery(_context)
            };

            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = query.Query;
                _.OperationName = query.OperationName;
                _.Inputs = inputs;
            }).ConfigureAwait(false);

            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}