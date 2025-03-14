using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AluguerAutomoveis.FrontEnd
{
    /// <summary>
    /// Formulário para adicionar novas condições de entrega.
    /// </summary>
    public partial class FormNovasCondicoes : Form
    {
        #region Atributos

        /// <summary>
        /// O ID das condições de entrega a ser manipuladas.
        /// </summary>
        int condicoesEntregaId;

        #endregion

        #region Métodos

        /// <summary>
        /// Construtor do formulário, inicializa o formulário com o ID das condições de entrega fornecido.
        /// </summary>
        /// <param name="condicoesEntregaId">O ID das condições de entrega a ser associado ao formulário.</param>
        public FormNovasCondicoes(int condicoesEntregaId)
        {
            InitializeComponent();
            this.condicoesEntregaId = condicoesEntregaId;
            txtCondicoesEntregaId.Text = condicoesEntregaId.ToString();
            txtCondicoesEntregaId.ReadOnly = true;
        }

        /// <summary>
        /// Método chamado quando o botão "Adicionar Condições" é clicado. Verifica se os dados estão corretos e adiciona as condições de entrega à base de dados.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnAdicionarCondicoes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricaoCondicoesEntrega.Text))
            {
                MessageBox.Show("Por favor, insira a descrição das condições de entrega.");
                return;
            }

            bool sucesso = AdicionarCondicoesNaBaseDeDados(condicoesEntregaId, txtDescricaoCondicoesEntrega.Text);
            if (sucesso)
            {
                MessageBox.Show("Condições de entrega adicionadas com sucesso.");
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao adicionar as condições de entrega.");
            }
        }

        /// <summary>
        /// Adiciona as condições de entrega à base de dados.
        /// </summary>
        /// <param name="condicoesEntregaId">O ID das condições de entrega.</param>
        /// <param name="descricao">A descrição das condições de entrega.</param>
        /// <returns>Retorna <c>true</c> se as condições de entrega foram adicionadas com sucesso; caso contrário, retorna <c>false</c>.</returns>
        private bool AdicionarCondicoesNaBaseDeDados(int condicoesEntregaId, string descricao)
        {
            string connectionString = "Data Source=FERNANDEES;Initial Catalog=AluguerAutomoveis;Integrated Security=True;";

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    
                    var query = @"
            SET IDENTITY_INSERT CondicoesEntrega ON;
            INSERT INTO CondicoesEntrega (CondicoesEntregaId, DescCondEntrega) 
            VALUES (@CondicoesEntregaId, @Descricao);
            SET IDENTITY_INSERT CondicoesEntrega OFF;";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        
                        cmd.Parameters.AddWithValue("@CondicoesEntregaId", condicoesEntregaId);
                        cmd.Parameters.AddWithValue("@Descricao", descricao);

                        
                        cmd.ExecuteNonQuery();
                    }

                    return true; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao adicionar condições de entrega: {ex.Message}");
                    return false; 
                }
            }
        }

        /// <summary>
        /// Evento disparado quando o rótulo 2 é clicado (ainda não utilizado).
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void label2_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}

