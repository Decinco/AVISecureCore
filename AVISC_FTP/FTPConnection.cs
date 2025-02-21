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
            getConnectionData();
        }

        private void getConnectionData()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("Resources/config.xml");
                ftpServer = xmlDoc.SelectSingleNode("/FTP/ip").InnerText;
                ftpUser = xmlDoc.SelectSingleNode("/FTP/credentials/username").InnerText;
                ftpPassword = xmlDoc.SelectSingleNode("/FTP/credentials/password").InnerText;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar credenciales: " + ex.Message);
            }
        }

        public List<string> listarDirectoriosYArchivosFTP(string directorioRemoto)
        {
            List<string> elementos = new List<string>();
            try
            {
                string uri = $"ftp://{ftpServer}/{directorioRemoto}";
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
                request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                request.Credentials = new NetworkCredential(ftpUser, ftpPassword);
                request.UsePassive = true;
                request.KeepAlive = false;

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        if (parts.Length > 0)
                        {
                            string name = parts[parts.Length - 1];

                            // Detectar directorios (por permisos o sufijo '/')
                            if (line.StartsWith("d") || name.EndsWith("/"))
                            {
                                elementos.Add(name + "/");
                            }
                            else
                            {
                                elementos.Add(name);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar directorios y archivos: " + ex.Message);
            }
            return elementos;
        }


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
                Console.WriteLine("Error al descargar el archivo: " + ex.Message);
                return false;
            }
        }
    }
}

