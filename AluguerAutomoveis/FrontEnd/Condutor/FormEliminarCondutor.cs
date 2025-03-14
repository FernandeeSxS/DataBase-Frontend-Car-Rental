using System;
using System.Windows.Forms;
using AluguerAutomoveis.Models;
using AluguerAutomoveis.Negocio;

namespace AluguerAutomoveis
{
    /// <summary>
    /// Formulário responsável por eliminar um condutor com base no ID fornecido.
    /// </summary>
    public partial class FormEliminarCondutor : Form
    {
        #region Construtor

        /// <summary>
        /// Construtor da classe `FormEliminarCondutor`, inicializa o formulário e seus componentes.
        /// </summary>
        public FormEliminarCondutor()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Método acionado ao clicar no botão "Eliminar", que solicita o ID do condutor e executa o processo de eliminação.
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int condutorId;
            if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do condutor a ser eliminado:", "Eliminar Condutor"), out condutorId))
            {
                RegrasCondutores gestaoCondutores = new RegrasCondutores();
                Condutor condutor = gestaoCondutores.BuscarCondutorPorId(condutorId);

                if (condutor != null)
                {
                    var confirmResult = MessageBox.Show("Tem certeza que deseja eliminar o condutor " + condutor.NomeCondutor + "?", "Confirmar Eliminação", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        gestaoCondutores.ExcluirCondutor(condutorId);
                        MessageBox.Show("Condutor eliminado com sucesso.", "Sucesso");
                    }
                }
                else
                {
                    MessageBox.Show("Condutor não encontrado.", "Erro");
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

