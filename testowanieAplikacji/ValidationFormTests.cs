using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestowanieAplikacj;
using Xunit;

namespace testowanieAplikacjiTests
{
    public class ValidationFormTests
    {
        [Theory]
        [InlineData("", "wypełnij pole")]
        [InlineData("abc", "słabe hasło")]
        [InlineData("abcdef", "średnie hasło")]
        [InlineData("abcdefgh", "dobre hasło")]
        [InlineData("abcdefgh!", "bardzo dobre hasło")]
        public void ValidatePassword_ShouldReturnCorrectResult(string password, string expected)
        {
            var validationForm = new ValidationForm();

            string result = validationForm.ValidatePassword(password);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("", "wypełnij pole")]
        [InlineData("test@example.com", "poprawny email")]
        [InlineData("test@example", "Niepoprawny email")]
        [InlineData("testexample.com", "Niepoprawny email")]
        public void ValidateEmail_ShouldReturnCorrectResult(string email, string expected)
        {
            var validationForm = new ValidationForm();

            string result = validationForm.ValidateEmail(email);

            Assert.Equal(expected, result);
        }
    }
}
