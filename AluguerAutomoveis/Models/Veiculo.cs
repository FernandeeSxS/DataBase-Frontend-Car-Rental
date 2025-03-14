using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa um veículo no sistema de aluguer de automóveis.
    /// </summary>
    public class Veiculo
    {
        #region Atributos

        /// <summary>
        /// Identificador único do veículo.
        /// </summary>
        int veiculoId;

        /// <summary>
        /// Capacidade do veículo (exemplo: número de passageiros).
        /// </summary>
        int? capacidade;

        /// <summary>
        /// Quilometragem atual do veículo.
        /// </summary>
        int? km;

        /// <summary>
        /// Nível de combustível do veículo.
        /// </summary>
        string nivComb;

        /// <summary>
        /// Identificador do tipo de veículo.
        /// </summary>
        int? tipoVeiculoId;

        /// <summary>
        /// Identificador do modelo do veículo.
        /// </summary>
        int? modeloId;

        /// <summary>
        /// Identificador das condições de entrega do veículo.
        /// </summary>
        int? condicoesEntregaId;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único do veículo.
        /// </summary>
        /// <value>O identificador único do veículo.</value>
        public int VeiculoId
        {
            get { return veiculoId; }
            set { veiculoId = value; }
        }

        /// <summary>
        /// Obtém ou define a capacidade do veículo.
        /// </summary>
        /// <value>A capacidade do veículo.</value>
        public int? Capacidade
        {
            get { return capacidade; }
            set { capacidade = value; }
        }

        /// <summary>
        /// Obtém ou define a quilometragem atual do veículo.
        /// </summary>
        /// <value>A quilometragem do veículo.</value>
        public int? KM
        {
            get { return km; }
            set { km = value; }
        }

        /// <summary>
        /// Obtém ou define o nível de combustível do veículo.
        /// </summary>
        /// <value>O nível de combustível do veículo.</value>
        public string NivComb
        {
            get { return nivComb; }
            set { nivComb = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador do tipo de veículo.
        /// </summary>
        /// <value>O identificador do tipo de veículo.</value>
        public int? TipoVeiculoId
        {
            get { return tipoVeiculoId; }
            set { tipoVeiculoId = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador do modelo do veículo.
        /// </summary>
        /// <value>O identificador do modelo do veículo.</value>
        public int? ModeloId
        {
            get { return modeloId; }
            set { modeloId = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador das condições de entrega do veículo.
        /// </summary>
        /// <value>O identificador das condições de entrega do veículo.</value>
        public int? CondicoesEntregaId
        {
            get { return condicoesEntregaId; }
            set { condicoesEntregaId = value; }
        }

        #endregion

        #endregion
    }
}
