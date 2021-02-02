using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models
{
    public class User
    {
        public User(string email, string encryptedPassword)
        {
            Email = email;
            EncryptedPassword = encryptedPassword;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string EncryptedPassword { get; set; }
    }
}
