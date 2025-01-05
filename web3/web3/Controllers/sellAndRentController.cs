using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrokerController : ControllerBase
    {

        // GET: api/<BrokerController>
        [HttpGet]
        public IEnumerable<sellAndRent> Get()
        {
            return Data.sellAndRentList;
        }

        // GET api/<BrokerController>/5
        [HttpGet("{id}")]
        public sellAndRent Get(int id)
        {
            return Data.sellAndRentList.Find(b=>b.IdSOR==id);
        }

        // POST api/<BrokerController>
        [HttpPost]
        public void Post([FromBody] sellAndRent b)
        {
            Data.sellAndRentList.Add(b);
        }

        // PUT api/<BrokerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] sellAndRent b)//
        {
            sellAndRent sel = Data.sellAndRentList.Find(b => b.IdSOR == id);
            sel = b;
        }

        // DELETE api/<BrokerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Data.sellAndRentList.Remove(Data.sellAndRentList.Find(b=>b.IdSOR==id));
        }
    }
}


