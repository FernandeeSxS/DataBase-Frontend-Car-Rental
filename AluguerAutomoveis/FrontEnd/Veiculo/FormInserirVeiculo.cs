using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AluguerAutomoveis.Negocio;
using AluguerAutomoveis.Models;

namespace AluguerAutomoveis.FrontEnd
{
    public partial class FormInserirVeiculo : Form
    {
        public FormInserirVeiculo()
        {
            InitializeComponent();
        }

        // Método para carregar os veículos na Grid
        private void CarregarVeiculos()
        {
            // Ajuste o nome da tabela para 'Veiculo'
            string query = "SELECT VeiculoId, Capacidade, KM, NivComb, TipoVeiculoId, ModeloId, CondicoesEntregaId FROM Veiculo";
            string connectionString = @"Data Source=FERNANDEES;Initial Catalog=AluguerAutomoveis;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewVeiculo.DataSource = dt;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Criar o objeto Veiculo com os dados do formulário
            var veiculo = new Veiculo
            {
                Capacidade = string.IsNullOrEmpty(txtCapacidade.Text) ? (int?)null : Convert.ToInt32(txtCapacidade.Text),
                KM = string.IsNullOrEmpty(txtKM.Text) ? (int?)null : Convert.ToInt32(txtKM.Text),
                NivComb = txtNivComb.Text,
                TipoVeiculoId = Convert.ToInt32(txtTipoVeiculoId.Text),
                ModeloId = Convert.ToInt32(txtModeloId.Text),
                CondicoesEntregaId = Convert.ToInt32(txtCondicoesEntregaId.Text)
            };

            RegrasVeiculos gestaoVeiculos = new RegrasVeiculos();
            if (gestaoVeiculos.AdicionarVeiculo(veiculo))
            {
                // Carregar os veículos após a inserção
                CarregarVeiculos();

                // Exibir mensagem informando que o veículo foi adicionado
                MessageBox.Show("Veículo adicionado com sucesso!");
            }
            else
            {
                // Caso a adição falhe
                MessageBox.Show("Erro ao adicionar o veículo. Verifique os dados e tente novamente.");
            }
        }

        private void FormInserirVeiculo_Load(object sender, EventArgs e)
        {
            CarregarVeiculos();
        }
    }
}

