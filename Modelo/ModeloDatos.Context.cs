﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AlmacenEntities : DbContext
    {
        public AlmacenEntities()
            : base("name=AlmacenEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ABONO> ABONO { get; set; }
        public virtual DbSet<BOLETA> BOLETA { get; set; }
        public virtual DbSet<CATEGORIA> CATEGORIA { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<DETALLE_BOLETA> DETALLE_BOLETA { get; set; }
        public virtual DbSet<DETALLE_PEDIDO> DETALLE_PEDIDO { get; set; }
        public virtual DbSet<ESTADO_BOLETA> ESTADO_BOLETA { get; set; }
        public virtual DbSet<ESTADO_FIADO> ESTADO_FIADO { get; set; }
        public virtual DbSet<ESTADO_ORDEN> ESTADO_ORDEN { get; set; }
        public virtual DbSet<MEDIO_PAGO> MEDIO_PAGO { get; set; }
        public virtual DbSet<ORDEN_PEDIDO> ORDEN_PEDIDO { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTO { get; set; }
        public virtual DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public virtual DbSet<TIPO_CLIENTE> TIPO_CLIENTE { get; set; }
        public virtual DbSet<TIPO_RUBRO> TIPO_RUBRO { get; set; }
        public virtual DbSet<TIPO_USUARIO> TIPO_USUARIO { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
        public virtual DbSet<V_ABONO> V_ABONO { get; set; }
        public virtual DbSet<V_BOLETAS> V_BOLETAS { get; set; }
        public virtual DbSet<V_CLIENTES> V_CLIENTES { get; set; }
        public virtual DbSet<V_CLIENTES_EFECTIVO> V_CLIENTES_EFECTIVO { get; set; }
        public virtual DbSet<V_DETALLE_BOLETA> V_DETALLE_BOLETA { get; set; }
        public virtual DbSet<V_DETALLE_ORDEN> V_DETALLE_ORDEN { get; set; }
        public virtual DbSet<V_ORDEN_PEDIDO> V_ORDEN_PEDIDO { get; set; }
        public virtual DbSet<V_PRODUCTOS> V_PRODUCTOS { get; set; }
        public virtual DbSet<V_PROVEEDORES> V_PROVEEDORES { get; set; }
        public virtual DbSet<V_TOP_PRODUCTOS> V_TOP_PRODUCTOS { get; set; }
        public virtual DbSet<V_USUARIOS> V_USUARIOS { get; set; }
    
        public virtual int SP_ACTUALIZARPRECIO2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ACTUALIZARPRECIO2");
        }
    
        public virtual int SP_MONEDA_CAMBIO(string nOMBRE_MONEDA, Nullable<decimal> vALOR)
        {
            var nOMBRE_MONEDAParameter = nOMBRE_MONEDA != null ?
                new ObjectParameter("NOMBRE_MONEDA", nOMBRE_MONEDA) :
                new ObjectParameter("NOMBRE_MONEDA", typeof(string));
    
            var vALORParameter = vALOR.HasValue ?
                new ObjectParameter("VALOR", vALOR) :
                new ObjectParameter("VALOR", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_MONEDA_CAMBIO", nOMBRE_MONEDAParameter, vALORParameter);
        }
    }
}
