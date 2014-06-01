namespace Impacta.Dominio
{
    using System;
    using System.Collections.Generic;
    
    public class Servico
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> DataInicio { get; set; }
        public Nullable<System.DateTime> DataFim { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<decimal> Custo { get; set; }
        public string Sigla { get; set; }
    
        public virtual TipoServico TipoServico { get; set; }
        public virtual Veiculo Veiculo { get; set; }
    }
}
