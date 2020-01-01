using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Common;
using ToDoApp.Common.DAL.Abstract;
using ToDoApp.Common.SL.Abstract;
using ToDoApp.DAL;
using ToDoApp.DB.Entities;

namespace ToDoApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IUserService _userService;

        public ValuesController(IUserService userService)
        {
            _userService = userService;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            var filter = new Filter<User>();
            filter.Condition(u => u.Id < 2);

            var a = await _userService.AddUserAsync(new User
            {
                FirstName = "asdasdasd",
                Email = "asdasdasd",
                SecondName = "asdasd"
            });

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
