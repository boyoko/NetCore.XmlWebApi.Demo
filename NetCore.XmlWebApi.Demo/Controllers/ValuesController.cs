using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCore.XmlWebApi.Demo.Models;
using Microsoft.AspNetCore.Cors;

namespace NetCore.XmlWebApi.Demo.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [EnableCors("any")]
        public IActionResult Get(int id)
        {
#region 构建返回值
            var obj = new List<ExampleReturnObject>
            {
                new ExampleReturnObject
                {
                    Id = "001",
                    Name ="jacky",
                    Age = 20,
                    Gender = "男"
                },
                new ExampleReturnObject
                {
                    Id = "002",
                    Name ="xulei",
                    Age = 40,
                    Gender = "男"
                },
                new ExampleReturnObject
                {
                    Id = "003",
                    Name ="asdf",
                    Age = 35,
                    Gender = "男"
                }
            };
#endregion   
            return Ok(obj);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
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
