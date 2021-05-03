using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseConfigurationController : ControllerBase
    {
        IBaseConfigurationService _baseConfigurationService;

        public BaseConfigurationController(IBaseConfigurationService baseConfigurationService)
        {
            _baseConfigurationService = baseConfigurationService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _baseConfigurationService.GetAll();

            if (result.Success) return Ok(result);

            return BadRequest(result);
        }
    }
}
