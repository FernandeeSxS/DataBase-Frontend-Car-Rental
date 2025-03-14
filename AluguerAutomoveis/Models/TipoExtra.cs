using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa um tipo extra no sistema de aluguer de automóveis.
    /// </summary>
    public class TipoExtra
    {
        #region Atributos

        /// <summary>
        /// Identificador único do tipo extra.
        /// </summary>
        int tipoExtraId;

        /// <summary>
        /// Descrição do tipo extra.
        /// </summary>
        string descTipoExtra;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único do tipo extra.
        /// </summary>
        /// <value>O identificador único do tipo extra.</value>
        public int TipoExtraId
        {
            get { return tipoExtraId; }
            set { tipoExtraId = value; }
        }

        /// <summary>
        /// Obtém ou define a descrição do tipo extra.
        /// </summary>
        /// <value>A descrição do tipo extra.</value>
        public string DescTipoExtra
        {
            get { return descTipoExtra; }
            set { descTipoExtra = value; }
        }

        #endregion

        #endregion
    }
}

