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
    
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            this.BOLETA = new HashSet<BOLETA>();
            this.ORDEN_PEDIDO = new HashSet<ORDEN_PEDIDO>();
        }
    
        public decimal RUNUSUARIO { get; set; }
        public string DV { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string CONTRASENA { get; set; }
        public System.DateTime FECHANACIMIENTO { get; set; }
        public System.DateTime FECHACREACION { get; set; }
        public string DIRECCION { get; set; }
        public decimal TELEFONO { get; set; }
        public string CORREO { get; set; }
        public decimal TIPO_USUARIO_IDTIPO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLETA> BOLETA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDEN_PEDIDO> ORDEN_PEDIDO { get; set; }
        public virtual TIPO_USUARIO TIPO_USUARIO { get; set; }
    }
}
