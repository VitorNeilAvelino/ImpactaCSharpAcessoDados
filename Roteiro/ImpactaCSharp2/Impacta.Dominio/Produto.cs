using System;
namespace Impacta.Dominio
{
    public class Produto
    {
        public Produto()
        {
            Tipo = new TipoProduto();
        }

        public int Id { get; set; }
        public TipoProduto Tipo { get; set; }
        public string Descricao { get; set; }
        public decimal Custo { get; set; }

        public Produto this[int id]
        { 
            get { return id == Id ? this : null; } 
        }
    }
}