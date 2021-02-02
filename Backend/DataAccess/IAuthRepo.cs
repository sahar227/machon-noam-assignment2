using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IAuthRepo
    {
        Task<bool> RegisterUser(User user);
    }
}
