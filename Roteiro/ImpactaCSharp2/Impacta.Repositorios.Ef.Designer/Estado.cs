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
    
    public partial class Estado
    {
        public Estado()
        {
            this.Cidades = new HashSet<Cidade>();
        }
    
        public int Id { get; set; }
        public string Uf { get; set; }
    
        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}
