using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;

namespace webapiwithdb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        string[] days = {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"};
        // GET: api/Values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return days;
        }

        // GET: api/Values/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            string val1 = Array.Find(days, element => element.StartsWith("S",StringComparison.Ordinal));
            string val2 = days.Select()
            //String val3 = days.Select(x => x.Length >= id && x[id])
            return string.Concat("Val1"+val1, " Val2"+val2);
        }

        // POST: api/Values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Values/5
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
