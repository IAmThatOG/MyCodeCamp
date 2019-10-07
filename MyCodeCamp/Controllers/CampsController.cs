using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCodeCamp.Domain.services;
using MyCodeCamp.Domain.services.implementations;

namespace MyCodeCamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampsController : Controller
    {
        private ICampService _campService;
        public CampsController(ICampService campService)
        {
            _campService = campService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var camps = await _campService.GetAll();
            return Ok(camps);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id, bool includeSpeakers)
        {
            var camps = await _campService.GetById(id, includeSpeakers);
            return Ok(camps);
        }
    }
}