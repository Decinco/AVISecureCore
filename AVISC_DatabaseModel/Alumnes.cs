//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AVISC_DatabaseModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alumnes
    {
        public int idAlumne { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Nom { get; set; }
        public string Bandol { get; set; }
        public string IP { get; set; }
        public Nullable<int> Edat { get; set; }
    }
}
