using AluguerAutomoveis.Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AluguerAutomoveis.Repositorios
{
    /// <summary>
    /// Classe responsável pela gestão de condutores no repositório de dados.
    /// </summary>
    public class CondutorRepositorio
    {
        #region Atributos

        /// <summary>
        /// String de conexão com o banco de dados.
        /// </summary>
        string connectionString = "Data Source=FERNANDEES;Initial Catalog=AluguerAutomoveis;Integrated Security=True;";

        #endregion

        #region Metodos

        /// <summary>
        /// Verifica se uma organização existe na base de dados.
        /// </summary>
        /// <param name="organizacaoId">ID da organização a verificar.</param>
        /// <param name="connection">Conexão com o banco de dados.</param>
        /// <returns>Retorna true se a organização existir, false caso contrário.</returns>
        private bool VerificarOrganizacao(int organizacaoId, SqlConnection connection)
        {
            var checkOrganizacao = new SqlCommand("SELECT COUNT(*) FROM Organizacao WHERE OrganizacaoId = @OrganizacaoId", connection);
            checkOrganizacao.Parameters.AddWithValue("@OrganizacaoId", organizacaoId);
            int organizacaoExists = (int)checkOrganizacao.ExecuteScalar();
            return organizacaoExists > 0;
        }

        /// <summary>
        /// Cria uma nova organização se não existir.
        /// </summary>
        /// <param name="organizacaoId">ID da organização.</param>
        /// <returns>Retorna true se a organização for criada com sucesso, false caso contrário.</returns>
        private bool CriarNovaOrganizacao(int organizacaoId)
        {
            using (var formNovaOrganizacao = new FormNovaOrganizacao(organizacaoId))
            {
                var result = formNovaOrganizacao.ShowDialog();
                if (result != DialogResult.OK)
                {
                    MessageBox.Show("Organização não foi criada. Operação cancelada.");
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Verifica se o código postal existe na base de dados.
        /// </summary>
        /// <param name="cp">Código postal a verificar.</param>
        /// <param name="connection">Conexão com o banco de dados.</param>
        /// <returns>Retorna true se o código postal existir, false caso contrário.</returns>
        private bool VerificarCodigoPostal(string cp, SqlConnection connection)
        {
            var checkCP = new SqlCommand("SELECT COUNT(*) FROM CPostal WHERE CP = @CP", connection);
            checkCP.Parameters.AddWithValue("@CP", cp);
            int count = (int)checkCP.ExecuteScalar();
            return count > 0;
        }

        /// <summary>
        /// Insere um novo código postal na base de dados.
        /// </summary>
        /// <param name="cp">Código postal a ser inserido.</param>
        /// <param name="connection">Conexão com o banco de dados.</param>
        private void InserirCodigoPostal(string cp, SqlConnection connection)
        {
            var insertCPostal = new SqlCommand("INSERT INTO CPostal (CP) VALUES (@CP)", connection);
            insertCPostal.Parameters.AddWithValue("@CP", cp);
            insertCPostal.ExecuteNonQuery();
        }

        /// <summary>
        /// Insere um novo condutor na tabela Condutor da base de dados.
        /// </summary>
        /// <param name="condutor">Objeto Condutor a ser inserido.</param>
        /// <param name="connection">Conexão com o banco de dados.</param>
        private void InserirCondutorNaTabela(Condutor condutor, SqlConnection connection)
        {
            var cmd = new SqlCommand("INSERT INTO Condutor (NomeCondutor, Rua, DocIdentificacao, DataNasc, TituloCondutor, CartaoMB, TipoClienteId, CP, OrganizacaoId) VALUES (@NomeCondutor, @Rua, @DocIdentificacao, @DataNasc, @TituloCondutor, @CartaoMB, @TipoClienteId, @CP, @OrganizacaoId)", connection);
            cmd.Parameters.AddWithValue("@NomeCondutor", condutor.NomeCondutor);
            cmd.Parameters.AddWithValue("@Rua", condutor.Rua);
            cmd.Parameters.AddWithValue("@DocIdentificacao", condutor.DocIdentificacao);
            cmd.Parameters.AddWithValue("@DataNasc", condutor.DataNasc);
            cmd.Parameters.AddWithValue("@TituloCondutor", condutor.TituloCondutor);
            cmd.Parameters.AddWithValue("@CartaoMB", condutor.CartaoMB);
            cmd.Parameters.AddWithValue("@TipoClienteId", condutor.TipoClienteId);
            cmd.Parameters.AddWithValue("@CP", condutor.CP);

            if (condutor.OrganizacaoId == 0)
            {
                cmd.Parameters.AddWithValue("@OrganizacaoId", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@OrganizacaoId", condutor.OrganizacaoId);
            }

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Insere um novo condutor na base de dados.
        /// </summary>
        /// <param name="condutor">Objeto Condutor a ser inserido.</param>
        /// <returns>Retorna true se o condutor for inserido com sucesso, false caso contrário.</returns>
        public bool InserirCondutor(Condutor condutor)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (condutor.OrganizacaoId > 0 && !VerificarOrganizacao(condutor.OrganizacaoId, connection))
                {
                    if (!CriarNovaOrganizacao(condutor.OrganizacaoId))
                    {
                        return false;
                    }
                }

                if (!VerificarCodigoPostal(condutor.CP, connection))
                {
                    InserirCodigoPostal(condutor.CP, connection);
                }

                InserirCondutorNaTabela(condutor, connection);
            }
            return true;
        }

        /// <summary>
        /// Atualiza um atributo de um condutor.
        /// </summary>
        /// <param name="condutor">Objeto Condutor a ser atualizado.</param>
        /// <param name="atributo">Nome do atributo a ser atualizado.</param>
        /// <param name="novoValor">Novo valor a ser atribuído ao atributo.</param>
        public void AtualizarAtributo(Condutor condutor, string atributo, string novoValor)
        {
            switch (atributo)
            {
                case "Nome":
                    condutor.NomeCondutor = novoValor;
                    break;
                case "Rua":
                    condutor.Rua = novoValor;
                    break;
                case "DocIdentificacao":
                    condutor.DocIdentificacao = novoValor;
                    break;
                case "DataNasc":
                    condutor.DataNasc = DateTime.Parse(novoValor);
                    break;
                case "TituloCondutor":
                    condutor.TituloCondutor = novoValor;
                    break;
                case "CartaoMB":
                    condutor.CartaoMB = Convert.ToInt32(novoValor);
                    break;
                case "TipoClienteId":
                    condutor.TipoClienteId = Convert.ToInt32(novoValor);
                    break;
                case "CP":
                    condutor.CP = novoValor;
                    break;
                case "OrganizacaoId":
                    condutor.OrganizacaoId = Convert.ToInt32(novoValor);
                    break;
            }
        }

        /// <summary>
        /// Atualiza as informações de um condutor na base de dados.
        /// </summary>
        /// <param name="condutor">Objeto Condutor com as informações atualizadas.</param>
        public void AtualizarCondutor(Condutor condutor)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "UPDATE Condutor SET NomeCondutor = @NomeCondutor, Rua = @Rua, DocIdentificacao = @DocIdentificacao, DataNasc = @DataNasc, TituloCondutor = @TituloCondutor, CartaoMB = @CartaoMB, TipoClienteId = @TipoClienteId, CP = @CP, OrganizacaoId = @OrganizacaoId WHERE CondutorId = @CondutorId";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@NomeCondutor", condutor.NomeCondutor);
                cmd.Parameters.AddWithValue("@Rua", condutor.Rua);
                cmd.Parameters.AddWithValue("@DocIdentificacao", condutor.DocIdentificacao);
                cmd.Parameters.AddWithValue("@DataNasc", condutor.DataNasc);
                cmd.Parameters.AddWithValue("@TituloCondutor", condutor.TituloCondutor);
                cmd.Parameters.AddWithValue("@CartaoMB", condutor.CartaoMB);
                cmd.Parameters.AddWithValue("@TipoClienteId", condutor.TipoClienteId);
                cmd.Parameters.AddWithValue("@CP", condutor.CP);
                cmd.Parameters.AddWithValue("@OrganizacaoId", condutor.OrganizacaoId);
                cmd.Parameters.AddWithValue("@CondutorId", condutor.CondutorId);

                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Elimina um condutor da base de dados.
        /// </summary>
        /// <param name="condutorId">ID do condutor a ser eliminado.</param>
        public void EliminarCondutor(int condutorId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "DELETE FROM Condutor WHERE CondutorId = @CondutorId";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CondutorId", condutorId);

                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Busca um condutor pelo seu ID.
        /// </summary>
        /// <param name="condutorId">ID do condutor a ser buscado.</param>
        /// <returns>Retorna um objeto Condutor se encontrado, caso contrário, retorna null.</returns>
        public Condutor BuscarCondutorPorId(int condutorId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM Condutor WHERE CondutorId = @CondutorId";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CondutorId", condutorId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Condutor condutor = new Condutor();

                        condutor.CondutorId = reader["CondutorId"] != DBNull.Value ? Convert.ToInt32(reader["CondutorId"]) : 0;
                        condutor.NomeCondutor = reader["NomeCondutor"] != DBNull.Value ? reader["NomeCondutor"].ToString() : string.Empty;
                        condutor.Rua = reader["Rua"] != DBNull.Value ? reader["Rua"].ToString() : string.Empty;
                        condutor.DocIdentificacao = reader["DocIdentificacao"] != DBNull.Value ? reader["DocIdentificacao"].ToString() : string.Empty;
                        condutor.DataNasc = reader["DataNasc"] != DBNull.Value ? Convert.ToDateTime(reader["DataNasc"]) : DateTime.MinValue;
                        condutor.TituloCondutor = reader["TituloCondutor"] != DBNull.Value ? reader["TituloCondutor"].ToString() : string.Empty;
                        condutor.CartaoMB = reader["CartaoMB"] != DBNull.Value ? Convert.ToInt32(reader["CartaoMB"]) : 0;
                        condutor.TipoClienteId = reader["TipoClienteId"] != DBNull.Value ? Convert.ToInt32(reader["TipoClienteId"]) : 0;
                        condutor.CP = reader["CP"] != DBNull.Value ? reader["CP"].ToString() : string.Empty;
                        condutor.OrganizacaoId = reader["OrganizacaoId"] != DBNull.Value ? Convert.ToInt32(reader["OrganizacaoId"]) : 0;

                        return condutor;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Busca o ID de um condutor a partir do seu número de documento de identificação.
        /// </summary>
        /// <param name="docIdentificacao">Número do documento de identificação do condutor.</param>
        /// <returns>Retorna o ID do condutor, ou 0 se não for encontrado.</returns>
        public int BuscarCondutorIdPorDocIdentificacao(string docIdentificacao)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT CondutorId FROM Condutor WHERE DocIdentificacao = @DocIdentificacao";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DocIdentificacao", docIdentificacao);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("Condutor não encontrado com esse Documento de Identificação.");
                    return 0;
                }
            }
        }

        #endregion
    }
}


