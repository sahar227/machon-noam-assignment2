using System;
using Xunit;

namespace BusinessLogic.Tests
{
    public class FieldValidatorTests
    {
        private FieldValidator _validator;
        public FieldValidatorTests()
        {
            _validator = new FieldValidator();
        }


        [Fact]
        public void IsValidEmail_ReturnsTrue_WhenValidEmail()
        {
            string email = "email@gmail.com";
            bool actual = _validator.IsValidEmail(email);
            bool expected = true;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("email")]
        [InlineData("em ail@gmail.com")]
        [InlineData("em!ail@gmail.com")]
        [InlineData("  email@gmail.com  ")]
        public void IsValidEmail_ReturnsFalse_WhenInvalidEmail(string email)
        {
            bool actual = _validator.IsValidEmail(email);
            bool expected = false;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("123456aA")]
        [InlineData("123456aA111avvBBBa")]
        [InlineData("aA123456aA")]
        public void IsValidPassword_ReturnsTrue_WhenValidPassword(string password)
        {
            bool actual = _validator.IsValidPassword(password);
            bool expected = true;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("123456 aA")]
        [InlineData(" 123456aA")]
        [InlineData("123456aA ")]
        [InlineData("123456aA@")]
        [InlineData("156aA")]
        [InlineData("123456a7")]
        [InlineData("123456A7")]
        [InlineData("12345678")]
        public void IsValidPassword_ReturnsFalse_WhenInvalidPassword(string password)
        {
            bool actual = _validator.IsValidPassword(password);
            bool expected = false;
            Assert.Equal(expected, actual);
        }
    }
}
