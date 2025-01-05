using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {

 
        // GET: api/<ApartmentController>
        [HttpGet]
        public IEnumerable<Apartment> Get()
        {
        return Data.apartmentList;
        }

        // GET api/<ApartmentController>/5
        [HttpGet("{ForRent}")]
        public Apartment Get(EForSelOrRent e)
        {
            return Data.apartmentList.Find(a=>a.ForSellOrRent==EForSelOrRent.ForRent);
        }

        [HttpGet("city/{city}")]
        public Apartment Get(string city)
        {
            return Data.apartmentList.Find(a => a.City == city);
        }
        [HttpGet("price/{price}")]
        public List<Apartment> GetByPrice(int price)
        {
            return Data.apartmentList.FindAll(a => a.Price*0.9 > price);
        }

        // POST api/<ApartmentController>
        [HttpPost]
        public void Post([FromBody] Apartment a)
        {
            Data.apartmentList.Add(a);
        }

        // PUT api/<ApartmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Apartment a)
        {
           Apartment apa=Data.apartmentList.Find(a => a.Id == id);
            apa = a;
        }

        // DELETE api/<ApartmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Data.apartmentList.Remove(Data.apartmentList.Find(a=>a.Id==id));
        }
    }
}
