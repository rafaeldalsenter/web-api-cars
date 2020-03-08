using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCars.Application.Repositories;

namespace WebApiCars.Api.Controllers
{
    [Route("teste")]
    public class TesteController : ControllerBase
    {
        private IAutoMakerRepository _autoMakerRepository;

        public TesteController(IAutoMakerRepository autoMakerRepository)
        {
            _autoMakerRepository = autoMakerRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_autoMakerRepository.Get());
        }
    }
}