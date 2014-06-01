namespace Impacta.Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Veiculo
    {
        public Veiculo()
        {
            this.Servico = new HashSet<Servico>();
            this.Cliente = new HashSet<Cliente>();
        }
    
        public int Id { get; set; }
        public string Placa { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
    
        public virtual Cor Cor { get; set; }
        public virtual Modelo Modelo { get; set; }
        public virtual ICollection<Servico> Servico { get; set; }
        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
