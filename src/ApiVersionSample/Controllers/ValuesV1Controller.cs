using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace apiversionsample.Controllers
{
    [ApiVersion("1.0", Deprecated = true)]
    [Route("api/values")]
    //[Route("api/v{version:apiVersion}/values")]
    [ApiController]
    public class ValuesV1Controller : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Version 1", "Version 1" };
        }
    }
}