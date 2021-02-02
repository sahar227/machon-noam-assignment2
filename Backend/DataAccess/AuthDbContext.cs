using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class AuthDbContext : DbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> opt) : base(opt)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
