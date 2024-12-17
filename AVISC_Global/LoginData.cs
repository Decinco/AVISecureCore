using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AVIDataAccess;

namespace AVISC_Global {  
    /// <summary>
    /// Clase global que incluye los datos del usuario necesarios para correr el programa
    /// </summary>
    public static class LoginData
    {
        public static string UserName { get; set; }

        public static Image ProfilePicture { get; set; }

        public static string CategoryName { get; set; }

        public static List<DataRow> AvailableOptions { get; set; }

        private static DataAccess Data = new DataAccess();

        /// <summary>
        /// Intenta hacer un login y devuelve un booleano según si ha sido exitoso o no.
        /// </summary>
        /// <param name="username">Nombre del usuario al que se hará login.</param>
        /// <param name="password">Contraseña introducida.</param>
        /// <returns>"true" si es exitoso, "false" si no.</returns>
        public static bool PerformLogin(string username, string password, string newPassword)
        {
            DataRow[] rowsFound;
            string hashedPasswd, salt, storedPasswd, new_salt, query;
            bool valid = false;

            DataSet dts = Data.PortarDataset("Users");
            rowsFound = dts.Tables[0].Select($"Login = '{username}'");

            if (rowsFound.Length > 0)
            {
                salt = rowsFound[0].Field<string>("Salt");
                storedPasswd = rowsFound[0].Field<string>("Password");

                if (password == "12345aA")
                {
                    new_salt = CreateSalt();
                    hashedPasswd = SaltPassword(newPassword, new_salt);
                    query = $"UPDATE Users SET Password = '{hashedPasswd}', Salt = '{new_salt}' WHERE Login = '{username}'";

                    Data.Executar(query);
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
                SetUserInformation(rowsFound[0]);
            }
            return valid;
        }

        private static string SaltPassword(string password, string salt)
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

        private static string CreateSalt()
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

        private static void SetUserInformation(DataRow userRow)
        {
            DataSet userCategoryDTS = Data.PortarDataset("UserCategories");
            DataSet userOptionDTS = Data.PortarDataset("UserOptions");
            int permissionLevel;

            ImageConverter converter = new ImageConverter();

            // Encontrar valores importantes
            DataRow userCategory = userCategoryDTS.Tables[0].Select($"idUserCategory = {userRow.Field<int>("idUserCategory")}")[0];
            permissionLevel = userCategory.Field<int>("AccessLevel");
            

            UserName = userRow.Field<string>("UserName");
            ProfilePicture = (Bitmap)converter.ConvertFrom(userRow.Field<byte[]>("Photo"));
            CategoryName = userCategory.Field<string>("DescUserCategory");
            AvailableOptions = new List<DataRow>(userOptionDTS.Tables[0].Select($"accesLvlReq <= {permissionLevel}"));
        }

    }
}
