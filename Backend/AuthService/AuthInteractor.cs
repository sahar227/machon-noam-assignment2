using ApiContracts;
using BusinessLogic;
using DataAccess;
using DataAccess.Models;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AuthService
{
    public class AuthInteractor
    {
        private readonly IAuthRepo _authRepo;
        private readonly AuthFieldValidator _validator;

        public AuthInteractor(IAuthRepo authRepo, AuthFieldValidator validator)
        {
            _authRepo = authRepo;
            _validator = validator;
        }

        public async Task<bool> RegisterNewUser(RegisterRequest request)
        {
            if (!IsValidAuthRequest(request))
                return false;

            string encryptedPassword = EncryptPassword(request.Password);

            bool result = await _authRepo.RegisterUser(new User(request.Email, encryptedPassword));
            return result;
        }

        private bool IsValidAuthRequest(RegisterRequest request)
        {
            if (request.Password != request.RepeatedPassword)
                return false;
            if (!_validator.IsValidEmail(request.Email) || !_validator.IsValidPassword(request.Password))
                return false;
            if (_authRepo.IsEmailTaken(request.Email))
                return false;
            return true;
        }

        private string EncryptPassword(string password)
        {
            var sha1 = new SHA1CryptoServiceProvider();
            var sha1data = sha1.ComputeHash(Encoding.ASCII.GetBytes(password));
            string encrypedPassword = Convert.ToBase64String(sha1data);
            return encrypedPassword;
        }
    }
}
