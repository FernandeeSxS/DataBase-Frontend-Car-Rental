using System;
using System.Windows.Forms;
using AluguerAutomoveis.Models;
using AluguerAutomoveis.Negocio;

namespace AluguerAutomoveis.FrontEnd
{
    /// <summary>
    /// Formulário para eliminar reservas.
    /// </summary>
    public partial class FormEliminarReserva : Form
    {
        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância de <see cref="FormEliminarReserva"/>.
        /// </summary>
        public FormEliminarReserva()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos

        // <summary>
        /// Evento acionado ao clicar no botão de eliminar reserva.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int reservaId;
            if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Digite o ID da reserva a ser eliminada:", "Eliminar Reserva"), out reservaId))
            {
                RegrasReserva gestaoReservas = new RegrasReserva();
                Reserva reserva = gestaoReservas.BuscarReservaPorId(reservaId);

                if (reserva != null)
                {
                    var confirmResult = MessageBox.Show("Tem certeza que deseja eliminar a reserva?", "Confirmar Eliminação", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        gestaoReservas.ExcluirReserva(reservaId);
                        MessageBox.Show("Reserva eliminada com sucesso.", "Sucesso");
                    }
                }
                else
                {
                    MessageBox.Show("Reserva não encontrada.", "Erro");
                }
            }
            else
            {
                MessageBox.Show("ID inválido.", "Erro");
            }
        }
        #endregion
    }
}

