using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AuthRepo : IAuthRepo
    {
        private readonly AuthDbContext _context;

        public AuthRepo(AuthDbContext context)
        {
            _context = context;
        }

        public bool IsEmailTaken(string email)
        {
            return _context.Users.Any(user => user.Email == email);
        }

        public async Task<bool> RegisterUser(User user)
        {
            if (user == null)
                return false;
            try
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
