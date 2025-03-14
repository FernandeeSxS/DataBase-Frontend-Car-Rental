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
using AluguerAutomoveis.Models;


namespace AluguerAutomoveis
{
    /// <summary>
    /// Formulário para criar uma nova organização, incluindo a verificação e inserção do código postal associado.
    /// </summary>
    public partial class FormNovaOrganizacao : Form
    {
        #region Atributos

        /// <summary>
        /// ID único da organização a ser criada.
        /// </summary>
        int organizacaoId;

        /// <summary>
        /// String de conexão com o banco de dados para realizar operações no banco de dados `AluguerAutomoveis`.
        /// </summary>
        string connectionString = "Data Source=FERNANDEES;Initial Catalog=AluguerAutomoveis;Integrated Security=True;";

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe `FormNovaOrganizacao`, que recebe o ID da organização a ser criada e inicializa o formulário.
        /// </summary>
        /// <param name="organizacaoId">ID da organização a ser criada.</param>
        public FormNovaOrganizacao(int organizacaoId)
        {
            InitializeComponent();
            this.organizacaoId = organizacaoId;
            txtOrganizacaoId.Text = organizacaoId.ToString(); 
            txtOrganizacaoId.ReadOnly = true;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Método acionado ao clicar no botão "Guardar", que valida e insere a nova organização no banco de dados.
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var cpExistsQuery = "SELECT COUNT(*) FROM CPostal WHERE CP = @CP";
                using (var cpCmd = new SqlCommand(cpExistsQuery, connection))
                {
                    cpCmd.Parameters.AddWithValue("@CP", txtCP.Text);
                    int count = (int)cpCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        var insertCpQuery = "INSERT INTO CPostal (CP) VALUES (@CP)";
                        using (var insertCmd = new SqlCommand(insertCpQuery, connection))
                        {
                            insertCmd.Parameters.AddWithValue("@CP", txtCP.Text);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }

                var query = @"
            SET IDENTITY_INSERT Organizacao ON;
            INSERT INTO Organizacao (OrganizacaoId, NomeOrg, Rua, NIF, RepresentanteOrg, CP) 
            VALUES (@OrganizacaoId, @NomeOrg, @Rua, @NIF, @RepresentanteOrg, @CP);
            SET IDENTITY_INSERT Organizacao OFF;";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@OrganizacaoId", organizacaoId); 
                cmd.Parameters.AddWithValue("@NomeOrg", txtNomeOrg.Text);
                cmd.Parameters.AddWithValue("@Rua", txtRua.Text);
                cmd.Parameters.AddWithValue("@NIF", txtNIF.Text);
                cmd.Parameters.AddWithValue("@RepresentanteOrg", txtRepresentanteOrg.Text);
                cmd.Parameters.AddWithValue("@CP", txtCP.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Organização criada com sucesso!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao criar organização: {ex.Message}");
                }
            }
        }
        #endregion
    }
}
