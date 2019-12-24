using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITRepairWorkshopWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ITRepairWorkshopWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        ApplicationContext db;
        public ClientsController(ApplicationContext context)
        {
            db = context;

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> Get()
        {
            return await db.Clients.ToListAsync();
        }
        // GET api/users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> Get(int id)
        {
            Client client = await db.Clients.FirstOrDefaultAsync(x => x.ClientID == id);
            if (client == null)
                return NotFound();
            return new ObjectResult(client);
        }
    }
}