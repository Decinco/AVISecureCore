using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVIDataAccess
{

    /// <summary>
    /// Clase que lo único que hace es convertir una lista a un BindingList del mismo tipo
    /// </summary>
    public static class DataUtils
    {
        /// <summary>
        /// Aparentemente, por alguna razón, esto no viene incluido en las librerías de .NET.
        /// </summary>
        /// <typeparam name="T">Tipo de la lista y, por lo tanto, tipo de la <see cref="BindingList{T}"/> creada</typeparam>
        /// <param name="source">Lista a Convertir</param>
        /// <returns>Bindinglist de tipo T.</returns>
        public static BindingList<T> ToBindingList<T>(this List<T> source)
        {
            return new BindingList<T>(source);
        }
    }
}
