using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AluguerAutomoveis.Negocio;
using AluguerAutomoveis.Models;

namespace AluguerAutomoveis.FrontEnd
{
    /// <summary>
    /// Formulário para inserir e visualizar reservas.
    /// </summary>
    public partial class FormInserirReserva : Form
    {
        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância de <see cref="FormInserirReserva"/>.
        /// </summary>
        public FormInserirReserva()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Carrega todas as reservas da base de dados e as exibe no DataGridView.
        /// </summary>
        private void CarregarReservas()
        {
            string query = "SELECT ReservaId, DataRes, DataIniAluguer, DataFimAluguer, LocalLev, LocalDev, PrecoDiario, KmPerm, Caucao, CondutorId, OrganizacaoId, TipoExtraId, VeiculoId FROM Reserva";
            string connectionString = @"Data Source=FERNANDEES;Initial Catalog=AluguerAutomoveis;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewReserva.DataSource = dt;
            }
        }

        /// <summary>
        /// Adiciona uma nova reserva com base nos dados inseridos no formulário.
        /// </summary>
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                DataRes = string.IsNullOrEmpty(txtDataRes.Text) ? (DateTime?)null : Convert.ToDateTime(txtDataRes.Text),
                DataIniAluguer = string.IsNullOrEmpty(txtDataIniAluguer.Text) ? (DateTime?)null : Convert.ToDateTime(txtDataIniAluguer.Text),
                DataFimAluguer = string.IsNullOrEmpty(txtDataFimAluguer.Text) ? (DateTime?)null : Convert.ToDateTime(txtDataFimAluguer.Text),
                LocalLev = txtLocalLev.Text,
                LocalDev = txtLocalDev.Text,
                PrecoDiario = string.IsNullOrEmpty(txtPrecoDiario.Text) ? (decimal?)null : Convert.ToDecimal(txtPrecoDiario.Text),
                KmPerm = string.IsNullOrEmpty(txtKmPerm.Text) ? (int?)null : Convert.ToInt32(txtKmPerm.Text),
                Caucao = string.IsNullOrEmpty(txtCaucao.Text) ? (decimal?)null : Convert.ToDecimal(txtCaucao.Text),
                CondutorId = Convert.ToInt32(txtCondutorId.Text),
                OrganizacaoId = Convert.ToInt32(txtOrganizacaoId.Text),
                TipoExtraId = Convert.ToInt32(txtTipoExtraId.Text),
                VeiculoId = Convert.ToInt32(txtVeiculoId.Text)
            };

            RegrasReserva gestaoReservas = new RegrasReserva();
            if (gestaoReservas.AdicionarReserva(reserva))
            {
                CarregarReservas();

                MessageBox.Show("Reserva adicionada com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao adicionar a reserva. Verifique os dados e tente novamente.");
            }
        }

        /// <summary>
        /// Evento acionado ao carregar o formulário.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void FormInserirReserva_Load(object sender, EventArgs e)
        {
            CarregarReservas();
        }
        #endregion
    }
}

