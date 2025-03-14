using AluguerAutomoveis.Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using AluguerAutomoveis.FrontEnd;

namespace AluguerAutomoveis.Repositorios
{
    using System;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    /// <summary>
    /// Repositório responsável pela manipulação de dados relacionados às reservas no sistema.
    /// </summary>
    public class ReservaRepositorio
    {
        #region Atributos

        private string connectionString = "Data Source=FERNANDEES;Initial Catalog=AluguerAutomoveis;Integrated Security=True;";

        #endregion

        #region Metodos

        /// <summary>
        /// Função para inserir uma nova reserva na tabela.
        /// </summary>
        /// <param name="reserva">A reserva a ser inserida.</param>
        /// <param name="connection">A conexão com a base de dados.</param>
        private void InserirReservaNaTabela(Reserva reserva, SqlConnection connection)
        {
            var cmd = new SqlCommand("INSERT INTO Reserva (DataRes, DataIniAluguer, DataFimAluguer, LocalLev, LocalDev, PrecoDiario, KmPerm, Caucao, CondutorId, OrganizacaoId, TipoExtraId, VeiculoId) " +
                                     "VALUES (@DataRes, @DataIniAluguer, @DataFimAluguer, @LocalLev, @LocalDev, @PrecoDiario, @KmPerm, @Caucao, @CondutorId, @OrganizacaoId, @TipoExtraId, @VeiculoId)", connection);
            cmd.Parameters.AddWithValue("@DataRes", reserva.DataRes ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@DataIniAluguer", reserva.DataIniAluguer ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@DataFimAluguer", reserva.DataFimAluguer ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@LocalLev", reserva.LocalLev ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@LocalDev", reserva.LocalDev ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@PrecoDiario", reserva.PrecoDiario ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@KmPerm", reserva.KmPerm ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Caucao", reserva.Caucao ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@CondutorId", reserva.CondutorId ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@TipoExtraId", reserva.TipoExtraId ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@VeiculoId", reserva.VeiculoId ?? (object)DBNull.Value);

            if (reserva.OrganizacaoId == 0)
            {
                cmd.Parameters.AddWithValue("@OrganizacaoId", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@OrganizacaoId", reserva.OrganizacaoId);
            }

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Função para adicionar uma nova reserva.
        /// </summary>
        /// <param name="reserva">A reserva a ser adicionada.</param>
        /// <returns>Retorna true se a reserva for adicionada com sucesso, false caso contrário.</returns>
        public bool AdicionarReserva(Reserva reserva)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (reserva.TipoExtraId.HasValue && reserva.TipoExtraId.Value > 0 && !VerificarTipoExtra(reserva.TipoExtraId.Value, connection))
                {
                    if (!CriarNovoTipoExtra(reserva.TipoExtraId.Value))
                    {
                        return false; 
                    }
                }

                InserirReservaNaTabela(reserva, connection);
            }
            return true;
        }

        /// <summary>
        /// Função para verificar se o TipoExtra existe na base de dados.
        /// </summary>
        /// <param name="tipoExtraId">O ID do tipo extra a ser verificado.</param>
        /// <param name="connection">A conexão com a base de dados.</param>
        /// <returns>Retorna true se o TipoExtra existir, false caso contrário.</returns>
        private bool VerificarTipoExtra(int tipoExtraId, SqlConnection connection)
        {
            var cmd = new SqlCommand("SELECT COUNT(1) FROM TipoExtra WHERE TipoExtraId = @TipoExtraId", connection);
            cmd.Parameters.AddWithValue("@TipoExtraId", tipoExtraId);
            return (int)cmd.ExecuteScalar() > 0; 
        }

        /// <summary>
        /// Função para criar um novo tipo extra.
        /// </summary>
        /// <param name="tipoExtraId">O ID do tipo extra a ser criado.</param>
        /// <returns>Retorna true se o tipo extra for criado com sucesso, false caso contrário.</returns>
        private bool CriarNovoTipoExtra(int tipoExtraId)
        {
            using (var formNovoTipoExtra = new FormNovoTipoExtra(tipoExtraId)) 
            {
                var result = formNovoTipoExtra.ShowDialog();
                if (result != DialogResult.OK)
                {
                    MessageBox.Show("Tipo Extra não foi criado. Operação cancelada.");
                    return false; 
                }
            }
            return true;
        }

        /// <summary>
        /// Função para atualizar um atributo de uma reserva.
        /// </summary>
        /// <param name="reserva">A reserva a ser atualizada.</param>
        /// <param name="atributo">O nome do atributo a ser atualizado.</param>
        /// <param name="novoValor">O novo valor do atributo.</param>
        public void AtualizarAtributo(Reserva reserva, string atributo, string novoValor)
        {
            switch (atributo)
            {
                case "DataRes":
                    reserva.DataRes = Convert.ToDateTime(novoValor);
                    break;
                case "DataIniAluguer":
                    reserva.DataIniAluguer = Convert.ToDateTime(novoValor);
                    break;
                case "DataFimAluguer":
                    reserva.DataFimAluguer = Convert.ToDateTime(novoValor);
                    break;
                case "LocalLev":
                    reserva.LocalLev = novoValor;
                    break;
                case "LocalDev":
                    reserva.LocalDev = novoValor;
                    break;
                case "PrecoDiario":
                    reserva.PrecoDiario = Convert.ToDecimal(novoValor);
                    break;
                case "KmPerm":
                    reserva.KmPerm = Convert.ToInt32(novoValor);
                    break;
                case "Caucao":
                    reserva.Caucao = Convert.ToDecimal(novoValor);
                    break;
                case "CondutorId":
                    reserva.CondutorId = Convert.ToInt32(novoValor);
                    break;
                case "OrganizacaoId":
                    reserva.OrganizacaoId = Convert.ToInt32(novoValor);
                    break;
                case "TipoExtraId":
                    reserva.TipoExtraId = Convert.ToInt32(novoValor);
                    break;
                case "VeiculoId":
                    reserva.VeiculoId = Convert.ToInt32(novoValor);
                    break;
            }
        }

