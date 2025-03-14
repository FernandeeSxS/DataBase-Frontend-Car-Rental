using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AluguerAutomoveis.FrontEnd
{
    /// <summary>
    /// Formulário para adicionar uma nova marca.
    /// </summary>
    public partial class FormNovaMarca : Form
    {
        #region Atributos

        /// <summary>
        /// O ID da marca a ser manipulada.
        /// </summary>
        int marcaId;

        #endregion

        #region Métodos

        /// <summary>
        /// Construtor do formulário, inicializa o formulário com o ID da marca fornecido.
        /// </summary>
        /// <param name="marcaId">O ID da marca a ser associado ao formulário.</param>
        public FormNovaMarca(int marcaId)
        {
            InitializeComponent();
            this.marcaId = marcaId;
            txtMarcaId.Text = marcaId.ToString();
            txtMarcaId.ReadOnly = true;
        }

        /// <summary>
        /// Método chamado quando o botão "Adicionar Marca" é clicado. Verifica se os dados estão corretos e adiciona a marca à base de dados.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnAdicionarMarca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricaoMarca.Text))
            {
                MessageBox.Show("Por favor, insira a descrição da marca.");
                return;
            }

            bool sucesso = AdicionarMarcaNaBaseDeDados(marcaId, txtDescricaoMarca.Text);
            if (sucesso)
            {
                MessageBox.Show("Marca adicionada com sucesso.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao adicionar a marca.");
            }
        }

        /// <summary>
        /// Adiciona a marca à base de dados.
        /// </summary>
        /// <param name="marcaId">O ID da marca.</param>
        /// <param name="descricao">A descrição da marca.</param>
        /// <returns>Retorna <c>true</c> se a marca foi adicionada com sucesso; caso contrário, retorna <c>false</c>.</returns>
        private bool AdicionarMarcaNaBaseDeDados(int marcaId, string descricao)
        {
            string connectionString = "Data Source=FERNANDEES;Initial Catalog=AluguerAutomoveis;Integrated Security=True;"; // Substitua com sua string de conexão

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    var query = @"
            SET IDENTITY_INSERT Marca ON;
            INSERT INTO Marca (MarcaId, DescM) 
            VALUES (@MarcaId, @Descricao);
            SET IDENTITY_INSERT Marca OFF;";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MarcaId", marcaId);
                        cmd.Parameters.AddWithValue("@Descricao", descricao);

                     
                        cmd.ExecuteNonQuery();
                    }

                    return true; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao adicionar marca: {ex.Message}");
                    return false;
                }
            }
        }

        #endregion
    }
}
