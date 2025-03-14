using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa as condições de entrega de um veículo.
    /// </summary>
    public class CondicoesEntrega
    {
        #region Atributos

        /// <summary>
        /// Identificador único da condição de entrega.
        /// </summary>
        private int condicoesEntregaId;

        /// <summary>
        /// Descrição detalhada das condições de entrega.
        /// </summary>
        private string descCondEntrega;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único da condição de entrega.
        /// </summary>
        /// <value>O identificador único da condição de entrega.</value>
        public int CondicoesEntregaId
        {
            get { return condicoesEntregaId; }
            set { condicoesEntregaId = value; }
        }

        /// <summary>
        /// Obtém ou define a descrição das condições de entrega.
        /// </summary>
        /// <value>A descrição detalhada das condições de entrega.</value>
        public string DescCondEntrega
        {
            get { return descCondEntrega; }
            set { descCondEntrega = value; }
        }

        #endregion

        #endregion
    }
}
