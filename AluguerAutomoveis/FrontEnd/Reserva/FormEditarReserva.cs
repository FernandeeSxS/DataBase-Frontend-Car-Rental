using System;
using System.Linq;
using System.Windows.Forms;
using AluguerAutomoveis.Negocio;

namespace AluguerAutomoveis.FrontEnd
{
    /// <summary>
    /// Formulário para editar reservas.
    /// </summary>
    public partial class FormEditarReserva : Form
    {
        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância de <see cref="FormEditarReserva"/>.
        /// </summary>
        public FormEditarReserva()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos 

        /// <summary>
        /// Edita uma reserva existente com base no ID e no atributo fornecido pelo utilizador.
        /// </summary>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            string inputId = Microsoft.VisualBasic.Interaction.InputBox("Digite o ID da reserva que deseja editar:", "Editar Reserva", "");
            if (int.TryParse(inputId, out int reservaId))
            {
                RegrasReserva gestaoReservas = new RegrasReserva();
                string[] atributos = { "DataRes", "DataIniAluguer", "DataFimAluguer", "LocalLev", "LocalDev", "PrecoDiario", "KmPerm", "Caucao", "CondutorId", "OrganizacaoId", "TipoExtraId", "VeiculoId" };
                string atributoSelecionado = Microsoft.VisualBasic.Interaction.InputBox("Escolha o atributo que deseja editar:\n" + string.Join("\n", atributos), "Escolher Atributo", "");

                if (atributos.Contains(atributoSelecionado))
                {
                    string novoValor = Microsoft.VisualBasic.Interaction.InputBox($"Digite o novo valor para {atributoSelecionado}:", "Novo Valor", "");
                    bool sucesso = gestaoReservas.EditarReserva(reservaId, atributoSelecionado, novoValor);

                    if (sucesso)
                    {
                        MessageBox.Show("Reserva atualizada com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar a reserva.");
                    }
                }
                else
                {
                    MessageBox.Show("Atributo inválido!");
                }
            }
            else
            {
                MessageBox.Show("ID inválido!");
            }
        }

        #endregion
    }
}

