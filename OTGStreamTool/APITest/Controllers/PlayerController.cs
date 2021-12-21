using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OTGStreamToolBackEnd;
using Microsoft.AspNetCore.Cors;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APITest.Controllers
{

    
    [Route("api/[controller]")]
    [ApiController]
    
    public class PlayerController : ControllerBase
    {
        
        
        // GET: api/Player
        [EnableCors("Origins")]
        [HttpGet]
        public List<string> Get()
        {
            return Global.update.toList();
        }

        // GET api/<PlayerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PlayerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/player
        [HttpPut]
        [EnableCors("Origins")]
        public void Put([FromBody] UpdatePackage package)
        {
            Global.update = package;
        }

        // DELETE api/<PlayerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
