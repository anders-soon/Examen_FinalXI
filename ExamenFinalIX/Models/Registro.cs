//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamenFinalIX.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registro
    {
        public int Id_registro { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public Nullable<int> telefono { get; set; }
        public Nullable<decimal> total { get; set; }
    
        public virtual Telefono Telefono1 { get; set; }
    }
}