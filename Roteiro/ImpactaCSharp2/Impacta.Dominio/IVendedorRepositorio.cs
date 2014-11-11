using System.Collections.Generic;

namespace Impacta.Dominio
{
    public interface IVendedorRepositorio
    {
        void Inserir(Vendedor vendedor);
        List<Vendedor> Selecionar();
        void Atualizar(Vendedor vendedor);
        void Excluir(int vendedorId);
    }
}