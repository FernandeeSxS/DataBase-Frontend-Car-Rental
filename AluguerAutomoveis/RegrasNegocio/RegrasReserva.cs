using AluguerAutomoveis.Models;
using AluguerAutomoveis.Repositorios;
using System;

namespace AluguerAutomoveis.Negocio
{
    /// <summary>
    /// Contém as regras de negócios relacionadas às reservas, incluindo adição, edição, exclusão e busca.
    /// </summary>
    public class RegrasReserva
    {
        #region Métodos

        /// <summary>
        /// Adiciona uma nova reserva.
        /// </summary>
        /// <param name="reserva">A reserva a ser adicionada.</param>
        /// <returns>Retorna <c>true</c> se a reserva foi adicionada com sucesso; caso contrário, retorna <c>false</c>.</returns>
        public bool AdicionarReserva(Reserva reserva)
        {
            if (reserva == null)
                return false;

            if (reserva.DataIniAluguer >= reserva.DataFimAluguer)
                return false; 

            if (reserva.PrecoDiario <= 0)
                return false;

            if (reserva.KmPerm < 0)
                return false;

            if (reserva.Caucao <= 0)
                return false;

            if (reserva.CondutorId <= 0 || reserva.OrganizacaoId <= 0 || reserva.TipoExtraId <= 0 || reserva.VeiculoId <= 0)
                return false;

            ReservaRepositorio repo = new ReservaRepositorio();
            return repo.AdicionarReserva(reserva);
        }

        /// <summary>
        /// Edita uma reserva existente.
        /// </summary>
        /// <param name="reservaId">O ID da reserva a ser editada.</param>
        /// <param name="atributo">O atributo a ser alterado.</param>
        /// <param name="novoValor">O novo valor do atributo.</param>
        /// <returns>Retorna <c>true</c> se a reserva foi editada com sucesso; caso contrário, retorna <c>false</c>.</returns>
        public bool EditarReserva(int reservaId, string atributo, string novoValor)
        {
            if (reservaId <= 0 || string.IsNullOrEmpty(atributo) || string.IsNullOrEmpty(novoValor))
                return false;

            ReservaRepositorio repositorio = new ReservaRepositorio();
            Reserva reserva = repositorio.BuscarReservaPorId(reservaId);
            if (reserva == null)
                return false;

            repositorio.AtualizarAtributo(reserva, atributo, novoValor);
            repositorio.AtualizarReserva(reserva);

            return true;
        }

        /// <summary>
        /// Exclui uma reserva.
        /// </summary>
        /// <param name="reservaId">O ID da reserva a ser excluída.</param>
        /// <returns>Retorna <c>true</c> se a reserva foi excluída com sucesso; caso contrário, retorna <c>false</c>.</returns>
        public bool ExcluirReserva(int reservaId)
        {
            if (reservaId <= 0)
                return false; 

            ReservaRepositorio repo = new ReservaRepositorio();
            repo.EliminarReserva(reservaId);
            return true;
        }

        /// <summary>
        /// Busca uma reserva pelo seu ID.
        /// </summary>
        /// <param name="reservaId">O ID da reserva a ser buscada.</param>
        /// <returns>Retorna a reserva encontrada, ou <c>null</c> caso não exista.</returns>
        public Reserva BuscarReservaPorId(int reservaId)
        {
            if (reservaId <= 0)
                return null;

            ReservaRepositorio repo = new ReservaRepositorio();
            return repo.BuscarReservaPorId(reservaId);
        }

        #endregion
    }
}


