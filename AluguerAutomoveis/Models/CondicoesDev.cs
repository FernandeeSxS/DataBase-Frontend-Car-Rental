using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa as condições de devolução de um veículo.
    /// </summary>
    public class CondicoesDev
    {
        #region atributos

        /// <summary>
        /// Identificador único da condição de devolução.
        /// </summary>
        private int condicoesDevId;

        /// <summary>
        /// Descrição detalhada das condições de devolução.
        /// </summary>
        private string descCondDev;

        #endregion

        #region Metodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único da condição de devolução.
        /// </summary>
        /// <value>O identificador único da condição de devolução.</value>
        public int CondicoesDevId
        {
            get { return condicoesDevId; }
            set { condicoesDevId = value; }
        }

        /// <summary>
        /// Obtém ou define a descrição das condições de devolução.
        /// </summary>
        /// <value>A descrição detalhada das condições de devolução.</value>
        public string DescCondDev
        {
            get { return descCondDev; }
            set { descCondDev = value; }
        }

        #endregion

        #endregion
    }
}

