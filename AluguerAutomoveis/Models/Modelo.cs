using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa um modelo de automóvel no sistema de aluguer de automóveis.
    /// </summary>
    public class Modelo
    {
        #region Atributos

        /// <summary>
        /// Identificador único do modelo.
        /// </summary>
        int modeloId;

        /// <summary>
        /// Descrição do modelo.
        /// </summary>
        string descMod;

        /// <summary>
        /// Identificador da marca associada ao modelo.
        /// </summary>
        int? marcaId;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único do modelo.
        /// </summary>
        /// <value>O identificador único do modelo.</value>
        public int ModeloId
        {
            get { return modeloId; }
            set { modeloId = value; }
        }

        /// <summary>
        /// Obtém ou define a descrição do modelo.
        /// </summary>
        /// <value>A descrição do modelo.</value>
        public string DescMod
        {
            get { return descMod; }
            set { descMod = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador da marca associada ao modelo.
        /// </summary>
        /// <value>O identificador da marca associada ao modelo.</value>
        public int? MarcaId
        {
            get { return marcaId; }
            set { marcaId = value; }
        }

        #endregion

        #endregion
    }
}
