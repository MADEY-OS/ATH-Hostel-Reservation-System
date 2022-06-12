using ATHHRS.API.Models;
using ATHHRS.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace ATHHRS.API.Controllers
{
    [Route("api/hostel")]
    public class HostelController : ControllerBase
    {
        private readonly IHostelService _hostelService;

        public HostelController(IHostelService hostelService)
        {
            _hostelService = hostelService;
        }

        //GET ALL
        [HttpGet]
        public ActionResult<IEnumerable<HostelDto>> GetAll()
        {
            var hostelsDtos = _hostelService.GetAll();
            return Ok(hostelsDtos);
        }

        //GET Single
        [HttpGet("{id}")]
        public ActionResult<HostelDto> Get([FromRoute] int id)
        {
            var hostel = _hostelService.GetById(id);

            if (hostel is null) return NotFound();

            return Ok(hostel);
        }

        //POST
        [HttpPost]
        public ActionResult CreateHostel([FromBody] CreateHostelDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var id = _hostelService.Create(dto);

            return Created($"/api/hostel/{id}", null);
        }

        //DELETE
        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            var isDeleted = _hostelService.Delete(id);

            if(isDeleted) return NotFound();

            return NoContent();
        }

        //PUT
        [HttpPut("{id}")]
        public ActionResult Update([FromBody] UpdateHostelDto dto, [FromRoute] int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var isUpdated = _hostelService.Update(id, dto);

            if (!isUpdated) return NotFound();

            return Ok();
        }
    }
}

