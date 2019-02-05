using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerDomain.Models;
using CustomerDomain.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CustomerDomain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        // GET api/values
        private ISQLRepository _rep;
        public CustomersController(ISQLRepository repo)
        {
            _rep = repo;
        }
        [HttpGet]
        public  ActionResult<IEnumerable<Customers>> Get()
        {
            var cust =  _rep.GetAllCustomers();
            return Ok(cust);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Customers> Get(int id)
        {
            var cust = _rep.GetCustomerbyid(id);
            return Ok(cust);
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<Customers>> Post([FromBody] Customers value)
        {
            var custs = await _rep.AddCustomer(value);
            return Ok(custs);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Customers>> Put([FromBody] Customers value)
        {
            var cust = await _rep.UpdateCustomer(value);
            return Ok(cust);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Customers>> Delete(int id)
        {
            var cust = await _rep.DeleteCustomer(id);
            return Ok(cust);
        }
    }
}
