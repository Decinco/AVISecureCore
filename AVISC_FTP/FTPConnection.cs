using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml;

namespace AVISC_FTP
{
    public class FTPConnection
    {
        private string ftpServer, ftpUser, ftpPassword;

        public FTPConnection()
        {
            // Llamar al método para obtener las credenciales
            getConnectionData();
        }

        private void getConnectionData()
        {
            try
            {
                // Extraer campos del XML con XmlDocument
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("Resources/config.xml");
                ftpServer = xmlDoc.SelectSingleNode("/FTP/ip").InnerText;
                ftpUser = xmlDoc.SelectSingleNode("/FTP/credentials/username").InnerText;
                ftpPassword = xmlDoc.SelectSingleNode("/FTP/credentials/password").InnerText;

                Console.WriteLine("Conexión establecida");

                // Llamar al método de conexión FTP para solo verificar la conexión
                verificarConexionFTP(ftpServer, ftpUser, ftpPassword);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar credenciales: " + ex.Message);
            }
        }

        public bool verificarConexionFTP(string servidor, string usuario, string contraseña)
        {
            try
            {
                // Crear la URI de conexión FTP
                string uri = $"ftp://{servidor}/";

                // Crear la solicitud FTP
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential(usuario, contraseña);
                request.UsePassive = true;
                request.KeepAlive = false;

                // Obtener la respuesta del servidor para verificar la conexión
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    Console.WriteLine($"Conexión exitosa, estado: {response.StatusDescription}");
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en la conexión FTP: {ex.Message}");
                return false;
            }
        }

        // Método para listar los archivos en el servidor FTP
        public List<string> listarArchivosFTP(string directorioRemoto)
        {
            List<string> archivos = new List<string>();
            try
            {
                string uri = $"ftp://{ftpServer}/{directorioRemoto}";
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential(ftpUser, ftpPassword);
                request.UsePassive = true;
                request.KeepAlive = false;

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        archivos.Add(line);
                    }
                }

                return archivos;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar archivos en el servidor FTP: {ex.Message}");
                return new List<string>();
            }
        }

        // Método para descargar un archivo desde el servidor FTP
        public bool descargarArchivoFTP(string archivoRemoto, string archivoLocal)
        {
            try
            {
                string uri = $"ftp://{ftpServer}/{archivoRemoto}";
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(ftpUser, ftpPassword);
                request.UseBinary = true;
                request.UsePassive = true;
                request.KeepAlive = false;

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (FileStream fileStream = new FileStream(archivoLocal, FileMode.Create))
                {
                    responseStream.CopyTo(fileStream);
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al descargar el archivo: {ex.Message}");
                return false;
            }
        }
    }
}
