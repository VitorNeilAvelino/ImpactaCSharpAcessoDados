using Impacta.Dominio;
using System;
using System.Collections.Generic;

namespace Impacta.Repositorios.SqlServer.Proc
{
    public class VendedorRepositorio : ICrudBase<Vendedor> //IVendedorRepositorio
    {

        public void Inserir(Vendedor vendedor)
        {
            throw new NotImplementedException();
        }

        public List<Vendedor> Selecionar()
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Vendedor vendedor)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int vendedorId)
        {
            throw new NotImplementedException();
        }


        public Vendedor Selecionar(int entidadeId)
        {
            throw new NotImplementedException();
        }

        public List<Vendedor> SelecionarPor(Func<Vendedor, bool> expressaoLambda)
        {
            throw new NotImplementedException();
        }
    }
}