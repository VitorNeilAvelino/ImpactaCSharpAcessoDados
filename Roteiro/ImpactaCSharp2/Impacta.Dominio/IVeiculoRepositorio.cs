using System.Collections.Generic;

namespace Impacta.Dominio
{
    public interface IVeiculoRepositorio : ICrudBase<Veiculo>
    {
        //void Inserir(Veiculo veiculo);
        //Veiculo Selecionar(int veiculoId);
        //void Atualizar(Veiculo veiculo);
        //void Excluir(int veiculoId);
        Veiculo PesquisarPorPlaca(string placa);
    }
}