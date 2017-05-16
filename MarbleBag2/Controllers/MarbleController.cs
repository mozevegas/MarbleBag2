using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MarbleBag2.Models;

namespace MarbleBag2.Controllers
{
    public class MarbleController : ApiController
    {
        public static List<Marble> newList = new List<Models.Marble>
        {
            new Marble{ Id=1, Color="Blue"},
            new Marble{ Id=2, Color="Red"},
            new Marble{ Id=3, Color="Green"},
            new Marble{ Id=4, Color="Purple"},
        };


        public IHttpActionResult Get ()
        {
            return Ok(newList);
        }
    }
}
