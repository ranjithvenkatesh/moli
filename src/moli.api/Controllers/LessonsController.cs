using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using moli.api.Models;
using moli.api.Models.Repository;

namespace moli.api.Controllers
{
    [Route("api/lesson")]
    [ApiController]
    public class LessonsController : Controller
    {
        private readonly IDataRepository<Lesson> _dataRepository;

        public LessonsController(IDataRepository<Lesson> dataRepository)
        {
          _dataRepository = dataRepository;
        }

        // GET: api/Lesson
        [HttpGet]
        public IActionResult Get()
        {
          IEnumerable<Lesson> lessons = _dataRepository.GetAll();
          return Ok(lessons);
        }

        // GET: api/Lesson/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
          Lesson lesson = _dataRepository.Get(id);

          if (lesson == null)
          {
            return NotFound("The lesson record couldn't be found.");
          }

          return Ok(lesson);
        }

      // POST: api/Lesson
      [HttpPost]
      public IActionResult Post([FromBody] Lesson lesson)
      {
        if (lesson == null)
        {
          return BadRequest("lesson is null.");
        }

        _dataRepository.Add(lesson);
        return CreatedAtRoute(
              "Get",
              new { Id = lesson.Id },
              lesson);
      }

      // PUT: api/Lesson/5
      [HttpPut("{id}")]
      public IActionResult Put(long id, [FromBody] Lesson lesson)
      {
        if (lesson == null)
        {
          return BadRequest("Lesson is null.");
        }

        Lesson LessonToUpdate = _dataRepository.Get(id);
        if (LessonToUpdate == null)
        {
          return NotFound("The Lesson record couldn't be found.");
        }

        _dataRepository.Update(LessonToUpdate, lesson);
        return NoContent();
      }

      // DELETE: api/Lesson/5
      [HttpDelete("{id}")]
      public IActionResult Delete(long id)
      {
        Lesson lesson = _dataRepository.Get(id);
        if (lesson == null)
        {
          return NotFound("The Lesson record couldn't be found.");
        }

        _dataRepository.Delete(id);
        return NoContent();
      }
  }
}
