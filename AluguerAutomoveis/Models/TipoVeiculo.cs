using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa um tipo de veículo no sistema de aluguer de automóveis.
    /// </summary>
    public class TipoVeiculo
    {
        #region Atributos

        /// <summary>
        /// Identificador único do tipo de veículo.
        /// </summary>
        int tipoVeiculoId;

        /// <summary>
        /// Descrição do tipo de veículo.
        /// </summary>
        string descTV;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único do tipo de veículo.
        /// </summary>
        /// <value>O identificador único do tipo de veículo.</value>
        public int TipoVeiculoId
        {
            get { return tipoVeiculoId; }
            set { tipoVeiculoId = value; }
        }

        /// <summary>
        /// Obtém ou define a descrição do tipo de veículo.
        /// </summary>
        /// <value>A descrição do tipo de veículo.</value>
        public string DescTV
        {
            get { return descTV; }
            set { descTV = value; }
        }

        #endregion

        #endregion
    }
}