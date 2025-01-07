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
using System.Windows.Forms;

namespace AVISC_Global {  

    public enum LoginStatus
    {
        Success,
        Failure,
        PasswordChange
    }

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
        public static LoginStatus PerformLogin(string username, string password)
        {
            DataRow[] rowsFound;
            string hashedPasswd, salt, storedPasswd;
            LoginStatus status = LoginStatus.Failure;

            DataSet dts = Data.PortarDataset("Users");
            rowsFound = dts.Tables[0].Select($"Login = '{username}'");

            if (rowsFound.Length > 0)
            {
                salt = rowsFound[0].Field<string>("Salt");
                storedPasswd = rowsFound[0].Field<string>("Password");

                if (password == "12345aA")
                {
                    status = LoginStatus.PasswordChange;
                }
                else
                {
                    hashedPasswd = SaltPassword(password, salt);
                    if (hashedPasswd == storedPasswd)
                    {
                        status = LoginStatus.Success;
                    }
                    else
                    {
                        status = LoginStatus.Failure;
                    }
                }
            }

            if (status == LoginStatus.Success)
            {
                SetUserInformation(rowsFound[0]);
            }

            return status;
        }

        public static bool ChangeNewPassword(string newPass, string comfirmPass, string user)
        {
            DataRow[] rowsFound;
            bool changePass;
            string newSalt, query, pass;

            DataSet dts = Data.PortarDataset("Users");
            rowsFound = dts.Tables[0].Select($"Login = '{user}'");

            if (newPass == comfirmPass)
            {
                newSalt = CreateSalt();
                pass = SaltPassword(comfirmPass, newSalt);
                query = $"UPDATE Users SET Password = '{pass}', Salt = '{newSalt}' WHERE Login = '{user}'";

                Data.Executar(query);
                changePass = true;
            }
            else
            {
                changePass = false;
            }
            if (changePass)
            {
                SetUserInformation(rowsFound[0]);
            }

            return changePass;
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
            DataSet menuOptionDTS = Data.PortarDataset("MenuOptions");
            int permissionLevel;
            byte[] profilePictureString;

            ImageConverter converter = new ImageConverter();

            // Encontrar valores importantes
            DataRow userCategory = userCategoryDTS.Tables[0].Select($"idUserCategory = {userRow.Field<int>("idUserCategory")}")[0];
            permissionLevel = userCategory.Field<int>("AccessLevel");
            

            profilePictureString = userRow.Field<byte[]>("Photo");

            UserName = userRow.Field<string>("UserName");
            CategoryName = userCategory.Field<string>("DescUserCategory");
            AvailableOptions = new List<DataRow>(menuOptionDTS.Tables[0].Select($"accesLvlReq <= {permissionLevel}"));

            if (profilePictureString != null)
            {
                ProfilePicture = (Bitmap)converter.ConvertFrom(profilePictureString);
            }
            else
            {
                ProfilePicture = Bitmap.FromFile(@"Resources\avatar-de-hombre.png");
            }
        }
    }
}
