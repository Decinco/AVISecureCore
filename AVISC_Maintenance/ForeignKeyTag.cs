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
    internal class ForeignKeyTag
    {
        /// <summary>
        /// Columna en la que está guardado el valor real.
        /// </summary>
        internal string ValueColumnName { get; set; }

        /// <summary>
        /// Tabla primaria.
        /// </summary>
        internal string ValueTableName { get; set; }

        /// <summary>
        /// Columna en la que está guardado el valor que se mostrará.
        /// </summary>
        internal string DisplayColumnName { get; set; }

        /// <summary>
        /// Tabla referenciada.
        /// </summary>
        internal string DisplayTableName { get; set; }

        /// <summary>
        /// Columna que contiene la ID del valor que se mostrará.
        /// </summary>
        public string OriginColumnName { get; set; }

        public override string ToString()
        {
            return OriginColumnName;
        }
    }
}
