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
    
    public partial class Montadora
    {
        public Montadora()
        {
            this.Modelo = new HashSet<Modelo>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
    
        public virtual ICollection<Modelo> Modelo { get; set; }
    }
}
