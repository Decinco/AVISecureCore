using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace AVIDataAccess
{
    public abstract class DataAccess
    {
        public string ConnString { get; set; }

        public SqlConnection Connection { get; set; }

        public bool New { get; set; }

        public DataAccess()
        {

            ConnectionStringSettings conf = ConfigurationManager.ConnectionStrings["SecureCore"];

            New = false;
            ConnString = conf.ConnectionString;

            EncryptConfigFile();
        }

        protected void Connectar()
        {
            Connection = new SqlConnection(ConnString);
        }

        public DataSet PortarTaula(string tableName)
        {
            Connectar();

            DataSet dts = new DataSet();

            SqlDataAdapter adapter;
            string query;


            // Llenar el DataSet
            query = $"select * from {tableName}";
            adapter = new SqlDataAdapter(query, Connection);

            using (Connection)
            {

                adapter.Fill(dts, tableName);

            }

            return dts;
        }

        public DataSet PortarPerConsulta(string query)
        {
            Connectar();

            DataSet dts = new DataSet();

            SqlDataAdapter adapter;


            // Llenar el DataSet
            adapter = new SqlDataAdapter(query, Connection);

            using (Connection)
            {

                adapter.Fill(dts);

            }

            return dts;
        }

        public DataSet PortarPerConsulta(string query, string dataTableName)
        {
            Connectar();

            DataSet dts = new DataSet();

            SqlDataAdapter adapter;


            // Llenar el DataSet
            adapter = new SqlDataAdapter(query, Connection);

            using (Connection)
            {

                adapter.Fill(dts);

            }

            dts.Tables[0].TableName = dataTableName;
            return dts;
        }

        public int Actualitzar(DataSet dts, string query, Dictionary<string, string> fields)
        {
            Connectar();

            SqlDataAdapter adapter;
            int modifiedFields = 0;

            adapter = new SqlDataAdapter(query, Connection);

            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);

            using (Connection)
            {

                if (New)
                {
                    DataRow row = dts.Tables[0].NewRow();

                    dts.Tables[0].Rows.Add(row);

                    foreach (KeyValuePair<string,string> field in fields)
                    {
                        row[field.Key] = field.Value;
                    }
                }

                if (dts.HasChanges())
                {
                    try
                    {
                        modifiedFields = adapter.Update(dts.Tables[0]);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error al actualizar la tabla. Asegúrate de que no haya conflictos entre tablas.");
                    }
                }

                return modifiedFields;

            }
        }

        public int Executar(string query)
        {
            Connectar();

            SqlCommand cmd = new SqlCommand(query, Connection);
            int modifiedFields = 0;

            Connection.Open();

            modifiedFields = cmd.ExecuteNonQuery();

            Connection.Close();

            return modifiedFields;
        }



        public void EncryptConfigFile()
        {
            Configuration conf = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            ConnectionStringsSection section = conf.GetSection("connectionStrings")

            as ConnectionStringsSection;

            if (!section.SectionInformation.IsProtected)

            {

                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");

            }

            conf.Save();
        }
    }
}
