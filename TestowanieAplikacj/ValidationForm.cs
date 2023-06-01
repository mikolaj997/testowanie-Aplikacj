using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestowanieAplikacj
{
    public class ValidationForm
    {

        public string ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return "wypełnij pole";
            }
            else if (password.Length > 0 && password.Length <= 5)
            {
                return "słabe hasło";
            }
            else if (password.Length > 5 && password.Length < 8)
            {
                return "średnie hasło";
            }
            else if (password.Length >= 8 && password.Length <= 13)
            {
                if (password.Contains("!") || password.Contains("@") || password.Contains("#") || password.Contains("$") || password.Contains("%") || password.Contains("^"))
                {
                    return "bardzo dobre hasło";
                }
                else
                {
                    return "dobre hasło";
                }
            }
            else if (password.Length > 13)
            {
                throw new Exception("Hasło jest zbyt długie.");
            }
            else
            {
                return "Niepoprawne hasło";
            }
        }

        public string ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return "wypełnij pole";
            }
            else if (email.Contains("@") && email.Split('.').Last().Length == 3)
            {
                return "poprawny email";
            }
            else
            {
                return "Niepoprawny email";
            }
        }

    }
}
