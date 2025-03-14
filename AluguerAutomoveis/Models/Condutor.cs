using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguerAutomoveis.Models
{
    /// <summary>
    /// Representa um condutor de veículo no sistema de aluguer de automóveis.
    /// </summary>
    public class Condutor
    {
        #region Atributos

        /// <summary>
        /// Identificador único do condutor.
        /// </summary>
        int condutorId;

        /// <summary>
        /// Nome do condutor.
        /// </summary>
        string nomeCondutor;

        /// <summary>
        /// Rua onde o condutor reside.
        /// </summary>
        string rua;

        /// <summary>
        /// Documento de identificação do condutor.
        /// </summary>
        string docIdentificacao;

        /// <summary>
        /// Data de nascimento do condutor.
        /// </summary>
        DateTime? dataNasc;

        /// <summary>
        /// Título do condutor (exemplo: "Sr.", "Sra.", etc.).
        /// </summary>
        string tituloCondutor;

        /// <summary>
        /// Número do Cartão MB (caso aplicável).
        /// </summary>
        int? cartaoMB;

        /// <summary>
        /// Identificador do tipo de cliente associado ao condutor.
        /// </summary>
        int tipoClienteId;

        /// <summary>
        /// Código Postal (CP) da residência do condutor.
        /// </summary>
        string cp;

        /// <summary>
        /// Identificador da organização associada ao condutor.
        /// </summary>
        int organizacaoId;

        /// <summary>
        /// Lista de contactos do condutor.
        /// </summary>
        List<Contacto> contactos;

        /// <summary>
        /// Lista de habilitações do condutor.
        /// </summary>
        List<Habilitacao> habilitacoes;

        #endregion

        #region Métodos

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único do condutor.
        /// </summary>
        /// <value>O identificador único do condutor.</value>
        public int CondutorId
        {
            get { return condutorId; }
            set { condutorId = value; }
        }

        /// <summary>
        /// Obtém ou define o nome do condutor.
        /// </summary>
        /// <value>O nome completo do condutor.</value>
        public string NomeCondutor
        {
            get { return nomeCondutor; }
            set { nomeCondutor = value; }
        }

        /// <summary>
        /// Obtém ou define a rua onde o condutor reside.
        /// </summary>
        /// <value>O nome da rua onde o condutor reside.</value>
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        /// <summary>
        /// Obtém ou define o documento de identificação do condutor.
        /// </summary>
        /// <value>O número do documento de identificação do condutor.</value>
        public string DocIdentificacao
        {
            get { return docIdentificacao; }
            set { docIdentificacao = value; }
        }

        /// <summary>
        /// Obtém ou define a data de nascimento do condutor.
        /// </summary>
        /// <value>A data de nascimento do condutor.</value>
        public DateTime? DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }

        /// <summary>
        /// Obtém ou define o título do condutor (ex: "Sr.", "Sra.", etc.).
        /// </summary>
        /// <value>O título do condutor.</value>
        public string TituloCondutor
        {
            get { return tituloCondutor; }
            set { tituloCondutor = value; }
        }

        /// <summary>
        /// Obtém ou define o número do Cartão MB (se aplicável).
        /// </summary>
        /// <value>O número do Cartão MB.</value>
        public int? CartaoMB
        {
            get { return cartaoMB; }
            set { cartaoMB = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador do tipo de cliente associado ao condutor.
        /// </summary>
        /// <value>O identificador do tipo de cliente.</value>
        public int TipoClienteId
        {
            get { return tipoClienteId; }
            set { tipoClienteId = value; }
        }

        /// <summary>
        /// Obtém ou define o código postal (CP) da residência do condutor.
        /// </summary>
        /// <value>O código postal da residência do condutor.</value>
        public string CP
        {
            get { return cp; }
            set { cp = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador da organização associada ao condutor.
        /// </summary>
        /// <value>O identificador da organização.</value>
        public int OrganizacaoId
        {
            get { return organizacaoId; }
            set { organizacaoId = value; }
        }

        /// <summary>
        /// Obtém ou define a lista de contactos associados ao condutor.
        /// </summary>
        /// <value>A lista de contactos do condutor.</value>
        public List<Contacto> Contactos
        {
            get { return contactos; }
            set { contactos = value; }
        }

        /// <summary>
        /// Obtém ou define a lista de habilitações do condutor.
        /// </summary>
        /// <value>A lista de habilitações do condutor.</value>
        public List<Habilitacao> Habilitacoes
        {
            get { return habilitacoes; }
            set { habilitacoes = value; }
        }

        #endregion

        #endregion
    }
}
