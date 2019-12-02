using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIB.Interfaces;
using CIB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIB.PhoneBookBlazorApp.Data.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneBookController : ControllerBase
    {
        IPhoneBookRepo _repo;
        public PhoneBookController(IPhoneBookRepo repo)
        {
            _repo = repo;
        }

        // GET: api/PhoneBook
        [HttpGet(Name = "GetAllPhoneBooks")]
        public async Task<IEnumerable<PhoneBook>> Get()
        {
            return await _repo.GetAllPhoneBooksAsync();
        }

        // GET: api/PhoneBook/5
        [HttpGet("{id}", Name = "GetPhoneBook")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PhoneBook
        [HttpPost]
        public async Task Post([FromBody] PhoneBook phoneBook)
        {
           await _repo.AddPhoneBook(phoneBook);
        }

        // PUT: api/PhoneBook/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
