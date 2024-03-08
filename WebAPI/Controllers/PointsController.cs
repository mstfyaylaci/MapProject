using Business.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PointsController : ControllerBase
    {
        IPointService _pointService;

        public PointsController(IPointService pointService)
        {
            _pointService = pointService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _pointService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        //[HttpGet("getbyid")]
        //public IActionResult GetById(int id)
        //{
        //    var result = _pointService.GetById(id);

        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        // Json formatta olduğu zaman açılacak 
        [HttpGet("getid")]
        public IActionResult GetId(int id)
        {
            var result = _pointService.GetId(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Point point)
        {
            var result = _pointService.Add(point);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Point point)
        {
            var result = _pointService.Update(point);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Point point)
        {
            var result = _pointService.Delete(point);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
