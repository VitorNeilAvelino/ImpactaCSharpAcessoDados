using Impacta.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta.Repositorios.SqlServer.El
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        public System.Data.DataTable Selecionar(string nomeCliente)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente Selecionar(int clienteId)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int clienteId)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> Selecionar()
        {
            throw new NotImplementedException();
        }
    }
}
