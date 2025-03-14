using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluguerAutomoveis
{
    /// <summary>
    /// Formulário responsável por buscar condutores com uma idade mínima especificada e da organização indicada.
    /// </summary>
    partial class FormEncontrarCondutoresPorIdadeMinima : Form
    {
        #region Atributos

        /// <summary>
        /// String de conexão com o banco de dados.
        /// </summary>
        string _connectionString = "Data Source=FERNANDEES;Initial Catalog=AluguerAutomoveis;Integrated Security=True;";

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe `FormEncontrarCondutoresPorIdadeMinima`, inicializa o formulário e seus componentes.
        /// </summary>
        public FormEncontrarCondutoresPorIdadeMinima()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Método acionado ao clicar no botão "Buscar Condutores", que chama o método para buscar condutores com base na idade mínima e organização fornecidos.
        /// </summary>
        private void btnEncontrarCondutores_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txtIdade.Text); 
            string nomeOrganizacao = txtNomeOrganizacao.Text;  

            BuscarCondutoresComMaisDeIdade(idade, nomeOrganizacao);
        }

        /// <summary>
        /// Método para buscar condutores com mais de uma idade mínima e pertencentes a uma organização específica.
        /// </summary>
        /// <param name="idade">Idade mínima para o filtro.</param>
        /// <param name="nomeOrganizacao">Nome da organização para filtrar os condutores.</param>
        public void BuscarCondutoresComMaisDeIdade(int idade, string nomeOrganizacao)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                SELECT Condutor.NomeCondutor, Condutor.DataNasc, Organizacao.NomeOrg
                FROM Condutor
                JOIN Organizacao ON Condutor.OrganizacaoId = Organizacao.OrganizacaoId
                WHERE DATEDIFF(YEAR, Condutor.DataNasc, GETDATE()) > @Idade
                AND Organizacao.NomeOrg = @NomeOrganizacao;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;  

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
