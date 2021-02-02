using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
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
        public async Task<bool> RegisterUser(User user)
        {
            if (user == null)
                return false;
            try
            {
                _context.Add(user);
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
