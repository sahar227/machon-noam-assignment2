using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        public string EncryptedPassword { get; set; }
    }
}
