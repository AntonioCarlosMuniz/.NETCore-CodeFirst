using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Managers.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceStack.Redis;

namespace DotNetCoreWebAPI.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
   // [ApiController]
    public class ValuesController:Controller
    {
        private readonly IUserManager _userManager;
        private readonly IUserRoleManager _userRoleManager;
        private readonly IRoleManager _roleManager;

        public ValuesController(IUserManager userManager, IRoleManager roleManager, IUserRoleManager userRoleManager)
        {
            _userManager = userManager;
            _userRoleManager = userRoleManager;
            _roleManager = roleManager;
        }

        // GET api/values
        [HttpGet]
        [Route("getuser")]
        public object Get()
        {
            var data = (from user in _userManager.All()
                        join userRole in _userRoleManager.All() on user.Id equals userRole.UserId
                        join role in _roleManager.All() on userRole.RoleId equals role.Id
                        select new { user.FirstName, RoleName = role.Name, user.LastName }).ToList();

            Thread.Sleep(10000);

            return new { Message = "User Login Successful!", IsSuccess = true };
        }

        // GET api/values/5
        // [HttpGet("{id}")]
        [HttpGet]
       // [Route("get/{id}")]
        public string Get(int id)
        {
            using (RedisClient rdsClient = new RedisClient("localhost"))
            {
                rdsClient.Set<string>("Name", "Antonio Carlos");
            }

            using (RedisClient rdsClient = new RedisClient("localhost"))
            {
                return rdsClient.Get<string>("Name");
            }

        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            // For more information on protecting this API from Cross Site Request Forgery (CSRF) attacks, see https://go.microsoft.com/fwlink/?LinkID=717803
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            // For more information on protecting this API from Cross Site Request Forgery (CSRF) attacks, see https://go.microsoft.com/fwlink/?LinkID=717803
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            // For more information on protecting this API from Cross Site Request Forgery (CSRF) attacks, see https://go.microsoft.com/fwlink/?LinkID=717803
        }

    }
}
