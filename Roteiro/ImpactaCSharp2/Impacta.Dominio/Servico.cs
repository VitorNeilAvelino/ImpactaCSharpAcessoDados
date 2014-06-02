using System;

namespace Impacta.Dominio
{
   public class Servico : IEntidade
    {
        public int Id { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public decimal? Valor { get; set; }
        public decimal? Custo { get; set; }
        public string Sigla { get; set; }
    
        public virtual TipoServico TipoServico { get; set; }
        public virtual Veiculo Veiculo { get; set; }
    }
}