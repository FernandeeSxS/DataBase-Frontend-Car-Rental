using System;
using System.Windows.Forms;

namespace AluguerAutomoveis
{
    /// <summary>
    /// Formulário principal do menu de navegação do sistema de aluguer de automóveis.
    /// </summary>
    public partial class FormMenu : Form
    {
        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância de <see cref="FormMenu"/>.
        /// </summary>
        public FormMenu()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Evento acionado ao clicar no botão para manipulação de dados.
        /// Abre o formulário <see cref="FormManipulacaoDados"/>.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnManipulacaoDados_Click(object sender, EventArgs e)
        {
            var formManipulacao = new FormManipulacaoDados();
            this.Hide(); 
            formManipulacao.ShowDialog();
            this.Show(); 
        }

        /// <summary>
        /// Evento acionado ao clicar no botão para executar Stored Procedures.
        /// Abre o formulário <see cref="FormEncontrarCondutores"/>.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnStoredProcedure_Click(object sender, EventArgs e)
        {
            var formSP = new FormEncontrarCondutores();
            this.Hide();
            formSP.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Evento acionado ao clicar no botão para executar consultas SQL.
        /// Abre o formulário <see cref="FormEncontrarCondutoresPorIdadeMinima"/>.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            var formQuery = new FormEncontrarCondutoresPorIdadeMinima();
            this.Hide();
            formQuery.ShowDialog();
            this.Show();
        }
        #endregion

    }
}
