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
    
    public partial class Telefono
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Telefono()
        {
            this.Registro = new HashSet<Registro>();
        }
    
        public int Id_Telefono { get; set; }
        public Nullable<int> gama { get; set; }
        public Nullable<int> color { get; set; }
        public Nullable<int> pais { get; set; }
    
        public virtual Color Color1 { get; set; }
        public virtual Gama Gama1 { get; set; }
        public virtual Pais Pais1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registro> Registro { get; set; }
    }
}
