using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AluguerAutomoveis.Negocio;
using AluguerAutomoveis.Models;
using System.Data.SqlClient;

namespace AluguerAutomoveis.FrontEnd
{
    /// <summary>
    /// Formulário responsável por inserir novos condutores no sistema e exibir a lista de condutores existentes.
    /// </summary>
    public partial class FormInserirCondutor : Form
    {
        #region Construtor

        /// <summary>
        /// Construtor da classe `FormInserirCondutor`, inicializa o formulário e seus componentes.
        /// </summary>
        public FormInserirCondutor()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Método para carregar os condutores existentes na base de dados e exibi-los na grid.
        /// </summary>
        private void CarregarCondutores()
        {
            string query = "SELECT CondutorId, NomeCondutor, Rua, DocIdentificacao, DataNasc, TituloCondutor, CartaoMB, TipoClienteId, CP, OrganizacaoId FROM Condutor";
            string connectionString = @"Data Source=FERNANDEES;Initial Catalog=AluguerAutomoveis;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewCondutor.DataSource = dt;
            }
        }

        /// <summary>
        /// Método acionado ao clicar no botão "Adicionar", responsável por inserir um novo condutor.
        /// </summary>
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var condutor = new Condutor
            {
                NomeCondutor = txtNomeCondutor.Text,
                Rua = txtRua.Text,
                DocIdentificacao = txtDocIdentificacao.Text,
                DataNasc = DateTime.Parse(txtDataNasc.Text),
                TituloCondutor = txtTituloCondutor.Text,
                CartaoMB = Convert.ToInt32(txtCartaoMB.Text),
                TipoClienteId = Convert.ToInt32(txtTipoClienteId.Text),
                CP = txtCP.Text,
                OrganizacaoId = Convert.ToInt32(txtOrganizacaoId.Text)
            };

            RegrasCondutores gestaoCondutores = new RegrasCondutores();
            gestaoCondutores.AdicionarCondutor(condutor);

            CarregarCondutores();

            MessageBox.Show("Condutor adicionado com sucesso!");

            int condutorId = gestaoCondutores.BuscarCondutorIdPorDocIdentificacao(condutor.DocIdentificacao);

            var dialogResult = MessageBox.Show("Deseja adicionar um contacto para este condutor?", "Adicionar Contacto", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                FormNovoContacto formContacto = new FormNovoContacto(condutor.OrganizacaoId, condutorId);
                formContacto.ShowDialog();
            }
            else
            {
                this.Close(); 
            }
        }

        /// <summary>
        /// Método acionado quando o formulário é carregado, que carrega os condutores na grid.
        /// </summary>
        private void Form2_Load(object sender, EventArgs e)
        {
            CarregarCondutores();
        }
        #endregion
    }
}
