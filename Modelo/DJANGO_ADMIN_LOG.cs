
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
    
public partial class DJANGO_ADMIN_LOG
{

    public long ID { get; set; }

    public System.DateTime ACTION_TIME { get; set; }

    public string OBJECT_ID { get; set; }

    public string OBJECT_REPR { get; set; }

    public long ACTION_FLAG { get; set; }

    public string CHANGE_MESSAGE { get; set; }

    public Nullable<long> CONTENT_TYPE_ID { get; set; }

    public long USER_ID { get; set; }



    public virtual AUTH_USER AUTH_USER { get; set; }

    public virtual DJANGO_CONTENT_TYPE DJANGO_CONTENT_TYPE { get; set; }

}

}
