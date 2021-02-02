using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApi.DTO
{
    public class RegisterDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string RepeatedPassword { get; set; }
    }
}
