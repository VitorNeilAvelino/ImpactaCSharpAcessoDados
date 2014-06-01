namespace Impacta.Dominio
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
        public string Descricao { get; set; }
    
        public virtual ICollection<Modelo> Modelo { get; set; }
    }
}
