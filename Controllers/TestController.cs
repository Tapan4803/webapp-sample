using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace webapp_sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly string _connectionString;

        public TestController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        [HttpGet("test-connection")]
        public IActionResult TestConnection()
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    return Ok("Connection to the database was successful!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Connection failed: {ex.Message}");
            }
        }
    }
}
