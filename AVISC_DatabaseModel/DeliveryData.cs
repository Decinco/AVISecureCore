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
    
    public partial class DeliveryData
    {
        public int idDeliveryData { get; set; }
        public string CodeDelivery { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public int idPlanet { get; set; }
        public int idSpaceShip { get; set; }
    
        public virtual Planets Planets { get; set; }
        public virtual SpaceShips SpaceShips { get; set; }
    }
}
