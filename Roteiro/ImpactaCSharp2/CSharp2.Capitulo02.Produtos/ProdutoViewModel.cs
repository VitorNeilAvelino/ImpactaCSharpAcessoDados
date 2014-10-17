using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CSharp2.Capitulo02.Produtos
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel(DataRow registro)
        {
            Descricao = registro["Descricao"].ToString();
            Tipo = ((TipoProduto)registro["Tipo"]).ToString();
            Custo = Convert.ToDecimal(registro["Custo"]);
        }

        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public decimal Custo { get; set; }
    }
}