using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa uma prestação de pagamento no sistema de aluguer de automóveis.
    /// </summary>
    public class Prestacao
    {
        #region Atributos

        /// <summary>
        /// Identificador único da prestação.
        /// </summary>
        int prestacaoId;

        /// <summary>
        /// Valor da prestação.
        /// </summary>
        decimal? valorPrest;

        /// <summary>
        /// Data em que a prestação foi realizada.
        /// </summary>
        DateTime? dataPrest;

        /// <summary>
        /// Status da prestação.
        /// </summary>
        int? statusPrest;

        /// <summary>
        /// Identificador do status da prestação.
        /// </summary>
        int? statusPrestacaoId;

        /// <summary>
        /// Identificador do pagamento associado à prestação.
        /// </summary>
        int? pagamentoId;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único da prestação.
        /// </summary>
        /// <value>O identificador único da prestação.</value>
        public int PrestacaoId
        {
            get { return prestacaoId; }
            set { prestacaoId = value; }
        }

        /// <summary>
        /// Obtém ou define o valor da prestação.
        /// </summary>
        /// <value>O valor da prestação.</value>
        public decimal? ValorPrest
        {
            get { return valorPrest; }
            set { valorPrest = value; }
        }

        /// <summary>
        /// Obtém ou define a data em que a prestação foi realizada.
        /// </summary>
        /// <value>A data da prestação.</value>
        public DateTime? DataPrest
        {
            get { return dataPrest; }
            set { dataPrest = value; }
        }

        /// <summary>
        /// Obtém ou define o status da prestação.
        /// </summary>
        /// <value>O status da prestação.</value>
        public int? StatusPrest
        {
            get { return statusPrest; }
            set { statusPrest = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador do status da prestação.
        /// </summary>
        /// <value>O identificador do status.</value>
        public int? StatusPrestacaoId
        {
            get { return statusPrestacaoId; }
            set { statusPrestacaoId = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador do pagamento associado à prestação.
        /// </summary>
        /// <value>O identificador do pagamento.</value>
        public int? PagamentoId
        {
            get { return pagamentoId; }
            set { pagamentoId = value; }
        }

        #endregion

        #endregion
    }
}
