using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DuckController : ControllerBase
    {
        private readonly IDuckService _duckService;

        public DuckController(IDuckService duckService)
        {
            _duckService = duckService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_duckService.GetDucks().Select(duck => new {Color = duck.Color.Name, duck.Name}));
        }
    }
}