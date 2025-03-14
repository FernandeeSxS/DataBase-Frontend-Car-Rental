using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa um sinistro no sistema de aluguer de automóveis.
    /// </summary>
    public class Sinistro
    {
        #region Atributos

        /// <summary>
        /// Identificador único do sinistro.
        /// </summary>
        int id;

        /// <summary>
        /// Descrição do sinistro ocorrido.
        /// </summary>
        string descSinistro;

        /// <summary>
        /// Data em que o sinistro ocorreu.
        /// </summary>
        DateTime? dataSinistro;

        /// <summary>
        /// Valor associado ao sinistro.
        /// </summary>
        decimal? valorSinistro;

        /// <summary>
        /// Valor da caução utilizada no sinistro.
        /// </summary>
        decimal? cauçãoUtilizada;

        /// <summary>
        /// Identificador do relatório de aluguer associado ao sinistro.
        /// </summary>
        int? relatorioAluguerId;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único do sinistro.
        /// </summary>
        /// <value>O identificador único do sinistro.</value>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Obtém ou define a descrição do sinistro ocorrido.
        /// </summary>
        /// <value>A descrição do sinistro.</value>
        public string DescSinistro
        {
            get { return descSinistro; }
            set { descSinistro = value; }
        }

        /// <summary>
        /// Obtém ou define a data em que o sinistro ocorreu.
        /// </summary>
        /// <value>A data do sinistro.</value>
        public DateTime? DataSinistro
        {
            get { return dataSinistro; }
            set { dataSinistro = value; }
        }

        /// <summary>
        /// Obtém ou define o valor associado ao sinistro.
        /// </summary>
        /// <value>O valor do sinistro.</value>
        public decimal? ValorSinistro
        {
            get { return valorSinistro; }
            set { valorSinistro = value; }
        }

        /// <summary>
        /// Obtém ou define o valor da caução utilizada no sinistro.
        /// </summary>
        /// <value>O valor da caução utilizada.</value>
        public decimal? CauçãoUtilizada
        {
            get { return cauçãoUtilizada; }
            set { cauçãoUtilizada = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador do relatório de aluguer associado ao sinistro.
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
