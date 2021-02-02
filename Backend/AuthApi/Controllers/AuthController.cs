using ApiContracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {

        public AuthController()
        {
        }

        [HttpPost]
        public IActionResult Post(RegisterRequest registerRequest)
        {
            throw new NotImplementedException();
        }
    }
}
