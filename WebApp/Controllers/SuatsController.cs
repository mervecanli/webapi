using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuatsController : ControllerBase
    {
        ISuatService _suatService;
        public SuatsController(ISuatService suatService)
        {
            _suatService = suatService;
        }


        [HttpGet("getall")]
        public IActionResult GetAllt()
        {
            var result = _suatService.GetAll();
            return Ok(result);
        }
        



    }
}
