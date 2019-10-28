using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        // GET: api/Course
        [HttpGet]
        public ActionResult<string> Get()
        {
            SqlConnection corn = new SqlConnection();
            corn.ConnectionString =
               "Data Source=db.swinswd.com; Initial Catalog=anguyen; User id=anguyen; Password=&hKqe508";
            corn.Open();

            return corn.State.ToString();
        }

        // GET: api/Course/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Course
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Course/5
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
