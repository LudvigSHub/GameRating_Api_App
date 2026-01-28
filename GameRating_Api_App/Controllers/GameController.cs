using Microsoft.AspNetCore.Mvc;
using GameRating_Api_App.Models;
using GameRating_Api_App.Services;

namespace GameRating_Api_App.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly GameService _service = new();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll()); 
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var game = _service.GetById(id);
            if (game == null)
                return NotFound();

            return Ok(game);
        }

        [HttpPost]
        public IActionResult Add(Game rating)
        {
            var created = _service.Add(rating);
            return Created("", created);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Game rating)
        {
            var updated = _service.Update(id, rating);
            if (updated == null)
                return NotFound();

            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _service.Delete(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}
