using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Morgan.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Morgan.API
{
    [Route("api/[controller]")]
    public class GuestbooksController : Controller
    {
        ApplicationDbContext _db;
        public GuestbooksController(ApplicationDbContext db) {
            this._db = db;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Guestbook> Get()
        {
            return _db.Guestbooks.ToList();
                }

        // GET api/values/5
        [HttpGet("{id}")]
        public Guestbook Get(int id)
        {
            return _db.Guestbooks.Where(g=> g.Id== id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Guestbook value)
        {
            _db.Guestbooks.Add(value);
            _db.SaveChanges();
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
