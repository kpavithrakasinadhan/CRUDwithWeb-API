using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDwithWeb_API;
using CRUDwithWeb_API12;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRUDwithWeb_API.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class SuperMarketShopeController : ControllerBase
    {
        Marketing objj;

        public SuperMarketShopeController()
        {
            objj = new Marketing();
        }

        // GET: api/<SuperMarketShopeController>
        [HttpGet]
        public IEnumerable<SuperMarketShope> Get()
        {
            return objj.Select();
        }

       

        // POST api/<SuperMarketShopeController>
        [HttpPost]
        public void Post([FromBody] SuperMarketShope obj)
        {
            objj.SignUp(obj);

        }

        // PUT api/<SuperMarketShopeController>/5
        [HttpPut("{id}")]
        public void Put(string Name,  string Location)
        {
            objj.update(Name, Location);
        }

        // DELETE api/<SuperMarketShopeController>/5
        [HttpDelete("{id}")]
        public void Delete(int ShopId)
        {
            objj.delete(ShopId);
        }
    }
}
