using System;
using System.Collections.Generic;

namespace Impacta.Dominio
{
    public interface ICrudBase<T>
    {
        void Inserir(T entidade);
        T Selecionar(int entidadeId);
        void Atualizar(T entidade);
        void Excluir(int entidadeId);
        List<T> SelecionarPor(Func<T, bool> expressaoLambda);
    }
}