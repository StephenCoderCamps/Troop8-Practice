﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Kara.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Kara.API
{
    [Route("api/[controller]")]
    public class TeslasController : Controller
    {
        ApplicationDbContext _db;
        public TeslasController(ApplicationDbContext db)
        {
            this._db = db; 
        }
        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.Teslas.ToList());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
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
