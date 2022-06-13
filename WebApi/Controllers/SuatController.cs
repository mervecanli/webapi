using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    public class SuatController : ControllerBase
    {
        ISuatService _suatService;
        public SuatController(ISuatService suatService)
        {
            _suatService = suatService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _suatService.GetAll();
            if()
            {

            }
            return Ok(result);
        }


     



    }
}