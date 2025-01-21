using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVISC_Maintenance
{
    /// <summary>
    /// Clase que se introduce en la propiedad "Tag" de un combobox, que define qué columnas debe tener en cuenta.
    /// </summary>
    public class ForeignKeyTag
    {
        /// <summary>
        /// Columna en la que está guardado el valor real.
        /// </summary>
        public string ValueColumnName { get; set; }

        /// <summary>
        /// Tabla primaria.
        /// </summary>
        public string ValueTableName { get; set; }

        /// <summary>
        /// Columna en la que está guardado el valor que se mostrará.
        /// </summary>
        public string DisplayColumnName { get; set; }

        /// <summary>
        /// Tabla referenciada.
        /// </summary>
        public string DisplayTableName { get; set; }

        /// <summary>
        /// Columna que contiene la ID del valor que se mostrará.
        /// </summary>
        public string OriginColumnName { get; set; }

        /// <summary>
        /// Devuelve una representación de la clase en formato String.
        /// </summary>
        /// <returns>Propiedad <see cref="OriginColumnName"/></returns>
        public override string ToString()
        {
            return OriginColumnName;
        }
    }
}
