using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa um tipo de habilitação no sistema de aluguer de automóveis.
    /// </summary>
    public class TipoHabilitacao
    {
        #region Atributos

        /// <summary>
        /// Identificador único do tipo de habilitação.
        /// </summary>
        int tipoHabilitacaoId;

        /// <summary>
        /// Descrição do tipo de habilitação.
        /// </summary>
        string descTH;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único do tipo de habilitação.
        /// </summary>
        /// <value>O identificador único do tipo de habilitação.</value>
        public int TipoHabilitacaoId
        {
            get { return tipoHabilitacaoId; }
            set { tipoHabilitacaoId = value; }
        }

        /// <summary>
        /// Obtém ou define a descrição do tipo de habilitação.
        /// </summary>
        /// <value>A descrição do tipo de habilitação.</value>
        public string DescTH
        {
            get { return descTH; }
            set { descTH = value; }
        }

        #endregion

        #endregion
    }
}
