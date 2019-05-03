using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using ServiceStack.Redis;

namespace DotNetCoreWebAPI.Controllers
{
    public class RedisController : Controller
    {
        private readonly IDistributedCache _cache;
        
        public RedisController(IDistributedCache cache)
        {
            _cache = cache;
        }

        public string Index()
        {
            using (RedisClient rdsClient = new RedisClient("localhost"))
            {
                return rdsClient.Get<string>("Name");
            }
        }
    }
}