using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using Newtonsoft.Json;
using Simple.Models;

namespace Simple.Controllers
{
    public class BookController : ApiController
    {
        // GET: api/Book
        public HttpResponseMessage Get()
        {
            sathstudentEntities obj = new sathstudentEntities();

            //return new HttpResponseMessage() { Responce { Data = obj.Agencies.ToList() } };

            try
            {
                
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(new Responce { Data = obj.Agencies.ToList(),count=obj.Agencies.ToList().Count }));
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                return response;
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        // GET: api/Book/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Book
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Book/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Book/5
        public void Delete(int id)
        {
        }
    }
}
