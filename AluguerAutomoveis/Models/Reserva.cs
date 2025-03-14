using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa uma reserva no sistema de aluguer de automóveis.
    /// </summary>
    public class Reserva
    {
        #region Atributos

        /// <summary>
        /// Identificador único da reserva.
        /// </summary>
        int reservaId;

        /// <summary>
        /// Data em que a reserva foi efetuada.
        /// </summary>
        DateTime? dataRes;

        /// <summary>
        /// Data de início do aluguer.
        /// </summary>
        DateTime? dataIniAluguer;

        /// <summary>
        /// Data de fim do aluguer.
        /// </summary>
        DateTime? dataFimAluguer;

        /// <summary>
        /// Local onde o veículo será levantado.
        /// </summary>
        string localLev;

        /// <summary>
        /// Local onde o veículo será devolvido.
        /// </summary>
        string localDev;

        /// <summary>
        /// Preço diário do aluguer do veículo.
        /// </summary>
        decimal? precoDiario;

        /// <summary>
        /// Número de quilómetros permitidos durante o aluguer.
        /// </summary>
        int? kmPerm;

        /// <summary>
        /// Valor da caução associada à reserva.
        /// </summary>
        decimal? caucao;

        /// <summary>
        /// Identificador do condutor associado à reserva.
        /// </summary>
        int? condutorId;

        /// <summary>
        /// Identificador da organização associada à reserva.
        /// </summary>
        int? organizacaoId;

        /// <summary>
        /// Identificador do tipo de extra associado à reserva.
        /// </summary>
        int? tipoExtraId;

        /// <summary>
        /// Identificador do veículo reservado.
        /// </summary>
        int? veiculoId;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único da reserva.
        /// </summary>
        /// <value>O identificador único da reserva.</value>
        public int ReservaId
        {
            get { return reservaId; }
            set { reservaId = value; }
        }

        /// <summary>
        /// Obtém ou define a data em que a reserva foi efetuada.
        /// </summary>
        /// <value>A data de realização da reserva.</value>
        public DateTime? DataRes
        {
            get { return dataRes; }
            set { dataRes = value; }
        }

        /// <summary>
        /// Obtém ou define a data de início do aluguer.
        /// </summary>
        /// <value>A data de início do aluguer.</value>
        public DateTime? DataIniAluguer
        {
            get { return dataIniAluguer; }
            set { dataIniAluguer = value; }
        }

        /// <summary>
        /// Obtém ou define a data de fim do aluguer.
        /// </summary>
        /// <value>A data de fim do aluguer.</value>
        public DateTime? DataFimAluguer
        {
            get { return dataFimAluguer; }
            set { dataFimAluguer = value; }
        }

        /// <summary>
        /// Obtém ou define o local onde o veículo será levantado.
        /// </summary>
        /// <value>O local de levantamento do veículo.</value>
        public string LocalLev
        {
            get { return localLev; }
            set { localLev = value; }
        }

        /// <summary>
        /// Obtém ou define o local onde o veículo será devolvido.
        /// </summary>
        /// <value>O local de devolução do veículo.</value>
        public string LocalDev
        {
            get { return localDev; }
            set { localDev = value; }
        }

        /// <summary>
        /// Obtém ou define o preço diário do aluguer.
        /// </summary>
        /// <value>O preço diário do aluguer.</value>
        public decimal? PrecoDiario
        {
            get { return precoDiario; }
            set { precoDiario = value; }
        }

        /// <summary>
        /// Obtém ou define o número de quilómetros permitidos durante o aluguer.
        /// </summary>
        /// <value>O número de quilómetros permitidos.</value>
        public int? KmPerm
        {
            get { return kmPerm; }
            set { kmPerm = value; }
        }

        /// <summary>
        /// Obtém ou define o valor da caução associada à reserva.
        /// </summary>
        /// <value>O valor da caução.</value>
        public decimal? Caucao
        {
            get { return caucao; }
            set { caucao = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador do condutor associado à reserva.
        /// </summary>
        /// <value>O identificador do condutor.</value>
        public int? CondutorId
        {
            get { return condutorId; }
            set { condutorId = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador da organização associada à reserva.
        /// </summary>
        /// <value>O identificador da organização.</value>
        public int? OrganizacaoId
        {
            get { return organizacaoId; }
            set { organizacaoId = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador do tipo de extra associado à reserva.
        /// </summary>
        /// <value>O identificador do tipo de extra.</value>
        public int? TipoExtraId
        {
            get { return tipoExtraId; }
            set { tipoExtraId = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador do veículo reservado.
        /// </summary>
        /// <value>O identificador do veículo.</value>
        public int? VeiculoId
        {
            get { return veiculoId; }
            set { veiculoId = value; }
        }

        #endregion

        #endregion
    }
}