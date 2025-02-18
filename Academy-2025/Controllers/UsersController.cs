using Academy_2025.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Academy_2025.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public static List<User>? Users = new List<User>();

        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return Users;
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            foreach (var user in Users)
            {
                if (user.Id == id)
                {
                    return Ok(user);
                }
            }

            return NotFound();
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult Post([FromBody] User data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Users.Add(data);

            return NoContent();
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] User data)
        {
            foreach (var user in Users)
            {
                if (user.Id == id)
                {
                    user.FirstName = data.FirstName;
                    user.LastName = data.LastName;

                    return NoContent();
                }
            }

            return NotFound();
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            foreach (var user in Users)
            {
                if (user.Id == id)
                {
                    Users.Remove(user);

                    return NoContent();
                }
            }

            return NotFound();
        }
    }
}
