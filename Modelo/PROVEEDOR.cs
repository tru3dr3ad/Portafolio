//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROVEEDOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROVEEDOR()
        {
            this.ORDEN_PEDIDO = new HashSet<ORDEN_PEDIDO>();
        }
    
        public decimal RUTPROVEEDOR { get; set; }
        public string DVPROVEEDOR { get; set; }
        public decimal IDPROVEEDOR { get; set; }
        public string NOMBREPROVEEDOR { get; set; }
        public string CORREOPROVEEDOR { get; set; }
        public int TELEFONOPROVEEDOR { get; set; }
        public string DIRECCIONPROVEEDOR { get; set; }
        public decimal TIPO_RUBRO_RUBROID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDEN_PEDIDO> ORDEN_PEDIDO { get; set; }
        public virtual TIPO_RUBRO TIPO_RUBRO { get; set; }
    }
}
