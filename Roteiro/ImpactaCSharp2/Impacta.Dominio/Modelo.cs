namespace Impacta.Dominio
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
        public virtual Montadora Montadora { get; set; }
    }
}
