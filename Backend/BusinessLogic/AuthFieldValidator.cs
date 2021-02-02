using System;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public class AuthFieldValidator
    {
        public bool IsValidEmail(string email)
        {
            if (email == null)
                return false;
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return new Regex(pattern).IsMatch(email);
        }

        public bool IsValidPassword(string password)
        {
            if (password == null)
                return false;
            string pattern = @"^(?=[a-zA-Z0-9]{8,}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*";
            return new Regex(pattern).IsMatch(password);
        }
    }
}
