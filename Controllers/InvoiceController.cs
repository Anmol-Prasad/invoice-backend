using Microsoft.AspNetCore.Mvc;
using InvoiceAPI.Data;
using InvoiceAPI.Models;
using System.Linq;

namespace InvoiceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly AppDbContext _context;

        public InvoiceController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetInvoice()
        {
            var items = _context.Items.ToList();

            if (items == null || items.Count == 0)
            {
                return NotFound("No invoice found");
            }

            return Ok(new { items });
        }
    }
}