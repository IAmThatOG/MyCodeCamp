using System;
using Microsoft.AspNetCore.Mvc;

namespace MyCodeCamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampsController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new {name = "shawn", favouriteColor = "Blue"});
        }                                                                                                                                                                                          
    }
}