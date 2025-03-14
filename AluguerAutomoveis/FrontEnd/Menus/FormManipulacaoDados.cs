using System;
using System.Windows.Forms;
using AluguerAutomoveis.FrontEnd;

namespace AluguerAutomoveis
{
    /// <summary>
    /// Formulário para manipulação de dados das tabelas Condutor, Reserva e Veículo.
    /// </summary>
    public partial class FormManipulacaoDados : Form
    {
        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância de <see cref="FormManipulacaoDados"/>.
        /// </summary>
        public FormManipulacaoDados()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Evento acionado ao clicar no botão para manipular dados da tabela Condutor.
        /// Abre o formulário <see cref="FormDadosCondutor"/>.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnCondutor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrindo manipulação de dados para a tabela Condutor.");
            FormDadosCondutor formCondutor = new FormDadosCondutor();
            this.Hide();
            formCondutor.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Evento acionado ao clicar no botão para manipular dados da tabela Reserva.
        /// Abre o formulário <see cref="FormDadosReserva"/>.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnReserva_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrindo manipulação de dados para a tabela Reserva.");
            FormDadosReserva formReserva = new FormDadosReserva();
            this.Hide();
            formReserva.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Evento acionado ao clicar no botão para manipular dados da tabela Veículo.
        /// Abre o formulário <see cref="FormDadosVeiculo"/>.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrindo manipulação de dados para a tabela Veículo.");
            FormDadosVeiculo formVeiculo = new FormDadosVeiculo();
            this.Hide();
            formVeiculo.ShowDialog();
            this.Show();
        }
        #endregion
    }
}