        /// <summary>
        /// Função para atualizar uma reserva existente.
        /// </summary>
        /// <param name="reserva">A reserva com os novos dados.</param>
        public void AtualizarReserva(Reserva reserva)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "UPDATE Reserva SET DataRes = @DataRes, DataIniAluguer = @DataIniAluguer, DataFimAluguer = @DataFimAluguer, LocalLev = @LocalLev, " +
                            "LocalDev = @LocalDev, PrecoDiario = @PrecoDiario, KmPerm = @KmPerm, Caucao = @Caucao, CondutorId = @CondutorId, " +
                            "OrganizacaoId = @OrganizacaoId, TipoExtraId = @TipoExtraId, VeiculoId = @VeiculoId WHERE ReservaId = @ReservaId";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DataRes", reserva.DataRes);
                cmd.Parameters.AddWithValue("@DataIniAluguer", reserva.DataIniAluguer);
                cmd.Parameters.AddWithValue("@DataFimAluguer", reserva.DataFimAluguer);
                cmd.Parameters.AddWithValue("@LocalLev", reserva.LocalLev);
                cmd.Parameters.AddWithValue("@LocalDev", reserva.LocalDev);
                cmd.Parameters.AddWithValue("@PrecoDiario", reserva.PrecoDiario);
                cmd.Parameters.AddWithValue("@KmPerm", reserva.KmPerm);
                cmd.Parameters.AddWithValue("@Caucao", reserva.Caucao);
                cmd.Parameters.AddWithValue("@CondutorId", reserva.CondutorId);
                cmd.Parameters.AddWithValue("@OrganizacaoId", reserva.OrganizacaoId);
                cmd.Parameters.AddWithValue("@TipoExtraId", reserva.TipoExtraId);
                cmd.Parameters.AddWithValue("@VeiculoId", reserva.VeiculoId);
                cmd.Parameters.AddWithValue("@ReservaId", reserva.ReservaId);

                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Função para eliminar uma reserva.
        /// </summary>
        /// <param name="reservaId">O ID da reserva a ser eliminada.</param>
        public void EliminarReserva(int reservaId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "DELETE FROM Reserva WHERE ReservaId = @ReservaId";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ReservaId", reservaId);

                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Função para buscar uma reserva por ID.
        /// </summary>
        /// <param name="reservaId">O ID da reserva a ser buscada.</param>
        /// <returns>Retorna a reserva correspondente ao ID fornecido ou null caso não exista.</returns>
        public Reserva BuscarReservaPorId(int reservaId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM Reserva WHERE ReservaId = @ReservaId";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ReservaId", reservaId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Reserva reserva = new Reserva();

                        reserva.ReservaId = reader["ReservaId"] != DBNull.Value ? Convert.ToInt32(reader["ReservaId"]) : 0;
                        reserva.DataRes = reader["DataRes"] != DBNull.Value ? Convert.ToDateTime(reader["DataRes"]) : (DateTime?)null;
                        reserva.DataIniAluguer = reader["DataIniAluguer"] != DBNull.Value ? Convert.ToDateTime(reader["DataIniAluguer"]) : (DateTime?)null;
                        reserva.DataFimAluguer = reader["DataFimAluguer"] != DBNull.Value ? Convert.ToDateTime(reader["DataFimAluguer"]) : (DateTime?)null;
                        reserva.LocalLev = reader["LocalLev"] != DBNull.Value ? reader["LocalLev"].ToString() : string.Empty;
                        reserva.LocalDev = reader["LocalDev"] != DBNull.Value ? reader["LocalDev"].ToString() : string.Empty;
                        reserva.PrecoDiario = reader["PrecoDiario"] != DBNull.Value ? Convert.ToDecimal(reader["PrecoDiario"]) : (decimal?)null;
                        reserva.KmPerm = reader["KmPerm"] != DBNull.Value ? Convert.ToInt32(reader["KmPerm"]) : (int?)null;
                        reserva.Caucao = reader["Caucao"] != DBNull.Value ? Convert.ToDecimal(reader["Caucao"]) : (decimal?)null;
                        reserva.CondutorId = reader["CondutorId"] != DBNull.Value ? Convert.ToInt32(reader["CondutorId"]) : (int?)null;
                        reserva.OrganizacaoId = reader["OrganizacaoId"] != DBNull.Value ? Convert.ToInt32(reader["OrganizacaoId"]) : (int?)null;
                        reserva.TipoExtraId = reader["TipoExtraId"] != DBNull.Value ? Convert.ToInt32(reader["TipoExtraId"]) : (int?)null;
                        reserva.VeiculoId = reader["VeiculoId"] != DBNull.Value ? Convert.ToInt32(reader["VeiculoId"]) : (int?)null;

                        return reserva;
                    }
                }
            }
            return null;
        }

        #endregion
    }
}


