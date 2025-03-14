using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa uma marca de automóveis no sistema de aluguer de automóveis.
    /// </summary>
    public class Marca
    {
        #region Atributos

        /// <summary>
        /// Identificador único da marca.
        /// </summary>
        int marcaId;

        /// <summary>
        /// Descrição da marca.
        /// </summary>
        string descM;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único da marca.
        /// </summary>
        /// <value>O identificador único da marca.</value>
        public int MarcaId
        {
            get { return marcaId; }
            set { marcaId = value; }
        }

        /// <summary>
        /// Obtém ou define a descrição da marca.
        /// </summary>
        /// <value>A descrição da marca.</value>
        public string DescM
        {
            get { return descM; }
            set { descM = value; }
        }

        #endregion

        #endregion
    }
}


