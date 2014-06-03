namespace Impacta.Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cor : IEntidade
    {
        public Cor()
        {
            this.Veiculo = new HashSet<Veiculo>();
        }
    
        public int Id { get; set; }
        public string Descricao { get; set; }
    
        public virtual ICollection<Veiculo> Veiculo { get; set; }
    }
}
