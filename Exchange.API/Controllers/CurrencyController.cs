using AdvancedSearch.Repository;
using Exchange.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exchange.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CurrencyController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Currency> Get()
        {
            return _context.Currency.ToArray();
        }
        [HttpGet("{id}")]
        public Currency Get(int id)
        {
            return _context.Currency.FirstOrDefault(p => p.Id == id);
        }
    }
}
