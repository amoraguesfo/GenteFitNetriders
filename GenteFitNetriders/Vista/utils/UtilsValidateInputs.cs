using System.Text.RegularExpressions;

namespace GenteFitNetriders.Vista.utils
{
    internal class UtilsValidateInputs
    {
        //Funciones auxuliares de validacion....mover a las utilidades?
        public static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            if (name.Length < 3 || name.Length > 20)
                return false;

            // Opcional: verificar que el nombre solo tenga letras
            /*var regex = new Regex(@"^[a-zA-Z]+$");
            if (!regex.IsMatch(name))
                return false;*/

            return true;
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                //Validar con expresión regular
                var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                return regex.IsMatch(email);
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidTelf(string telf)
        {
            if (string.IsNullOrWhiteSpace(telf))
                return false;

            // Validar que el número de teléfono solo contenga números y el símbolo "+"
            var regex = new Regex(@"^[0-9+]+$");
            if (!regex.IsMatch(telf))
                return false;

            // Validar que el número de teléfono tenga al menos 8 dígitos
            var digitsOnly = new Regex(@"[^\d]");
            var digitCount = digitsOnly.Replace(telf, "").Length;
            if (digitCount < 8)
                return false;

            return true;
        }

        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            // Verificar que la contraseña tenga al menos 5 caracteres
            if (password.Length < 5)
                return false;

            return true;
        }

        public static bool PasswordsMatch(string pwd1, string pwd2)
        {
            if (string.IsNullOrWhiteSpace(pwd1) || string.IsNullOrWhiteSpace(pwd2))
                return false;

            // Verificar que ambas contraseñas sean iguales
            if (pwd1 != pwd2)
                return false;

            return true;
        }
    }
}
