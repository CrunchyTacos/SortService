using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json.Linq;
using SortService.Models;
// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SortService.Controllers
{

    [Route("api/[controller]")]
    public class SortController : Controller
    {

        [FromServices]
        public ISortRepository sortArray { get; set; }

        // POST api/sort
        [HttpPost]
        public IActionResult Submit([FromBody]SortItem item)
        {
            if (item == null)
            {
                return HttpBadRequest();
            }
            sortArray.sort(item);
            return new ObjectResult(item);
        }
    }
}
