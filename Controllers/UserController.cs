using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using JASP.IServices;
using JASP.Model;
using JASP.Service.DocumentDBService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JASP.Controllers
{
    [Route("api/user")]
    public class UserController : Controller
    {
        private AppSettings _appSetting;
        private IUser _user;
        public UserController(IOptions<AppSettings> settings, IUser user)
        {
            _appSetting = settings.Value;
            _user = user;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]UserBaseModel value)
        {
            var success = _user.AddUserAsync(value);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateUserAsync([FromBody]UserBaseModel value)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = await DocumentDBRepository<UserBaseModel>.CreateItemAsync(value);
                    if (response != null)
                        return Created("default", response);

                }
            }
            catch (Exception e)
            {

            }
            return BadRequest();
        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
