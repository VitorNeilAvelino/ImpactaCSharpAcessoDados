namespace Impacta.Dominio
{
    using System;
    using System.Collections.Generic;
    
    public class Veiculo : IEntidade
    {
        public Veiculo()
        {
            this.Servicos = new HashSet<Servico>();
            this.Clientes = new HashSet<Cliente>();
        }
    
        public int Id { get; set; }
        public string Placa { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
    
        public virtual Cor Cor { get; set; }
        public virtual Modelo Modelo { get; set; }
        public virtual ICollection<Servico> Servicos { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
