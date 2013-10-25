namespace Impacta.Dominio
{
    public interface ICrudBase<T>
    {
        void Inserir(T entidade);
        T Selecionar(int entidadeId);
        void Atualizar(T entidade);
        void Excluir(int entidadeId);
        //List<T> PesquisarPor(Func<T, bool> expressaoLambda);
    }
}