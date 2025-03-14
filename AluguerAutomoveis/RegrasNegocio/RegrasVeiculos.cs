using AluguerAutomoveis.Models;
using AluguerAutomoveis.Repositorios;
using System;

namespace AluguerAutomoveis.Negocio
{
    /// <summary>
    /// Contém as regras de negócios relacionadas aos veículos, incluindo adição, edição, exclusão e busca.
    /// </summary>
    public class RegrasVeiculos
    {
        #region Atributos

        #endregion

        #region Métodos

        /// <summary>
        /// Adiciona um novo veículo.
        /// </summary>
        /// <param name="veiculo">O veículo a ser adicionado.</param>
        /// <returns>Retorna <c>true</c> se o veículo foi adicionado com sucesso; caso contrário, retorna <c>false</c>.</returns>
        public bool AdicionarVeiculo(Veiculo veiculo)
        {
            if (veiculo == null)
                return false;

            if (veiculo.Capacidade <= 0)
                return false;

            if (veiculo.KM < 0)
                return false;

            if (string.IsNullOrEmpty(veiculo.NivComb))
                return false;

            if (veiculo.TipoVeiculoId <= 0 || veiculo.ModeloId <= 0)
                return false;

            VeiculoRepositorio repo = new VeiculoRepositorio();
            return repo.AdicionarVeiculo(veiculo);
        }

        /// <summary>
        /// Edita um veículo existente.
        /// </summary>
        /// <param name="veiculoId">O ID do veículo a ser editado.</param>
        /// <param name="atributo">O atributo a ser alterado.</param>
        /// <param name="novoValor">O novo valor do atributo.</param>
        /// <returns>Retorna <c>true</c> se o veículo foi editado com sucesso; caso contrário, retorna <c>false</c>.</returns>
        public bool EditarVeiculo(int veiculoId, string atributo, string novoValor)
        {
            if (veiculoId <= 0 || string.IsNullOrEmpty(atributo) || string.IsNullOrEmpty(novoValor))
                return false;

            VeiculoRepositorio repositorio = new VeiculoRepositorio();
            Veiculo veiculo = repositorio.BuscarVeiculoPorId(veiculoId);
            if (veiculo == null)
                return false;

            repositorio.AtualizarAtributo(veiculo, atributo, novoValor);
            repositorio.AtualizarVeiculo(veiculo);

            return true;
        }

        /// <summary>
        /// Exclui um veículo.
        /// </summary>
        /// <param name="veiculoId">O ID do veículo a ser excluído.</param>
        /// <returns>Retorna <c>true</c> se o veículo foi excluído com sucesso; caso contrário, retorna <c>false</c>.</returns>
        public bool ExcluirVeiculo(int veiculoId)
        {
            if (veiculoId <= 0)
                return false;

            VeiculoRepositorio repo = new VeiculoRepositorio();
            repo.EliminarVeiculo(veiculoId);
            return true;
        }

        /// <summary>
        /// Busca um veículo pelo seu ID.
        /// </summary>
        /// <param name="veiculoId">O ID do veículo a ser buscado.</param>
        /// <returns>Retorna o veículo encontrado, ou <c>null</c> caso não exista.</returns>
        public Veiculo BuscarVeiculoPorId(int veiculoId)
        {
            if (veiculoId <= 0)
                return null;

            VeiculoRepositorio repo = new VeiculoRepositorio();
            return repo.BuscarVeiculoPorId(veiculoId);
        }

        #endregion
    }
}



