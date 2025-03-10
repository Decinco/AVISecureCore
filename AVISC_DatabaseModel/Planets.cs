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
    
    public partial class Planets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Planets()
        {
            this.DeliveryData = new HashSet<DeliveryData>();
            this.InnerEncryption = new HashSet<InnerEncryption>();
            this.MilitaryCamps = new HashSet<MilitaryCamps>();
            this.OrdersDetail = new HashSet<OrdersDetail>();
            this.PlanetKeys = new HashSet<PlanetKeys>();
            this.PlanetRoutes = new HashSet<PlanetRoutes>();
            this.Users = new HashSet<Users>();
        }
    
        public int idPlanet { get; set; }
        public string CodePlanet { get; set; }
        public string DescPlanet { get; set; }
        public Nullable<int> idSector { get; set; }
        public string @long { get; set; }
        public string lat { get; set; }
        public string parsecs { get; set; }
        public Nullable<int> idNatives { get; set; }
        public Nullable<int> idFiliation { get; set; }
        public string PlanetPicture { get; set; }
        public string IPPlanet { get; set; }
        public string PortPlanet { get; set; }
        public string PortPlanet1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryData> DeliveryData { get; set; }
        public virtual Filiations Filiations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InnerEncryption> InnerEncryption { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MilitaryCamps> MilitaryCamps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersDetail> OrdersDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanetKeys> PlanetKeys { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanetRoutes> PlanetRoutes { get; set; }
        public virtual Sectors Sectors { get; set; }
        public virtual Species Species { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Users> Users { get; set; }
    }
}
