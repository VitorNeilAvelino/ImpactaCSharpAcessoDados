//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Impacta.Repositorios.Ef.Designer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Modelo
    {
        public Modelo()
        {
            this.Veiculo = new HashSet<Veiculo>();
        }
    
        public int Id { get; set; }
        public string Descricao { get; set; }
    
        public virtual ICollection<Veiculo> Veiculo { get; set; }
    }
}