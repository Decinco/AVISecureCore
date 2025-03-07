using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AVISC_FTP
{
    public partial class FTP_Configuration_From : Form
    {
        public FTP_Configuration_From()
        {
            InitializeComponent();
            TopMost = true;
        }

        static void ModificarContenidoXML(string rutaArchivo, string etiqueta, string nuevoValor)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(rutaArchivo);

            XmlNodeList nodos = xmlDoc.GetElementsByTagName(etiqueta);
            foreach (XmlNode nodo in nodos)
            {
                nodo.InnerText = nuevoValor;
            }

            xmlDoc.Save(rutaArchivo);
            Console.WriteLine("Contenido modificado correctamente.");
        }

        private void btnSaveConf_ButtonClick(object sender, EventArgs e)
        {
            string xmlPath = Path.Combine(Application.StartupPath, "Resources", "config.xml");

            if (tbIP.Text != "" || tbPassword.Text != "" || tbPassword.Text != "")
            {
                ModificarContenidoXML(xmlPath, "ip", tbIP.Text);
                ModificarContenidoXML(xmlPath, "username", tbUserName.Text);
                ModificarContenidoXML(xmlPath, "password", tbPassword.Text);
            }

            Hide();
        }

        private void btnExit_ButtonClick(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
