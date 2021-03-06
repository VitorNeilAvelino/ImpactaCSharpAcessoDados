namespace Impacta.Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public Cliente()
        {
            this.Veiculo = new HashSet<Veiculo>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public System.DateTime DataNascimento { get; set; }
        public int Tipo { get; set; }
    
        public virtual ICollection<Veiculo> Veiculo { get; set; }
    }
}
