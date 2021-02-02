using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiContracts
{
    public class RegisterRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string RepeatedPassword { get; set; }
    }
}
