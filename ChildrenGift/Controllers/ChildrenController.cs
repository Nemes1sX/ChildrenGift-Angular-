using ChildrenGift.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChildrenGift.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildrenController : ControllerBase
    {
        private readonly IChildrenRepository _childrenRepository;

        public ChildrenController(IChildrenRepository childrenRepository)
        {
            _childrenRepository = childrenRepository;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        [Route("index")]
        public async Task<ActionResult> Get()
        {
            var childernList = await _childrenRepository.GetChildren(); 

            return Ok(childernList);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
