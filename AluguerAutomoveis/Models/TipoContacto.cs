using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa um tipo de contacto no sistema de aluguer de automóveis.
    /// </summary>
    public class TipoContacto
    {
        #region Atributos

        /// <summary>
        /// Identificador único do tipo de contacto.
        /// </summary>
        int tipoContactoId;

        /// <summary>
        /// Descrição do tipo de contacto.
        /// </summary>
        string descContacto;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único do tipo de contacto.
        /// </summary>
        /// <value>O identificador único do tipo de contacto.</value>
        public int TipoContactoId
        {
            get { return tipoContactoId; }
            set { tipoContactoId = value; }
        }

        /// <summary>
        /// Obtém ou define a descrição do tipo de contacto.
        /// </summary>
        /// <value>A descrição do tipo de contacto.</value>
        public string DescContacto
        {
            get { return descContacto; }
            set { descContacto = value; }
        }

        #endregion

        #endregion
    }
}

