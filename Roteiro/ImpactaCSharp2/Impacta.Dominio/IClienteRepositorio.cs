using System.Collections.Generic;
using System.Data;

namespace Impacta.Dominio
{
    public interface IClienteRepositorio
    {
        DataTable Selecionar(string nomeCliente);
        
        void Inserir(Cliente cliente);
        Cliente Selecionar(int clienteId);
        void Atualizar(Cliente cliente);
        void Excluir(int clienteId);
        List<Cliente> Selecionar();
    }
}