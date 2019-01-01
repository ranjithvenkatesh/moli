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
    [Route("api/user")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IDataRepository<User> _dataRepository;

        public UsersController(IDataRepository<User> dataRepository)
        {
          _dataRepository = dataRepository;
        }

        // GET: api/User
        [HttpGet]
        public IActionResult Get()
        {
          IEnumerable<User> users = _dataRepository.GetAll();
          return Ok(users);
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
          User user = _dataRepository.Get(id);

          if (user == null)
          {
            return NotFound("The user record couldn't be found.");
          }

          return Ok(user);
        }

      // POST: api/User
      [HttpPost]
      public IActionResult Post([FromBody] User user)
      {
        if (user == null)
        {
          return BadRequest("user is null.");
        }

        _dataRepository.Add(user);
        return CreatedAtRoute(
              "Get",
              new { Id = user.Id },
              user);
      }

      // PUT: api/User/5
      [HttpPut("{id}")]
      public IActionResult Put(long id, [FromBody] User user)
      {
        if (User == null)
        {
          return BadRequest("User is null.");
        }

        User UserToUpdate = _dataRepository.Get(id);
        if (UserToUpdate == null)
        {
          return NotFound("The User record couldn't be found.");
        }

        _dataRepository.Update(UserToUpdate, user);
        return NoContent();
      }

      // DELETE: api/User/5
      [HttpDelete("{id}")]
      public IActionResult Delete(long id)
      {
        User user = _dataRepository.Get(id);
        if (user == null)
        {
          return NotFound("The User record couldn't be found.");
        }

        _dataRepository.Delete(id);
        return NoContent();
      }
  }
}
