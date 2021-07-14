using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Splunk.Logger.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SplunkController : ControllerBase
    {
        [HttpGet]
        [Route("get")]
        public async Task<Dictionary<string, string>> Get()
        {
            var result = new Dictionary<string, string>
            {
                { "name","vahid" },{ "lastname","farahmandian" },{ "age","32" },{"timestamp",DateTime.Now.ToString()}
            };

            return result;
        }

        [HttpGet]
        [Route("get/exception")]
        public async Task<Dictionary<string, string>> GetEx(int id)
        {
            throw new Exception($"Something went wrong! id={id}");
        }
    }
}
