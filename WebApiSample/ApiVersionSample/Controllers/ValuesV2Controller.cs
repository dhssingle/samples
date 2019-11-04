using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace apiversionsample.Controllers
{
    [ApiVersion("2.0")]
    [ApiController]
    [Route("api/values")]
    //[Route("api/v{version:apiVersion}/values")]
    public class ValuesV2Controller : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Version 2", "Version 2" };
        }
    }
}