namespace Impacta.Dominio
{
    public interface IClienteRepositorio
    {
        void Inserir(Cliente cliente);
        Cliente Selecionar(int clienteId);
        void Atualizar(Cliente cliente);
        void Excluir(int clienteId);
    }
}