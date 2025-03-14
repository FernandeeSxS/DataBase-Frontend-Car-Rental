using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa um tipo de cliente no sistema de aluguer de automóveis.
    /// </summary>
    public class TipoCliente
    {
        #region Atributos

        /// <summary>
        /// Identificador único do tipo de cliente.
        /// </summary>
        int tipoClienteId;

        /// <summary>
        /// Descrição do tipo de cliente.
        /// </summary>
        int? descTC;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único do tipo de cliente.
        /// </summary>
        /// <value>O identificador único do tipo de cliente.</value>
        public int TipoClienteId
        {
            get { return tipoClienteId; }
            set { tipoClienteId = value; }
        }

        /// <summary>
        /// Obtém ou define a descrição do tipo de cliente.
        /// </summary>
        /// <value>A descrição do tipo de cliente.</value>
        public int? DescTC
        {
            get { return descTC; }
            set { descTC = value; }
        }

        #endregion

        #endregion
    }
}