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
    
    public partial class CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTE()
        {
            this.BOLETA = new HashSet<BOLETA>();
            this.REGISTRO_FIADO = new HashSet<REGISTRO_FIADO>();
        }
    
        public decimal RUNCLIENTE { get; set; }
        public string DVCLIENTE { get; set; }
        public string NOMBRECLIENTE { get; set; }
        public string APELLIDOCLIENTE { get; set; }
        public System.DateTime FECHANACIMIENTO { get; set; }
        public string DIRECCIONCLIENTE { get; set; }
        public int TELEFONOCLIENTE { get; set; }
        public decimal ESTADO_FIADO_ESTADOID { get; set; }
        public decimal TIPO_CLIENTE_TIPOCLIENTEID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLETA> BOLETA { get; set; }
        public virtual ESTADO_FIADO ESTADO_FIADO { get; set; }
        public virtual TIPO_CLIENTE TIPO_CLIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTRO_FIADO> REGISTRO_FIADO { get; set; }
    }
}
