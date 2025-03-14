using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa um código postal no sistema de aluguer de automóveis.
    /// </summary>
    public class CPostal
    {
        #region Atributos

        /// <summary>
        /// Código postal.
        /// </summary>
        string cp;

        /// <summary>
        /// Localidade associada ao código postal.
        /// </summary>
        string localidade;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o código postal.
        /// </summary>
        /// <value>O código postal.</value>
        public string CP
        {
            get { return cp; }
            set { cp = value; }
        }

        /// <summary>
        /// Obtém ou define a localidade associada ao código postal.
        /// </summary>
        /// <value>A localidade.</value>
        public string Localidade
        {
            get { return localidade; }
            set { localidade = value; }
        }

        #endregion

        #endregion
    }
}

