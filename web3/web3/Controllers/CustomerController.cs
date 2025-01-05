using Microsoft.AspNetCore.Mvc;
using web3.Controllers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return Data.customerList;
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return Data.customerList.Find(c => c.IdC == id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Customer c)
        {
            Data.customerList.Add(c);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer cust)
        {Customer c= Data.customerList.Find(c => c.IdC == id);
            c = cust;
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Data.customerList.Remove(Data.customerList.Find(c => c.IdC == id));
        }
    }
}
