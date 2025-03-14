using System;
using System.Linq;
using System.Windows.Forms;
using AluguerAutomoveis.Negocio;

namespace AluguerAutomoveis
{
    /// <summary>
    /// Formulário responsável por editar as informações de um condutor existente.
    /// Permite ao usuário alterar um atributo específico de um condutor com base no seu ID.
    /// </summary>
    public partial class FormEditarCondutor : Form
    {
        #region Construtor

        /// <summary>
        /// Construtor da classe `FormEditarCondutor`, inicializa o formulário e seus componentes.
        /// </summary>
        public FormEditarCondutor()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Método acionado ao clicar no botão "Editar". Solicita o ID do condutor e o atributo a ser editado, além do novo valor para o atributo.
        /// </summary>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            string inputId = Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do condutor que deseja editar:", "Editar Condutor", "");
            if (int.TryParse(inputId, out int condutorId))
            {
                RegrasCondutores gestaoCondutores = new RegrasCondutores();
                string[] atributos = { "Nome", "Rua", "DocIdentificacao", "DataNasc", "TituloCondutor", "CartaoMB", "TipoClienteId", "CP", "OrganizacaoId" };
                string atributoSelecionado = Microsoft.VisualBasic.Interaction.InputBox("Escolha o atributo que deseja editar:\n" + string.Join("\n", atributos), "Escolher Atributo", "");

                if (atributos.Contains(atributoSelecionado))
                {
                    string novoValor = Microsoft.VisualBasic.Interaction.InputBox($"Digite o novo valor para {atributoSelecionado}:", "Novo Valor", "");
                    bool sucesso = gestaoCondutores.EditarCondutor(condutorId, atributoSelecionado, novoValor);

                    if (sucesso)
                    {
                        MessageBox.Show("Condutor atualizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar o condutor.");
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

