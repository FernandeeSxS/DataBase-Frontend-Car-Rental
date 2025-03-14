using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace AluguerAutomoveis.FrontEnd
{
    /// <summary>
    /// Formulário para adicionar um novo modelo de veículo.
    /// </summary>
    public partial class FormNovoModelo : Form
    {
        #region Atributos

        /// <summary>
        /// O ID do modelo a ser manipulado.
        /// </summary>
        private int modeloId;

        /// <summary>
        /// A string de conexão com a base de dados, utilizada para realizar operações de leitura e escrita.
        /// </summary>
        private string connectionString = "Data Source=FERNANDEES;Initial Catalog=AluguerAutomoveis;Integrated Security=True;";

        #endregion

        #region Métodos

        /// <summary>
        /// Construtor do formulário, inicializa o modelo com o ID fornecido.
        /// </summary>
        /// <param name="modeloId">O ID do modelo a ser associado ao formulário.</param>
        public FormNovoModelo(int modeloId)
        {
            InitializeComponent();
            this.modeloId = modeloId;
            txtModeloId.Text = modeloId.ToString();  
            txtModeloId.ReadOnly = true; 
        }

        /// <summary>
        /// Método chamado quando o botão "Adicionar Modelo" é clicado. Verifica se os dados estão corretos e adiciona o modelo à base de dados.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnAdicionarModelo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricaoModelo.Text))
            {
                MessageBox.Show("Por favor, insira a descrição do modelo.");
                return;
            }

            if (string.IsNullOrEmpty(txtMarcaId.Text) || !int.TryParse(txtMarcaId.Text, out int marcaId) || marcaId <= 0)
            {
                MessageBox.Show("Por favor, insira um ID de Marca válido.");
                return;
            }

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (!VerificarMarca(marcaId, connection))
                {
                    var criarMarca = MessageBox.Show("A marca associada ao modelo não existe. Deseja criar uma nova marca?", "Marca não encontrada", MessageBoxButtons.YesNo);
                    if (criarMarca == DialogResult.Yes)
                    {
                        if (!CriarNovaMarca(marcaId))
                        {
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }

                bool sucesso = AdicionarModeloNaBaseDeDados(modeloId, txtDescricaoModelo.Text, marcaId);
                if (sucesso)
                {
                    MessageBox.Show("Modelo adicionado com sucesso.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao adicionar o modelo.");
                }
            }
        }

        /// <summary>
        /// Adiciona um modelo à base de dados.
        /// </summary>
        /// <param name="modeloId">O ID do modelo.</param>
        /// <param name="descricaoModelo">A descrição do modelo.</param>
        /// <param name="marcaId">O ID da marca associada ao modelo.</param>
        /// <returns>Retorna <c>true</c> se o modelo foi adicionado com sucesso; caso contrário, retorna <c>false</c>.</returns>
        private bool AdicionarModeloNaBaseDeDados(int modeloId, string descricaoModelo, int marcaId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var query = @"
            SET IDENTITY_INSERT Modelo ON;
            INSERT INTO Modelo (ModeloId, DescMod, MarcaId) 
            VALUES (@ModeloId, @DescricaoModelo, @MarcaId);
            SET IDENTITY_INSERT Modelo OFF;";

                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ModeloId", modeloId);  
                cmd.Parameters.AddWithValue("@DescricaoModelo", descricaoModelo);
                cmd.Parameters.AddWithValue("@MarcaId", marcaId);

                try
                {
                    cmd.ExecuteNonQuery();
                    return true; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao adicionar modelo: {ex.Message}");
                    return false;
                }
            }
        }

        /// <summary>
        /// Verifica se a marca associada ao modelo existe na base de dados.
        /// </summary>
        /// <param name="marcaId">O ID da marca a ser verificada.</param>
        /// <param name="connection">A conexão com a base de dados.</param>
        /// <returns>Retorna <c>true</c> se a marca existir, caso contrário, retorna <c>false</c>.</returns>
        private bool VerificarMarca(int marcaId, SqlConnection connection)
        {
            var checkMarca = new SqlCommand("SELECT COUNT(*) FROM Marca WHERE MarcaId = @MarcaId", connection);
            checkMarca.Parameters.AddWithValue("@MarcaId", marcaId);
            int marcaExists = (int)checkMarca.ExecuteScalar();
            return marcaExists > 0;
        }

        /// <summary>
        /// Cria uma nova marca caso a marca associada ao modelo não exista.
        /// </summary>
        /// <param name="marcaId">O ID da marca a ser criada.</param>
        /// <returns>Retorna <c>true</c> se a marca foi criada com sucesso, caso contrário, retorna <c>false</c>.</returns>
        private bool CriarNovaMarca(int marcaId)
        {
            using (var formNovaMarca = new FormNovaMarca(marcaId))
            {
                var result = formNovaMarca.ShowDialog();
                if (result != DialogResult.OK)
                {
                    MessageBox.Show("Marca não foi criada. Operação cancelada.");
                    return false;
                }
            }
            return true;
        }

        #endregion
    }
}


