using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AVIDataAccess;

namespace AVISC_DataAccess
{
    public class LoginData : DataAccess
    {
        public string Username { get; set; }

        /// <summary>
        /// Intenta hacer un login y devuelve un booleano según si ha sido exitoso o no.
        /// </summary>
        /// <param name="username">Nombre del usuario al que se hará login.</param>
        /// <param name="password">Contraseña introducida.</param>
        /// <returns>"true" si es exitoso, "false" si no.</returns>
        public bool PerformLogin(string username, string password)
        {
            Connectar();

            DataRow[] rowsFound;
            string hashedPasswd, salt, storedPasswd;
            bool valid = false;

            DataSet dts = PortarTaula("Users");
            rowsFound = dts.Tables[0].Select($"UserName = '{username}'");

            if (rowsFound.Length > 0)
            {
                salt = rowsFound[0].Field<string>("Salt");

                hashedPasswd = SaltPassword(password, salt);
                storedPasswd = rowsFound[0].Field<string>("Password");
                if (storedPasswd == "12345aA") {
                    valid = password == storedPasswd; // Ignora hash para la contraseña por defecto
                }
                else
                {
                    valid = hashedPasswd == storedPasswd;
                }
            }
            if (valid)
            {
                Username = username;
            }
            return valid;
        }

        private string SaltPassword(string password, string salt)
        {
            string strHash;

            using (SHA256 hash = SHA256.Create())
            {
                string passwd = $"{salt}{password}";

                byte[] hashedBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(passwd));

                strHash = BitConverter.ToString(hashedBytes);
            }

            return strHash;
        }


    }
}
