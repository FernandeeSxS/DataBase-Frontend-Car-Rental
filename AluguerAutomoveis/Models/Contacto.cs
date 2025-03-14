using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa um contacto no sistema de aluguer de automóveis.
    /// </summary>
    public class Contacto
    {
        #region Atributos

        /// <summary>
        /// Identificador único do contacto.
        /// </summary>
        int contactoId;

        /// <summary>
        /// Informação de contacto (por exemplo, número de telefone ou email).
        /// </summary>
        string contact;

        /// <summary>
        /// Identificador do condutor associado ao contacto (se aplicável).
        /// </summary>
        int? condutorId;

        /// <summary>
        /// Identificador do tipo de contacto.
        /// </summary>
        int tipoContactoId;

        /// <summary>
        /// Identificador da organização associada ao contacto (se aplicável).
        /// </summary>
        int? organizacaoId;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único do contacto.
        /// </summary>
        /// <value>O identificador único do contacto.</value>
        public int ContactoId
        {
            get { return contactoId; }
            set { contactoId = value; }
        }

        /// <summary>
        /// Obtém ou define a informação de contacto (ex.: número de telefone ou email).
        /// </summary>
        /// <value>A informação de contacto.</value>
        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador do condutor associado ao contacto (se aplicável).
        /// </summary>
        /// <value>O identificador do condutor.</value>
        public int? CondutorId
        {
            get { return condutorId; }
            set { condutorId = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador do tipo de contacto.
        /// </summary>
        /// <value>O identificador do tipo de contacto.</value>
        public int TipoContactoId
        {
            get { return tipoContactoId; }
            set { tipoContactoId = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador da organização associada ao contacto (se aplicável).
        /// </summary>
        /// <value>O identificador da organização.</value>
        public int? OrganizacaoId
        {
            get { return organizacaoId; }
            set { organizacaoId = value; }
        }

        #endregion

        #endregion
    }
}
