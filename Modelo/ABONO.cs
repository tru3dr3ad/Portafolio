
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
    
public partial class ABONO
{

    public decimal IDABONO { get; set; }

    public decimal BOLETA_NUMEROBOLETA { get; set; }

    public decimal TOTAL { get; set; }

    public System.DateTime FECHAABONO { get; set; }

    public System.DateTime FECHALIMITE { get; set; }



    public virtual BOLETA BOLETA { get; set; }

}

}
