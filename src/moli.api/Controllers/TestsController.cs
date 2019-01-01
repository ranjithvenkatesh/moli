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
    [Route("api/test")]
    [ApiController]
    public class TestsController : Controller
    {
        private readonly IDataRepository<Test> _dataRepository;

        public TestsController(IDataRepository<Test> dataRepository)
        {
          _dataRepository = dataRepository;
        }

        // GET: api/Test
        [HttpGet]
        public IActionResult Get()
        {
          IEnumerable<Test> tests = _dataRepository.GetAll();
          return Ok(tests);
        }

        // GET: api/Test/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
          Test test = _dataRepository.Get(id);

          if (test == null)
          {
            return NotFound("The test record couldn't be found.");
          }

          return Ok(test);
        }

      // POST: api/Test
      [HttpPost]
      public IActionResult Post([FromBody] Test test)
      {
        if (test == null)
        {
          return BadRequest("test is null.");
        }

        _dataRepository.Add(test);
        return CreatedAtRoute(
              "Get",
              new { Id = test.Id },
              test);
      }

      // PUT: api/Test/5
      [HttpPut("{id}")]
      public IActionResult Put(long id, [FromBody] Test test)
      {
        if (test == null)
        {
          return BadRequest("Test is null.");
        }

        Test TestToUpdate = _dataRepository.Get(id);
        if (TestToUpdate == null)
        {
          return NotFound("The Test record couldn't be found.");
        }

        _dataRepository.Update(TestToUpdate, test);
        return NoContent();
      }

      // DELETE: api/Test/5
      [HttpDelete("{id}")]
      public IActionResult Delete(long id)
      {
        Test test = _dataRepository.Get(id);
        if (test == null)
        {
          return NotFound("The Test record couldn't be found.");
        }

        _dataRepository.Delete(id);
        return NoContent();
      }
  }
}
