using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using System.Collections.Generic;


namespace TestAPI_1302210074.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class User2 : ControllerBase
    {
        public static List<User> a = new List<User>
        {
            new User ("Raihan Sulthon","1302210074"),
            new User ("RaihanS","6666666666"),
        };

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return a;
        }


        //Get: api/<User>
        [HttpGet("{id}")]
        public User Get(int id)
        {
            if (id < 0 || id >= a.Count)
            {
                NotFound();
            }
            return a[id];
        }

        //Post: api/<User> By Id
        [HttpPost]
        public void Post([FromBody] User value)
        {
            a.Add(value);
        }

        //Delete: api/<User> By Id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if(id<0 || id >= a.Count)
            {
                NotFound();
            }
            a.RemoveAt(id);
        }
    }
}
