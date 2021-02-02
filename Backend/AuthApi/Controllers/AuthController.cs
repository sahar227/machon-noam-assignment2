using ApiContracts;
using AuthService;
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
        private readonly AuthInteractor _authInteractor;

        public AuthController(AuthInteractor authInteractor)
        {
            _authInteractor = authInteractor;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser(RegisterRequest registerRequest)
        {
            var ok = await _authInteractor.RegisterNewUser(registerRequest);
            if (ok)
                return NoContent();
            return BadRequest();
        }
    }
}
