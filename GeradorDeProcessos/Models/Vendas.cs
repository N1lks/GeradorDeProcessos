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
    
    public partial class Vendas
    {
        public int IDVenda { get; set; }
        public string Unidades { get; set; }
        public decimal ValorFinanciamento { get; set; }
        public decimal ValorTotal { get; set; }
        public int IDCliente { get; set; }
        public int IDUnidade { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Unidades Unidades1 { get; set; }
    }
}
