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
    
    public partial class BOLETA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOLETA()
        {
            this.ABONO = new HashSet<ABONO>();
            this.DETALLE_BOLETA = new HashSet<DETALLE_BOLETA>();
        }
    
        public decimal NUMEROBOLETA { get; set; }
        public System.DateTime FECHACREACION { get; set; }
        public decimal TOTAL { get; set; }
        public decimal MEDIO_PAGO_IDMEDIO { get; set; }
        public decimal CLIENTE_RUNCLIENTE { get; set; }
        public decimal USUARIO_RUNUSUARIO { get; set; }
        public decimal ESTADO_BOLETA_IDESTADO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ABONO> ABONO { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual ESTADO_BOLETA ESTADO_BOLETA { get; set; }
        public virtual MEDIO_PAGO MEDIO_PAGO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_BOLETA> DETALLE_BOLETA { get; set; }
    }
}
