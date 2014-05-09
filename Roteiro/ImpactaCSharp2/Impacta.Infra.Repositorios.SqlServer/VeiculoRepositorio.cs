using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Impacta.Dominio;

namespace Impacta.Infra.Repositorios.SqlServer.Procedures
{
    public class VeiculoRepositorio : BaseRepositorio, IVeiculoRepositorio
    {
        public void Inserir(Veiculo entidade)
        {
            throw new NotImplementedException();
        }

        public Veiculo Selecionar(int entidadeId)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Veiculo entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int entidadeId)
        {
            Comando.CommandText = string.Format("Delete from Veiculo where Id = {0}", entidadeId);
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
        }

        //public List<Veiculo> PesquisarPor(Func<Veiculo, bool> expressaoLambda)
        //{
        //    var listaVeiculos = new List<Veiculo>();

        //    return listaVeiculos.Where(expressaoLambda).ToList();
        //}

        public List<Veiculo> PesquisarPorPlaca(string placa)
        {
            throw new NotImplementedException();
        }
    }
}