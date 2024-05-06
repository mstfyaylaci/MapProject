using Business.Abstract;

using Entites.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolygonsController : ControllerBase
    {
        IPolygonService _polygonService;
        

        public PolygonsController(IPolygonService polygonService)
        {
            _polygonService = polygonService;
            
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _polygonService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _polygonService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        // Json formatta olduğu zaman açılacak 
        //[HttpGet("getid")]
        //public IActionResult GetId(int id)
        //{
        //    var result = _pointService.GetId(id);

        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        [HttpPost("add")]
        public IActionResult Add(Polygon polygon)
        {


            var result = _polygonService.Add(polygon);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Polygon polygon)
        {
            var result = _polygonService.Update(polygon);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Polygon polygon)
        {
            var result = _polygonService.Delete(polygon);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
