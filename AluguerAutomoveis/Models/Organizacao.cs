using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa uma organização no sistema de aluguer de automóveis.
    /// </summary>
    public class Organizacao
    {
        #region Atributos

        /// <summary>
        /// Identificador único da organização.
        /// </summary>
        int organizacaoId;

        /// <summary>
        /// Nome da organização.
        /// </summary>
        string nomeOrg;

        /// <summary>
        /// Rua onde a organização está localizada.
        /// </summary>
        string rua;

        /// <summary>
        /// Número de Identificação Fiscal (NIF) da organização.
        /// </summary>
        int? nif;

        /// <summary>
        /// Nome do representante da organização.
        /// </summary>
        string representanteOrg;

        /// <summary>
        /// Identificador do tipo de cliente associado à organização.
        /// </summary>
        int? tipoClienteId;

        /// <summary>
        /// Código Postal (CP) da organização.
        /// </summary>
        string cp;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único da organização.
        /// </summary>
        /// <value>O identificador único da organização.</value>
        public int OrganizacaoId
        {
            get { return organizacaoId; }
            set { organizacaoId = value; }
        }

        /// <summary>
        /// Obtém ou define o nome da organização.
        /// </summary>
        /// <value>O nome da organização.</value>
        public string NomeOrg
        {
            get { return nomeOrg; }
            set { nomeOrg = value; }
        }

        /// <summary>
        /// Obtém ou define a rua onde a organização está localizada.
        /// </summary>
        /// <value>A rua onde a organização está localizada.</value>
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        /// <summary>
        /// Obtém ou define o Número de Identificação Fiscal (NIF) da organização.
        /// </summary>
        /// <value>O NIF da organização.</value>
        public int? NIF
        {
            get { return nif; }
            set { nif = value; }
        }

        /// <summary>
        /// Obtém ou define o nome do representante da organização.
        /// </summary>
        /// <value>O nome do representante da organização.</value>
        public string RepresentanteOrg
        {
            get { return representanteOrg; }
            set { representanteOrg = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador do tipo de cliente associado à organização.
        /// </summary>
        /// <value>O identificador do tipo de cliente associado à organização.</value>
        public int? TipoClienteId
        {
            get { return tipoClienteId; }
            set { tipoClienteId = value; }
        }

        /// <summary>
        /// Obtém ou define o Código Postal (CP) da organização.
        /// </summary>
        /// <value>O Código Postal da organização.</value>
        public string CP
        {
            get { return cp; }
            set { cp = value; }
        }

        #endregion

        #endregion
    }
}
