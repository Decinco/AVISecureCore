using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace AVIDataAccess
{
    /// <summary>
    /// Clase base abstracta para el acceso a datos.
    /// Proporciona métodos comunes para interactuar con bases de datos.
    /// </summary>
    public class DataAccess
    {
        /// <summary>
        /// Cadena de conexión a la base de datos.
        /// </summary>
        public string ConnString { get; set; }

        /// <summary>
        /// Conexión SQL utilizada para interactuar con la base de datos.
        /// </summary>
        public SqlConnection Connection { get; set; }

        /// <summary>
        /// Indica si se está creando un nuevo registro.
        /// </summary>
        public bool New { get; set; }

        /// <summary>
        /// Constructor por defecto.
        /// Inicializa la cadena de conexión y protege el archivo de configuración.
        /// </summary>
        public DataAccess()
        {
            ConnectionStringSettings conf = ConfigurationManager.ConnectionStrings["SecureCore"];

            if (conf is null) return;

            New = false;
            ConnString = conf.ConnectionString;

            EncryptConfigFile();
        }

        /// <summary>
        /// Establece la conexión con la base de datos utilizando la cadena de conexión.
        /// </summary>
        protected void Connectar()
        {
            Connection = new SqlConnection(ConnString);
        }

        /// <summary>
        /// Obtiene todos los registros de una tabla específica.
        /// </summary>
        /// <param name="tableName">Nombre de la tabla a consultar.</param>
        /// <returns>Un DataSet con los datos de la tabla.</returns>
        public DataSet PortarDataset(string tableName)
        {
            Connectar();
            DataSet dts = new DataSet();
            string query = $"SELECT * FROM {tableName}";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);

            using (Connection)
            {
                adapter.Fill(dts);
            }

            return dts;
        }

        /// <summary>
        /// Obtiene todos los registros de una tabla y todas las tablas que tenga vinculadas a través de una clave foránea.
        /// </summary>
        /// <param name="mainTableName">La tabla a consultar.</param>
        /// <param name="infoFK">DataSet con las claves foráneas </param>
        /// <returns>Un DataSet con los datos de una tabla y todas las tablas vinculadas.</returns>
        public DataSet PortarDatasetIForanies(string mainTableName, DataSet infoFK)
        {
            Connectar();
            DataSet dts = new DataSet();
            List<string> fkTables = new List<string>();
            string query = $"SELECT * FROM {mainTableName};";

            foreach (DataRow foreignKey in infoFK.Tables[0].Rows)
            {
                fkTables.Add(foreignKey.Field<string>("PKTABLE_NAME"));
            }

            foreach (string table in fkTables)
            {
                query += $"SELECT * FROM {table};";
            }

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);

            using (Connection)
            {
                adapter.Fill(dts);
            }

            dts.Tables[0].TableName = mainTableName;
            for (int i = 1; i <= fkTables.Count; i++)
            {
                dts.Tables[i].TableName = fkTables[i-1];
            }

            return dts;
        }

        /// <summary>
        /// Obtiene la información sobre claves foráneas de la tabla indicada.
        /// </summary>
        /// <param name="tableName">Nombre de la tabla principal.</param>
        /// <returns>Un DataSet con los datos de la tabla</returns>
        public DataSet PortarInfoFK(string tableName)
        {
            Connectar();
            DataSet dts = new DataSet();
            string query = $"sp_fkeys @fktable_name = '{tableName}'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);

            using (Connection)
            {
                adapter.Fill(dts);
            }

            return dts;
        }

        /// <summary>
        /// Ejecuta una consulta SQL y devuelve los resultados.
        /// </summary>
        /// <param name="query">Consulta SQL a ejecutar.</param>
        /// <returns>Un DataSet con los resultados de la consulta.</returns>
        public DataSet PortarPerConsulta(string query)
        {
            Connectar();
            DataSet dts = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);

            using (Connection)
            {
                adapter.Fill(dts);
            }

            return dts;
        }

        /// <summary>
        /// Ejecuta una consulta SQL y asigna un nombre a la tabla resultante.
        /// </summary>
        /// <param name="query">Consulta SQL a ejecutar.</param>
        /// <param name="dataTableName">Nombre de la tabla resultante.</param>
        /// <returns>Un DataSet con los resultados de la consulta.</returns>
        public DataSet PortarPerConsulta(string query, string dataTableName)
        {
            Connectar();
            DataSet dts = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);

            using (Connection)
            {
                adapter.Fill(dts);
            }

            dts.Tables[0].TableName = dataTableName;
            return dts;
        }

        /// <summary>
        /// Actualiza los datos en la base de datos a partir de un DataSet.
        /// </summary>
        /// <param name="dts">DataSet con los datos a actualizar.</param>
        /// <param name="query">Consulta SQL utilizada para obtener la tabla.</param>
        /// <param name="fields">Diccionario con los campos y valores a actualizar.</param>
        /// <returns>Número de registros modificados.</returns>
        public int Actualitzar(DataSet dts, string query, Dictionary<string, object> fields)
        {
            Connectar();
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            int modifiedFields = 0;

            using (Connection)
            {
                if (New)
                {
                    DataRow row = dts.Tables[0].NewRow();
                    dts.Tables[0].Rows.Add(row);

                    foreach (KeyValuePair<string, object> field in fields)
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

        /// <summary>
        /// Ejecuta una consulta SQL no relacionada con resultados (como INSERT, UPDATE o DELETE).
        /// </summary>
        /// <param name="query">Consulta SQL a ejecutar.</param>
        /// <returns>Número de registros afectados.</returns>
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

        /// <summary>
        /// Protege la sección de cadenas de conexión del archivo de configuración.
        /// </summary>
        public void EncryptConfigFile()
        {
            Configuration conf = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            ConnectionStringsSection section = conf.GetSection("connectionStrings") as ConnectionStringsSection;

            if (!section.SectionInformation.IsProtected)
            {
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                conf.Save();
            }
        }
    }
}
