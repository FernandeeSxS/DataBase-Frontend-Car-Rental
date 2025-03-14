using AluguerAutomoveis.FrontEnd;
using System;
using System.Windows.Forms;

namespace AluguerAutomoveis.FrontEnd
{
    public partial class FormDadosVeiculo : Form
    {
        #region Construtores

        /// <summary>
        /// Construtor padrão do formulário.
        /// </summary>
        public FormDadosVeiculo()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Evento disparado ao clicar no botão para inserir um veículo. Abre o formulário <see cref="FormInserirVeiculo"/>.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnInserirVeiculo_Click(object sender, EventArgs e)
        {
            FormInserirVeiculo formInserir = new FormInserirVeiculo();
            formInserir.ShowDialog();
        }

        /// <summary>
        /// Evento disparado ao clicar no botão para editar um veículo. Abre o formulário <see cref="FormEditarVeiculo"/>.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnEditarVeiculo_Click(object sender, EventArgs e)
        {
            FormEditarVeiculo formEditar = new FormEditarVeiculo();
            formEditar.ShowDialog();
        }

        /// <summary>
        /// Evento disparado ao clicar no botão para eliminar um veículo. Abre o formulário <see cref="FormEliminarVeiculo"/>.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnEliminarVeiculo_Click(object sender, EventArgs e)
        {
            FormEliminarVeiculo formEliminar = new FormEliminarVeiculo();
            formEliminar.ShowDialog();
        }
        #endregion
    }
}

