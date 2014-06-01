namespace Impacta.Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoServico
    {
        public TipoServico()
        {
            this.Servico = new HashSet<Servico>();
        }
    
        public int Id { get; set; }
        public string Descricao { get; set; }
    
        public virtual ICollection<Servico> Servico { get; set; }
    }
}
