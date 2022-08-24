using GorinWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;


namespace GorinWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        //private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _context;

        public MembersController(IConfiguration configuration, ApplicationDbContext context)
        {
            //_configuration = configuration;
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Member>>> Get()
        {
            return Ok(await _context.Members.ToListAsync());
        }
    }
}
