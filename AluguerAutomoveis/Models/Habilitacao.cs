using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa uma habilitação de condução no sistema de aluguer de automóveis.
    /// </summary>
    public class Habilitacao
    {
        #region Atributos

        /// <summary>
        /// Identificador único da habilitação.
        /// </summary>
        int habilitacaoId;

        /// <summary>
        /// Data de emissão da habilitação.
        /// </summary>
        DateTime? dataEmiss;

        /// <summary>
        /// Data de validade da habilitação.
        /// </summary>
        DateTime? dataValidade;

        /// <summary>
        /// Entidade emissora da habilitação.
        /// </summary>
        string entidadeEmiss;

        /// <summary>
        /// País emissor da habilitação.
        /// </summary>
        string paisEmiss;

        /// <summary>
        /// Identificador do condutor associado à habilitação (se aplicável).
        /// </summary>
        int? condutorId;

        /// <summary>
        /// Identificador do tipo de habilitação.
        /// </summary>
        int? tipoHabilitacaoId;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único da habilitação.
        /// </summary>
        /// <value>O identificador único da habilitação.</value>
        public int HabilitacaoId
        {
            get { return habilitacaoId; }
            set { habilitacaoId = value; }
        }

        /// <summary>
        /// Obtém ou define a data de emissão da habilitação.
        /// </summary>
        /// <value>A data de emissão.</value>
        public DateTime? DataEmiss
        {
            get { return dataEmiss; }
            set { dataEmiss = value; }
        }

        /// <summary>
        /// Obtém ou define a data de validade da habilitação.
        /// </summary>
        /// <value>A data de validade.</value>
        public DateTime? DataValidade
        {
            get { return dataValidade; }
            set { dataValidade = value; }
        }

        /// <summary>
        /// Obtém ou define a entidade emissora da habilitação.
        /// </summary>
        /// <value>A entidade emissora.</value>
        public string EntidadeEmiss
        {
            get { return entidadeEmiss; }
            set { entidadeEmiss = value; }
        }

        /// <summary>
        /// Obtém ou define o país emissor da habilitação.
        /// </summary>
        /// <value>O país emissor.</value>
        public string PaisEmiss
        {
            get { return paisEmiss; }
            set { paisEmiss = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador do condutor associado à habilitação (se aplicável).
        /// </summary>
        /// <value>O identificador do condutor.</value>
        public int? CondutorId
        {
            get { return condutorId; }
            set { condutorId = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador do tipo de habilitação.
        /// </summary>
        /// <value>O identificador do tipo de habilitação.</value>
        public int? TipoHabilitacaoId
        {
            get { return tipoHabilitacaoId; }
            set { tipoHabilitacaoId = value; }
        }

        #endregion

        #endregion
    }
}


