using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Model;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        List<Horse> MockDB = new List<Horse> {
            new Horse("zero","Chestnut"),
            new Horse("1st", "White"),
            new Horse("2nd", "Dark"),
            new Horse("3rd","4th") 
        };

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Horse>> Get()
        {
            return MockDB.ToArray();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Horse> Get(int id)
        {
            return MockDB[id];
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Post([FromBody] Horse value)
        {
            MockDB.Add(value);
            return $"{value.Name}added";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
