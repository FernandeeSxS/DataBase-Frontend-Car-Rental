using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace AluguerAutomoveis.FrontEnd
{
    public partial class FormNovoTipoExtra : Form
    {
        private int tipoExtraId;
        private string connectionString = "Data Source=FERNANDEES;Initial Catalog=AluguerAutomoveis;Integrated Security=True;";

        public FormNovoTipoExtra(int tipoExtraId)
        {
            InitializeComponent();
            this.tipoExtraId = tipoExtraId;
            txtTipoExtraId.Text = tipoExtraId.ToString();  // Exibe o TipoExtraId
            txtTipoExtraId.ReadOnly = true;  // Impede a edição do TipoExtraId
        }

        private void btnAdicionarTipoExtra_Click(object sender, EventArgs e)
        {
            // Verificar se o campo de descrição foi preenchido
            if (string.IsNullOrEmpty(txtDescricaoTipoExtra.Text))
            {
                MessageBox.Show("Por favor, insira a descrição do tipo extra.");
                return;
            }

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Adicionar o tipo extra na base de dados
                bool sucesso = AdicionarTipoExtraNaBaseDeDados(tipoExtraId, txtDescricaoTipoExtra.Text);
                if (sucesso)
                {
                    MessageBox.Show("Tipo Extra adicionado com sucesso.");
                    this.DialogResult = DialogResult.OK; // Indica que o formulário foi fechado com sucesso
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao adicionar o tipo extra.");
                }
            }
        }

        private bool AdicionarTipoExtraNaBaseDeDados(int tipoExtraId, string descricaoTipoExtra)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Lógica para adicionar o novo tipo extra na base de dados
                var query = @"
                SET IDENTITY_INSERT TipoExtra ON;
                INSERT INTO TipoExtra (TipoExtraId, DescTipoExtra) 
                VALUES (@TipoExtraId, @DescricaoTipoExtra);
                SET IDENTITY_INSERT TipoExtra OFF;";

                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TipoExtraId", tipoExtraId);  // Usando o tipoExtraId fornecido
                cmd.Parameters.AddWithValue("@DescricaoTipoExtra", descricaoTipoExtra);

                try
                {
                    cmd.ExecuteNonQuery();
                    return true; // Sucesso na inserção
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao adicionar tipo extra: {ex.Message}");
                    return false; // Falha ao inserir o tipo extra
                }
            }
        }
    }
}


