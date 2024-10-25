// Controllers/UserController.cs
using Microsoft.AspNetCore.Mvc;
using webapp_sample.Models;
using System.Collections.Generic;

namespace webapp_sample.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        // Simulated user data; replace this with actual database retrieval
        private static List<User> users = new List<User>
        {
            new User { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
            new User { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" }
        };

        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            return Ok(users);
        }
    }
}
