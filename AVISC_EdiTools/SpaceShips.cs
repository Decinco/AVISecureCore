//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AVISC_EdiTools
{
    using System;
    using System.Collections.Generic;
    
    public partial class SpaceShips
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SpaceShips()
        {
            this.DeliveryData = new HashSet<DeliveryData>();
        }
    
        public int idSpaceShip { get; set; }
        public Nullable<int> idSpaceShipType { get; set; }
        public string CodeSpaceShip { get; set; }
        public string IPSpaceShip { get; set; }
        public string PortSpaceShip { get; set; }
        public string PortSpaceShip1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryData> DeliveryData { get; set; }
        public virtual SpaceShipTypes SpaceShipTypes { get; set; }
    }
}
