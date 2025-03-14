using System;
using System.Windows.Forms;
using AluguerAutomoveis.Models;
using AluguerAutomoveis.Negocio;

namespace AluguerAutomoveis.FrontEnd
{
    /// <summary>
    /// Formulário para eliminação de veículos.
    /// </summary>
    public partial class FormEliminarVeiculo : Form
    {
        #region Construtores

        /// <summary>
        /// Construtor padrão do formulário.
        /// </summary>
        public FormEliminarVeiculo()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Evento disparado ao clicar no botão "Eliminar". Solicita o ID do veículo e tenta eliminá-lo.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int veiculoId;
            if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do veículo a ser eliminado:", "Eliminar Veículo"), out veiculoId))
            {
                RegrasVeiculos gestaoVeiculos = new RegrasVeiculos();
                Veiculo veiculo = gestaoVeiculos.BuscarVeiculoPorId(veiculoId);

                if (veiculo != null)
                {
                    var confirmResult = MessageBox.Show("Tem certeza que deseja eliminar o veículo ?", "Confirmar Eliminação", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        gestaoVeiculos.ExcluirVeiculo(veiculoId);
                        MessageBox.Show("Veículo eliminado com sucesso.", "Sucesso");
                    }
                }
                else
                {
                    MessageBox.Show("Veículo não encontrado.", "Erro");
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

