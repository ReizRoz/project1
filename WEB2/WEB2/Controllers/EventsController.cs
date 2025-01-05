using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEB2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EventsController : ControllerBase

    {
        public static List<Event> events = new List<Event> {
        new Event{Id = 1,Title = "h.w",Start =new DateTime(2024,12,01),End = new DateTime(2024,12,03)},
        new Event { Id = 2, Title ="mark", Start =new DateTime(2024,12,02),End = new DateTime(2024,12,03)},
        new Event { Id = 3, Title = "wash",Start =new DateTime(2024,12,04),End = new DateTime(2024,12,05) }
    };

    public static int Count = 3;

    // GET: api/<EventsController>
    [HttpGet]
    public IEnumerable<Event> Get()
    {
        return events;
    }

    //// GET api/<EventsController>/5
    //[HttpGet("{id}")]
    //public string Get(int id)
    //{
    //    return "value";
    //}

    // POST api/<EventsController>
    [HttpPost]
    public void Post([FromBody] Event newevent)
    {
        events.Add(new Event
        {
            Id = ++Count,
            Title = newevent.Title,
            Start = new DateTime(2024, 12, 04),
            End = new DateTime(2024, 12, 05)
        }

     );

    }

    // PUT api/<EventsController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Event updatedEvent)//הסבר נוסף ל[FromBody] 
    {
        Event ev = events.FirstOrDefault(e => e.Id == id);

        ev.Title = updatedEvent.Title;
        ev.Start = updatedEvent.Start;
        ev.End = updatedEvent.End;

    }

    // DELETE api/<EventsController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        Event ev = events.FirstOrDefault(e => e.Id == id);
        {
            events.Remove(ev);
        }
    }
}
}
