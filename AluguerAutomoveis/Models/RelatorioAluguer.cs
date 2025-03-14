using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa um relatório de aluguer no sistema de aluguer de automóveis.
    /// </summary>
    public class RelatorioAluguer
    {
        #region Atributos

        /// <summary>
        /// Identificador único do relatório de aluguer.
        /// </summary>
        int relatorioAluguerId;

        /// <summary>
        /// Custo final do aluguer.
        /// </summary>
        decimal? custoFinal;

        /// <summary>
        /// Identificador do condutor responsável pela devolução do veículo.
        /// </summary>
        int? condDevId;

        /// <summary>
        /// Valor da caução retida.
        /// </summary>
        decimal? caucaoRetida;

        /// <summary>
        /// Identificador da reserva associada ao aluguer.
        /// </summary>
        int? reservaId;

        /// <summary>
        /// Identificador das condições de devolução associadas ao aluguer.
        /// </summary>
        int? condicoesDevId;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único do relatório de aluguer.
        /// </summary>
        /// <value>O identificador único do relatório de aluguer.</value>
        public int RelatorioAluguerId
        {
            get { return relatorioAluguerId; }
            set { relatorioAluguerId = value; }
        }

        /// <summary>
        /// Obtém ou define o custo final do aluguer.
        /// </summary>
        /// <value>O custo final do aluguer.</value>
        public decimal? CustoFinal
        {
            get { return custoFinal; }
            set { custoFinal = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador do condutor responsável pela devolução do veículo.
        /// </summary>
        /// <value>O identificador do condutor responsável pela devolução.</value>
        public int? CondDevId
        {
            get { return condDevId; }
            set { condDevId = value; }
        }

        /// <summary>
        /// Obtém ou define o valor da caução retida.
        /// </summary>
        /// <value>O valor da caução retida.</value>
        public decimal? CaucaoRetida
        {
            get { return caucaoRetida; }
            set { caucaoRetida = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador da reserva associada ao aluguer.
        /// </summary>
        /// <value>O identificador da reserva associada ao aluguer.</value>
        public int? ReservaId
        {
            get { return reservaId; }
            set { reservaId = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador das condições de devolução associadas ao aluguer.
        /// </summary>
        /// <value>O identificador das condições de devolução.</value>
        public int? CondicoesDevId
        {
            get { return condicoesDevId; }
            set { condicoesDevId = value; }
        }

        #endregion

        #endregion
    }
}
