//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeradorDeProcessos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Unidades
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Unidades()
        {
            this.Vendas = new HashSet<Vendas>();
        }
    
        public int IDUnidade { get; set; }
        public string Numero { get; set; }
        public int IDEmpreendimento { get; set; }
    
        public virtual Empreendimentos Empreendimentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vendas> Vendas { get; set; }
    }
}
