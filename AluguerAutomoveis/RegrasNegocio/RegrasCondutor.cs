using System;
using System.Linq;
using System.Windows.Forms;
using AluguerAutomoveis.Models;
using AluguerAutomoveis.Repositorios;

namespace AluguerAutomoveis.Negocio
{
    /// <summary>
    /// Contém as regras de negócios relacionadas aos condutores, incluindo adição, edição, exclusão e busca.
    /// </summary>
    public class RegrasCondutores
    {
        #region Atributos

        #endregion

        #region Métodos

        /// <summary>
        /// Adiciona um novo condutor.
        /// </summary>
        /// <param name="condutor">O condutor a ser adicionado.</param>
        /// <returns>Retorna <c>true</c> se o condutor foi adicionado com sucesso; caso contrário, retorna <c>false</c>.</returns>
        public bool AdicionarCondutor(Condutor condutor)
        {
            if (string.IsNullOrEmpty(condutor.NomeCondutor) || string.IsNullOrEmpty(condutor.DocIdentificacao) || string.IsNullOrEmpty(condutor.TituloCondutor))
                return false;

            if (condutor.DataNasc > DateTime.Now)
                return false;

            CondutorRepositorio repo = new CondutorRepositorio();
            return repo.InserirCondutor(condutor);
        }

        /// <summary>
        /// Edita um condutor existente.
        /// </summary>
        /// <param name="condutorId">O ID do condutor a ser editado.</param>
        /// <param name="atributo">O atributo a ser alterado.</param>
        /// <param name="novoValor">O novo valor do atributo.</param>
        /// <returns>Retorna <c>true</c> se o condutor foi editado com sucesso; caso contrário, retorna <c>false</c>.</returns>
        public bool EditarCondutor(int condutorId, string atributo, string novoValor)
        {
            if (condutorId <= 0 || string.IsNullOrEmpty(atributo) || string.IsNullOrEmpty(novoValor))
                return false;

            CondutorRepositorio repositorio = new CondutorRepositorio();
            Condutor condutor = BuscarCondutorPorId(condutorId);
            if (condutor == null)
                return false;

            repositorio.AtualizarAtributo(condutor, atributo, novoValor);
            repositorio.AtualizarCondutor(condutor);

            return true;
        }

        /// <summary>
        /// Exclui um condutor.
        /// </summary>
        /// <param name="condutorId">O ID do condutor a ser excluído.</param>
        /// <returns>Retorna <c>true</c> se o condutor foi excluído com sucesso; caso contrário, retorna <c>false</c>.</returns>
        public bool ExcluirCondutor(int condutorId)
        {
            if (condutorId <= 0)
                return false;

            CondutorRepositorio repo = new CondutorRepositorio();
            repo.EliminarCondutor(condutorId);
            return true;
        }

        /// <summary>
        /// Busca um condutor pelo seu ID.
        /// </summary>
        /// <param name="condutorId">O ID do condutor a ser buscado.</param>
        /// <returns>Retorna o condutor encontrado, ou <c>null</c> caso não exista.</returns>
        public Condutor BuscarCondutorPorId(int condutorId)
        {
            if (condutorId <= 0)
                return null;

            CondutorRepositorio repo = new CondutorRepositorio();
            return repo.BuscarCondutorPorId(condutorId);
        }

        /// <summary>
        /// Busca o ID do condutor a partir do número de documento de identificação.
        /// </summary>
        /// <param name="docIdentificacao">O número do documento de identificação do condutor.</param>
        /// <returns>Retorna o ID do condutor, ou 0 caso não encontrado.</returns>
        public int BuscarCondutorIdPorDocIdentificacao(string docIdentificacao)
        {
            CondutorRepositorio repositorio = new CondutorRepositorio();
            return repositorio.BuscarCondutorIdPorDocIdentificacao(docIdentificacao);
        }

        #endregion
    }
}
