using AluguerAutomoveis.Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using AluguerAutomoveis.FrontEnd;

namespace AluguerAutomoveis.Repositorios
{
    /// <summary>
    /// Classe responsável pela gestão de veículos no repositório de dados.
    /// </summary>
    public class VeiculoRepositorio
    {
        #region Atributos

        /// <summary>
        /// String de conexão com o banco de dados.
        /// </summary>
        string connectionString = "Data Source=FERNANDEES;Initial Catalog=AluguerAutomoveis;Integrated Security=True;";

        #endregion

        #region Métodos

        /// <summary>
        /// Verifica se um modelo existe na base de dados.
        /// </summary>
        /// <param name="modeloId">ID do modelo a verificar.</param>
        /// <param name="connection">Conexão com o banco de dados.</param>
        /// <returns>Retorna true se o modelo existir, false caso contrário.</returns>
        private bool VerificarModelo(int modeloId, SqlConnection connection)
        {
            var checkModelo = new SqlCommand("SELECT COUNT(*) FROM Modelo WHERE ModeloId = @ModeloId", connection);
            checkModelo.Parameters.AddWithValue("@ModeloId", modeloId);
            int modeloExists = (int)checkModelo.ExecuteScalar();
            return modeloExists > 0;
        }

        /// <summary>
        /// Cria um novo modelo se não existir.
        /// </summary>
        /// <param name="modeloId">ID do modelo.</param>
        /// <returns>Retorna true se o modelo for criado com sucesso, false caso contrário.</returns>
        private bool CriarNovoModelo(int modeloId)
        {
            using (var formNovoModelo = new FormNovoModelo(modeloId))
            {
                var result = formNovoModelo.ShowDialog();
                if (result != DialogResult.OK)
                {
                    MessageBox.Show("Modelo não foi criado. Operação cancelada.");
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Verifica se as condições de entrega existem na base de dados.
        /// </summary>
        /// <param name="condicaoId">ID da condição de entrega a verificar.</param>
        /// <param name="connection">Conexão com o banco de dados.</param>
        /// <returns>Retorna true se a condição de entrega existir, false caso contrário.</returns>
        private bool VerificarCondicaoDeEntrega(int condicaoId, SqlConnection connection)
        {
            var checkCondicao = new SqlCommand("SELECT COUNT(*) FROM CondicoesEntrega WHERE CondicoesEntregaId = @CondicaoId", connection);
            checkCondicao.Parameters.AddWithValue("@CondicaoId", condicaoId);
            int condicaoExists = (int)checkCondicao.ExecuteScalar();
            return condicaoExists > 0;
        }

        /// <summary>
        /// Insere um novo veículo na tabela de veículos.
        /// </summary>
        /// <param name="veiculo">Objeto Veículo a ser inserido.</param>
        /// <param name="connection">Conexão com o banco de dados.</param>
        private void InserirVeiculoNaTabela(Veiculo veiculo, SqlConnection connection)
        {
            var cmd = new SqlCommand("INSERT INTO Veiculo (Capacidade, KM, NivComb, TipoVeiculoId, ModeloId, CondicoesEntregaId) VALUES (@Capacidade, @KM, @NivComb, @TipoVeiculoId, @ModeloId, @CondicoesEntregaId)", connection);
            cmd.Parameters.AddWithValue("@Capacidade", veiculo.Capacidade ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@KM", veiculo.KM ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@NivComb", veiculo.NivComb);
            cmd.Parameters.AddWithValue("@TipoVeiculoId", veiculo.TipoVeiculoId ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ModeloId", veiculo.ModeloId ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@CondicoesEntregaId", veiculo.CondicoesEntregaId ?? (object)DBNull.Value);

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Adiciona um novo veículo no repositório.
        /// </summary>
        /// <param name="veiculo">Objeto Veículo a ser adicionado.</param>
        /// <returns>Retorna true se o veículo for adicionado com sucesso, false caso contrário.</returns>
        public bool AdicionarVeiculo(Veiculo veiculo)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (veiculo != null && veiculo.ModeloId.HasValue && veiculo.ModeloId.Value > 0 && !VerificarModelo(veiculo.ModeloId.Value, connection))
                {
                    if (!CriarNovoModelo(veiculo.ModeloId.Value))
                    {
                        return false;
                    }
                }

                if (veiculo.CondicoesEntregaId.HasValue && veiculo.CondicoesEntregaId.Value > 0 && !VerificarCondicaoDeEntrega(veiculo.CondicoesEntregaId.Value, connection))
                {
                    var formNovasCondicoes = new FormNovasCondicoes(veiculo.CondicoesEntregaId.Value);
                    var result = formNovasCondicoes.ShowDialog();
                    if (result != DialogResult.OK)
                    {
                        MessageBox.Show("Condições de entrega não foram criadas. Operação cancelada.");
                        return false;
                    }
                }

                InserirVeiculoNaTabela(veiculo, connection);
            }
            return true;
        }

        /// <summary>
        /// Atualiza um atributo específico de um veículo.
        /// </summary>
        /// <param name="veiculo">Objeto Veículo a ser atualizado.</param>
        /// <param name="atributo">Atributo a ser atualizado (ex: "Capacidade", "KM").</param>
        /// <param name="novoValor">Novo valor para o atributo.</param>
        public void AtualizarAtributo(Veiculo veiculo, string atributo, string novoValor)
        {
            switch (atributo)
            {
                case "Capacidade":
                    veiculo.Capacidade = Convert.ToInt32(novoValor);
                    break;
                case "KM":
                    veiculo.KM = Convert.ToInt32(novoValor);
                    break;
                case "NivComb":
                    veiculo.NivComb = novoValor;
                    break;
                case "TipoVeiculoId":
                    veiculo.TipoVeiculoId = Convert.ToInt32(novoValor);
                    break;
                case "ModeloId":
                    veiculo.ModeloId = Convert.ToInt32(novoValor);
                    break;
                case "CondicoesEntregaId":
                    veiculo.CondicoesEntregaId = Convert.ToInt32(novoValor);
                    break;
            }
        }

        /// <summary>
        /// Atualiza as informações de um veículo no repositório.
        /// </summary>
        /// <param name="veiculo">Objeto Veículo com os novos dados.</param>
        public void AtualizarVeiculo(Veiculo veiculo)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "UPDATE Veiculo SET Capacidade = @Capacidade, KM = @KM, NivComb = @NivComb, TipoVeiculoId = @TipoVeiculoId, ModeloId = @ModeloId, CondicoesEntregaId = @CondicoesEntregaId WHERE VeiculoId = @VeiculoId";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Capacidade", veiculo.Capacidade);
                cmd.Parameters.AddWithValue("@KM", veiculo.KM);
                cmd.Parameters.AddWithValue("@NivComb", veiculo.NivComb);
                cmd.Parameters.AddWithValue("@TipoVeiculoId", veiculo.TipoVeiculoId);
                cmd.Parameters.AddWithValue("@ModeloId", veiculo.ModeloId);
                cmd.Parameters.AddWithValue("@CondicoesEntregaId", veiculo.CondicoesEntregaId);
                cmd.Parameters.AddWithValue("@VeiculoId", veiculo.VeiculoId); // O VeiculoId não pode ser alterado, é apenas utilizado para identificar o veículo

                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Elimina um veículo do repositório.
        /// </summary>
        /// <param name="veiculoId">ID do veículo a ser eliminado.</param>
        public void EliminarVeiculo(int veiculoId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "DELETE FROM Veiculo WHERE VeiculoId = @VeiculoId";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@VeiculoId", veiculoId);

                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Busca um veículo pelo seu ID no repositório.
        /// </summary>
        /// <param name="veiculoId">ID do veículo a ser buscado.</param>
        /// <returns>Retorna o objeto Veículo correspondente ao ID ou null se não encontrado.</returns>
        public Veiculo BuscarVeiculoPorId(int veiculoId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM Veiculo WHERE VeiculoId = @VeiculoId";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@VeiculoId", veiculoId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Veiculo veiculo = new Veiculo();

                        veiculo.VeiculoId = reader["VeiculoId"] != DBNull.Value ? Convert.ToInt32(reader["VeiculoId"]) : 0;
                        veiculo.Capacidade = reader["Capacidade"] != DBNull.Value ? Convert.ToInt32(reader["Capacidade"]) : 0;
                        veiculo.KM = reader["KM"] != DBNull.Value ? Convert.ToInt32(reader["KM"]) : 0;
                        veiculo.NivComb = reader["NivComb"] != DBNull.Value ? reader["NivComb"].ToString() : string.Empty;
                        veiculo.TipoVeiculoId = reader["TipoVeiculoId"] != DBNull.Value ? Convert.ToInt32(reader["TipoVeiculoId"]) : 0;
                        veiculo.ModeloId = reader["ModeloId"] != DBNull.Value ? Convert.ToInt32(reader["ModeloId"]) : 0;
                        veiculo.CondicoesEntregaId = reader["CondicoesEntregaId"] != DBNull.Value ? Convert.ToInt32(reader["CondicoesEntregaId"]) : 0;

                        return veiculo;
                    }
                }
            }
            return null;
        }

        #endregion
    }
}





