using System;
using System.Linq;
using System.Windows.Forms;
using AluguerAutomoveis.Negocio;

namespace AluguerAutomoveis.FrontEnd
{
    /// <summary>
    /// Formulário para edição de veículos.
    /// </summary>
    public partial class FormEditarVeiculo : Form
    {
        #region Construtores

        /// <summary>
        /// Construtor padrão do formulário.
        /// </summary>
        public FormEditarVeiculo()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Evento disparado ao clicar no botão "Editar". Solicita o ID do veículo, o atributo a ser editado e o novo valor.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            string inputId = Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do veículo que deseja editar:", "Editar Veículo", "");
            if (int.TryParse(inputId, out int veiculoId))
            {
                RegrasVeiculos gestaoVeiculos = new RegrasVeiculos();
                string[] atributos = { "Capacidade", "KM", "NivComb", "TipoVeiculoId", "ModeloId", "CondicoesEntregaId" };
                string atributoSelecionado = Microsoft.VisualBasic.Interaction.InputBox("Escolha o atributo que deseja editar:\n" + string.Join("\n", atributos), "Escolher Atributo", "");

                if (atributos.Contains(atributoSelecionado))
                {
                    string novoValor = Microsoft.VisualBasic.Interaction.InputBox($"Digite o novo valor para {atributoSelecionado}:", "Novo Valor", "");
                    bool sucesso = gestaoVeiculos.EditarVeiculo(veiculoId, atributoSelecionado, novoValor);

                    if (sucesso)
                    {
                        MessageBox.Show("Veículo atualizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar o veículo.");
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

