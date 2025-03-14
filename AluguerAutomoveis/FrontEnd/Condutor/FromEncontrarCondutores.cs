using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace AluguerAutomoveis
{
    /// <summary>
    /// Formulário para buscar condutores com base em critérios como idade e nome da organização.
    /// </summary>
    partial class FormEncontrarCondutores : Form
    {
        #region Atributos

        /// <summary>
        /// String de conexão com a base de dados.
        /// </summary>
        string _connectionString = "Data Source=FERNANDEES;Initial Catalog=AluguerAutomoveis;Integrated Security=True;";

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor padrão do formulário.
        /// </summary>
        public FormEncontrarCondutores()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Evento acionado ao clicar no botão de buscar condutores.
        /// Obtém os valores dos campos de entrada e realiza a consulta na base de dados.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnEncontrarCondutores_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txtIdade.Text);
            string nomeOrganizacao = txtNomeOrganizacao.Text;

            BuscarCondutoresPorIdadeEOrganizacao(idade, nomeOrganizacao);
        }

        /// <summary>
        /// Busca condutores na base de dados com base na idade e nome da organização.
        /// </summary>
        /// <param name="idade">Idade do condutor para o filtro.</param>
        /// <param name="nomeOrganizacao">Nome da organização para o filtro.</param>
        public void BuscarCondutoresPorIdadeEOrganizacao(int idade, string nomeOrganizacao)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("BuscarCondutoresPorIdadeEOrganizacao", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Idade", idade);
                cmd.Parameters.AddWithValue("@NomeOrganizacao", nomeOrganizacao);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCondutores.DataSource = dt;
            }
        }
        #endregion
    }
}
