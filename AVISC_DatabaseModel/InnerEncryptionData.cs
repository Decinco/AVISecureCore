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
    
    public partial class InnerEncryptionData
    {
        public int idInnerEncryptionData { get; set; }
        public Nullable<int> IdInnerEncryption { get; set; }
        public string Word { get; set; }
        public string Numbers { get; set; }
    
        public virtual InnerEncryption InnerEncryption { get; set; }
    }
}
