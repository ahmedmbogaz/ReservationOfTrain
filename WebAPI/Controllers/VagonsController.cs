using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VagonsController : ControllerBase
    {
        IVagonService _vagonService;

        public VagonsController(IVagonService vagonService)
        {
            _vagonService = vagonService;
        }


        [HttpPost("add")]
        public IActionResult Add(Vagon vagon)
        {
            var result = _vagonService.Add(vagon);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _vagonService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
