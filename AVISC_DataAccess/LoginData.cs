using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public bool PerformLogin(string username, string password, string newPassword)
        {
            Connectar();

            DataRow[] rowsFound;
            string hashedPasswd, salt, storedPasswd, new_salt, query, name;
            bool valid = false;
            int numModificados;

            DataSet dts = PortarTaula("Users");
            rowsFound = dts.Tables[0].Select($"UserName = '{username}'");

            if (rowsFound.Length > 0)
            {
                salt = rowsFound[0].Field<string>("Salt");
                storedPasswd = rowsFound[0].Field<string>("Password");
                name = rowsFound[0].Field<string>("Login");

                if (password == "12345aA")
                {
                    new_salt = createSalt();
                    hashedPasswd = SaltPassword(newPassword, new_salt);
                    query = $"UPDATE Users SET Password = '{hashedPasswd}', Salt = '{new_salt}' WHERE UserName = '{username}'";

                    Executar(query);
                    valid = true;
                }
                else
                {
                    hashedPasswd = SaltPassword(password, salt);
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

        private string createSalt()
        {
            string createSalt;
            using (RNGCryptoServiceProvider rngCrypt = new RNGCryptoServiceProvider())
            {
                byte[] valor = new byte[20];
                rngCrypt.GetBytes(valor);
                createSalt = BitConverter.ToString(valor, 0);
            }
            return createSalt;
        }

    }
}
