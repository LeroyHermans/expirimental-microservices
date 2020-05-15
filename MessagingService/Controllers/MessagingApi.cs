using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MessagingService.Controllers
{
    [ApiController]
    [Route("api/messaging")]
    public class MessagingApi : ControllerBase
    {
        [HttpGet, Route("")]
        public async Task<IEnumerable<string>> Get()
        {
            return new string[] {"value1", "value2"};
        }
    }
}
