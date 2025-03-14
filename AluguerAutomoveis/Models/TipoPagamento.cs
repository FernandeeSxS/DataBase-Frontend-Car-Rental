using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa um tipo de pagamento no sistema de aluguer de automóveis.
    /// </summary>
    public class TipoPagamento
    {
        #region Atributos

        /// <summary>
        /// Identificador único do tipo de pagamento.
        /// </summary>
        int tipoPagamentoId;

        /// <summary>
        /// Descrição do tipo de pagamento.
        /// </summary>
        string descTP;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único do tipo de pagamento.
        /// </summary>
        /// <value>O identificador único do tipo de pagamento.</value>
        public int TipoPagamentoId
        {
            get { return tipoPagamentoId; }
            set { tipoPagamentoId = value; }
        }

        /// <summary>
        /// Obtém ou define a descrição do tipo de pagamento.
        /// </summary>
        /// <value>A descrição do tipo de pagamento.</value>
        public string DescTP
        {
            get { return descTP; }
            set { descTP = value; }
        }

        #endregion

        #endregion
    }
}

