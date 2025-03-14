using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa o status de uma prestação no sistema de aluguer de automóveis.
    /// </summary>
    public class StatusPrestacao
    {
        #region Atributos

        /// <summary>
        /// Identificador único do status da prestação.
        /// </summary>
        int statusPrestacaoId;

        /// <summary>
        /// Descrição do status da prestação.
        /// </summary>
        string descStatusPrest;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único do status da prestação.
        /// </summary>
        /// <value>O identificador único do status da prestação.</value>
        public int StatusPrestacaoId
        {
            get { return statusPrestacaoId; }
            set { statusPrestacaoId = value; }
        }

        /// <summary>
        /// Obtém ou define a descrição do status da prestação.
        /// </summary>
        /// <value>A descrição do status da prestação.</value>
        public string DescStatusPrest
        {
            get { return descStatusPrest; }
            set { descStatusPrest = value; }
        }

        #endregion

        #endregion
    }
}
