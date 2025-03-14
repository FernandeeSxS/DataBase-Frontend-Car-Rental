using AluguerAutomoveis.FrontEnd;
using System;
using System.Windows.Forms;

namespace AluguerAutomoveis.FrontEnd
{
    /// <summary>
    /// Formulário principal para a gestão de condutores, permitindo acessar funcionalidades para inserir, editar e eliminar condutores.
    /// </summary>
    public partial class FormDadosCondutor : Form
    {
        #region Construtor

        /// <summary>
        /// Construtor da classe `FormDadosCondutor`, inicializa o formulário e seus componentes.
        /// </summary>
        public FormDadosCondutor()
        {
            InitializeComponent();
        }

        #endregion


        #region Métodos

        /// <summary>
        /// Evento acionado ao clicar no botão "Inserir Condutor". Abre o formulário para inserir um novo condutor.
        /// </summary>
        private void btnInserirCondutor_Click(object sender, EventArgs e)
        {
            FormInserirCondutor formInserir = new FormInserirCondutor();
            this.Hide();
            formInserir.ShowDialog(); 
            this.Show();
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Editar Condutor". Abre o formulário para editar um condutor existente.
        /// </summary>
        private void btnEditarCondutor_Click(object sender, EventArgs e)
        {
            FormEditarCondutor formEditar = new FormEditarCondutor();
            this.Hide();
            formEditar.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Eliminar Condutor". Abre o formulário para eliminar um condutor.
        /// </summary>
        private void btnEliminarCondutor_Click(object sender, EventArgs e)
        {
            FormEliminarCondutor formEliminar = new FormEliminarCondutor();
            this.Hide();
            formEliminar.ShowDialog();
            this.Show();
        }

        #endregion
    }
}

