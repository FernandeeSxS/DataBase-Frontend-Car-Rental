using AluguerAutomoveis.FrontEnd;
using System;
using System.Windows.Forms;

namespace AluguerAutomoveis.FrontEnd
{
    /// <summary>
    /// Formulário principal para gerir dados de reservas.
    /// </summary>
    public partial class FormDadosReserva : Form
    {
        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância de <see cref="FormDadosReserva"/>.
        /// </summary>
        public FormDadosReserva()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento acionado ao clicar no botão para inserir uma nova reserva.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param> 
        private void btnInserirReserva_Click(object sender, EventArgs e)
        {
            FormInserirReserva formInserir = new FormInserirReserva();
            formInserir.ShowDialog(); 
        }

        /// <summary>
        /// Evento acionado ao clicar no botão para editar uma reserva existente.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>        
        private void btnEditarReserva_Click(object sender, EventArgs e)
        {
            FormEditarReserva formEditar = new FormEditarReserva();
            formEditar.ShowDialog();
        }

        /// <summary>
        /// Evento acionado ao clicar no botão para eliminar uma reserva existente.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnEliminarReserva_Click(object sender, EventArgs e)
        {
            FormEliminarReserva formEliminar = new FormEliminarReserva();
            formEliminar.ShowDialog();
        }
        #endregion
    }
}

