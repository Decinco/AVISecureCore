using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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

namespace AVISC_CrystalReport
{
    public partial class CardIdUser : Form
    {
        private int idPersona;

        public CardIdUser(int idPersona)
        {
            InitializeComponent();
            this.idPersona = idPersona;
            MostrarInforme();
        }

        private void MostrarInforme()
        {
            try
            {
                // Ruta base dinámica para imágenes
                //string rutaBaseImagenes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imatges", "usuarios");

                // Ruta del informe
                string rutaInforme = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CardId.rpt");

                if (!File.Exists(rutaInforme))
                {
                    MessageBox.Show("El archivo del informe no existe en la ruta especificada.");
                    return;
                }

                // Crear el documento del informe
                ReportDocument informe = new ReportDocument();
                informe.Load("CardId.rpt");

                // Configurar las credenciales de conexión
                ConnectionInfo crConnectionInfo = new ConnectionInfo
                {
                    ServerName = "sqlserver.S2AM.sdslab.cat",
                    DatabaseName = "SecureCoreG5",
                    UserID = "G5",
                    Password = "12345G5aA2425."
                };

                // Aplicar las credenciales a todas las tablas del informe
                Tables crTables = informe.Database.Tables;
                foreach (Table crTable in crTables)
                {
                    TableLogOnInfo crTableLogOnInfo = crTable.LogOnInfo;
                    crTableLogOnInfo.ConnectionInfo = crConnectionInfo;
                    crTable.ApplyLogOnInfo(crTableLogOnInfo);
                }

                // Configurar el parámetro idUser
                ParameterFieldDefinitions crParameterFieldDefinitions = informe.DataDefinition.ParameterFields;


                ParameterFieldDefinition crParameterFieldDefinition = crParameterFieldDefinitions["UserId"];
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue
                {
                    Value = idPersona
                };

                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);


                // Asignar el informe al visor
                crystalReportViewer1.ReportSource = informe;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el informe: {ex.Message}");
            }
        }

    }
}
