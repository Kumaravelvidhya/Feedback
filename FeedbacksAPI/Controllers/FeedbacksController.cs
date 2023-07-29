using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iv = Feedback.Models;
using Feedback.Repository;
using Feedbacks.Business;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FeedbacksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbacksController : ControllerBase
    {
        // GET: api/<FeedbacksController>
        FeedbackRepository obj;
        public FeedbacksController()
        {
            obj = new FeedbackRepository();
        }
        [HttpGet]
        public IEnumerable<iv.FeedbackModel> Get()
        {
            return obj.Select();
        }

        // GET api/<FeedbacksController>/5
        [HttpGet("{Customername}")]
        public IEnumerable<iv.FeedbackModel> Get(string Customername)
        {
            return obj.Select(Customername);
        }

        // POST api/<FeedbacksController>
        [HttpPost]
        public void Post([FromBody] iv.FeedbackModel value)
        {
            obj.insert(value);
        }

        // PUT api/<FeedbacksController>/5
        [HttpPut("{Customerid}")]
        public void Put(int Customerid, [FromBody] iv.FeedbackModel value)
        {
            value.Customerid = Customerid;
            obj.updatesp(value);
        }

        // DELETE api/<FeedbacksController>/5
        [HttpDelete("{Customerid}")]
        public void Delete(string Customerid)
        {
            
          obj.deletesp(Customerid) ;
        }
    }
}
