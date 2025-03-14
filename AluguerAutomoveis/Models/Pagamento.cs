using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa um pagamento no sistema de aluguer de automóveis.
    /// </summary>
    public class Pagamento
    {
        #region Atributos

        /// <summary>
        /// Identificador único do pagamento.
        /// </summary>
        int pagamentoId;

        /// <summary>
        /// Valor total do pagamento.
        /// </summary>
        decimal? valorTotal;

        /// <summary>
        /// Data em que o pagamento foi efetuado.
        /// </summary>
        DateTime? dataPagamento;

        /// <summary>
        /// Número de prestações associadas ao pagamento.
        /// </summary>
        int? numPrest;

        /// <summary>
        /// Ajustes aplicados ao valor do pagamento.
        /// </summary>
        decimal? ajustes;

        /// <summary>
        /// Identificador do tipo de pagamento.
        /// </summary>
        int? tipoPagamentoId;

        /// <summary>
        /// Identificador do relatório de aluguer associado ao pagamento.
        /// </summary>
        int? relatorioAluguerId;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único do pagamento.
        /// </summary>
        /// <value>O identificador único do pagamento.</value>
        public int PagamentoId
        {
            get { return pagamentoId; }
            set { pagamentoId = value; }
        }

        /// <summary>
        /// Obtém ou define o valor total do pagamento.
        /// </summary>
        /// <value>O valor total do pagamento.</value>
        public decimal? ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        /// <summary>
        /// Obtém ou define a data em que o pagamento foi efetuado.
        /// </summary>
        /// <value>A data do pagamento.</value>
        public DateTime? DataPagamento
        {
            get { return dataPagamento; }
            set { dataPagamento = value; }
        }

        /// <summary>
        /// Obtém ou define o número de prestações associadas ao pagamento.
        /// </summary>
        /// <value>O número de prestações.</value>
        public int? NumPrest
        {
            get { return numPrest; }
            set { numPrest = value; }
        }

        /// <summary>
        /// Obtém ou define os ajustes aplicados ao valor do pagamento.
        /// </summary>
        /// <value>Os ajustes ao valor do pagamento.</value>
        public decimal? Ajustes
        {
            get { return ajustes; }
            set { ajustes = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador do tipo de pagamento.
        /// </summary>
        /// <value>O identificador do tipo de pagamento.</value>
        public int? TipoPagamentoId
        {
            get { return tipoPagamentoId; }
            set { tipoPagamentoId = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador do relatório de aluguer associado ao pagamento.
        /// </summary>
        /// <value>O identificador do relatório de aluguer.</value>
        public int? RelatorioAluguerId
        {
            get { return relatorioAluguerId; }
            set { relatorioAluguerId = value; }
        }

        #endregion

        #endregion
    }
}