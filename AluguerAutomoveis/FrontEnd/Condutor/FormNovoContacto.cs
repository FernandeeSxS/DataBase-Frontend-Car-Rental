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
    /// Formulário para adicionar um novo contacto associado a um condutor e organização.
    /// </summary>
    public partial class FormNovoContacto : Form
    {
         #region Atributos

        private int condutorId; 
        private int organizacaoId; 
        private string connectionString = "Data Source=FERNANDEES;Initial Catalog=AluguerAutomoveis;Integrated Security=True;"; 

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor para inicializar o formulário com o ID da organização e o CondutorId.
        /// </summary>
        /// <param name="organizacaoId">ID da organização associada ao contacto.</param>
        /// <param name="condutorId">ID do condutor associado ao contacto.</param>
        public FormNovoContacto(int organizacaoId, int condutorId)
        {
            InitializeComponent();
            this.organizacaoId = organizacaoId;
            this.condutorId = condutorId;  
            txtOrganizacaoId.Text = organizacaoId.ToString();
            txtOrganizacaoId.ReadOnly = true;
            txtCondutorId.Text = condutorId.ToString(); 
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento acionado ao clicar no botão "Guardar" para inserir o contacto no banco de dados.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var organizacaoIdParam = organizacaoId == 0 ? (object)DBNull.Value : organizacaoId;

                var query = "INSERT INTO Contacto (Contact, CondutorId, TipoContactoId, OrganizacaoId) VALUES (@Contact, @CondutorId, @TipoContactoId, @OrganizacaoId)";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@CondutorId", condutorId);
                cmd.Parameters.AddWithValue("@TipoContactoId", txtTipoContactoId.Text);
                cmd.Parameters.AddWithValue("@OrganizacaoId", organizacaoIdParam);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Contacto adicionado com sucesso!");

                    var result = MessageBox.Show("Deseja adicionar outro contacto?", "Adicionar mais contactos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        FormNovoContacto novoContactoForm = new FormNovoContacto(organizacaoId,condutorId);
                        novoContactoForm.ShowDialog();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao adicionar contacto: {ex.Message}");
                }
            }
        }


        /// <summary>
        /// Evento acionado ao clicar no rótulo do Tipo de Contacto.
        /// Este evento atualmente não possui implementação.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void lblTipoContacto_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
