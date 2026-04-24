using Microsoft.AspNetCore.Mvc;

namespace InvoiceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetData()
        {
            string result = "Sample Data"; // fixed null issue

            if (!string.IsNullOrEmpty(result))
            {
                return Ok(new { message = result });
            }

            return BadRequest("No data");
        }
    }
}