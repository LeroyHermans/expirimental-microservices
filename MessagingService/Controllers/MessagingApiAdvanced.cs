using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MessagingService.Controllers
{
    [ApiController]
    [Route("api/v2/messaging")]
    public class MessagingApiAdvanced : ControllerBase
    {
        [HttpGet, Route("")]
        public async Task<IEnumerable<string>> Get()
        {
            return new string[] {"value4", "value5", "value6"};
        }
    }
}
