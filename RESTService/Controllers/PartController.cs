using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using RESTService.Models;
using RESTService.DataSource;
using System.Collections;
using System.Data;
//using System.Web.Mvc;
using System.Web.Http.Description;

namespace RESTService.Controllers
{
    /*
     * swg: call the service in browser
     * use
     */
    //!!! RoutePrefix immer zuerst definieren um weiter unten 
    //Route relative dazu definieren zu können!!!
    [RoutePrefix("api/parts")]
    public class PartsController : ApiController
    {
        //example: http://localhost:51027/api/parts/
        //GET api/parts
        [Route("")]
        public IEnumerable<string> Get()
        {
            return new string[] { "part1", "part2" };
        }

        //[System.Web.Http.HttpGet, System.Web.Http.Route("")]
        //public IHttpActionResult GetPart(string id)
        //{
        //    PdmConnection con = new PdmConnection();
        //    Part part = con.GetPart(id);

        //    return Ok(part);
        //}

        // GET api/parts/5
        //System.Web.Mvc.ActionResult 
        [Route("{id}")]
        [ResponseType(typeof(LinkHelper<Part>))]
        public IHttpActionResult Get(string id)
        {
            PdmConnection con = new PdmConnection();
            Part part = con.GetPart(id);

            LinkHelper<Part> response = new LinkHelper<Part>(part);
            response.Links.Add(new Link
            {
                Href = Url.Link("DefaultApi", null), //new { part.OBID }),
                Rel = "put-part",
                Method = "PUT"
            });

            response.Links.Add(new Link
            {
                Href = Url.Link("PutSapStatus", new { id = part.OBID, SapStatus = "SAP-not-exist" }),
                Rel = "put-sap-status-not-exist",
                Method = "PUT"
            });

            response.Links.Add(new Link
            {
                Href = Url.Link("DocsForPart", null),
                Rel = "get-docs-for-part",
                Method = "GET"
            });

            //if (part == null)
            //{
            //    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            //}

            //return part;
            return Ok(response);
        }


        // POST api/part
        /// <summary>
        /// Create a new part
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public HttpResponseMessage Post([FromBody]Part value)
        {
            //TODO: implement
            string id = "dummy";

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("part/{0}", id));

            return response;
        }

        // PUT api/part/5
        /// <summary>
        /// Edit a new part
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(string id, [FromBody]string value)
        {
        }

        // DELETE api/part/5
        public void Delete(string id)
        {
        }
        // -------------------------------------------------

        //api/parts/2/GetDocs
        [Route("docs/{id}")]
        public string GetDocs(string id)
        {
            return "id: " + id;
        }

        //http://localhost:51027/api/parts/9/docs
        [Route("{partId}/docs")]
        public string GetOrdersByCustomer(int partId)
        {
            return "Test";
        }

        //http://localhost:51027/api/parts/bar/10
        [Route("bar/{partnr}")]
        [HttpGet]
        public Part Bar(string partNr)
        {
            PdmConnection con = new PdmConnection();
            Part part = con.GetPart(partNr);

            if (part == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return part;
        }

        //Get api/parts?partnumber=5&pci=6

        public Part GetPart(string partNumber, string pci)
        {
            PdmConnection con = new PdmConnection();
            Part part = con.GetPart(partNumber, pci);

            if (part == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return part;
        }

        public DataTable GetParts(string searchString)
        {
            PdmConnection con = new PdmConnection();
            DataTable result = con.SearchParts(searchString);

            return result;
        }

        private void Test()
        {
            int i = 0;
            i++;
            int w = 1;
            w++;
        }

    }
}
