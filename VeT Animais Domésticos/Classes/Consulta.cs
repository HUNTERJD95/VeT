using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace VeT_Animais_Domésticos.Classes
{
    public class Consulta
    {
        public int Id { get; set; }
        public int IdDono { get; set; }
        public int IdAnimal { get; set; }
        public int IdColaborador { get; set; }
        public string Telemovel { get; set; }
        public DateTime DataConsulta { get; set; }
        public DateTime HoraConsulta { get; set; }

        public Consulta(int idDono, int idAnimal, int idColaborador, string telemovel, DateTime dataConsulta, DateTime horaConsulta)
        {
            IdDono = idDono;
            IdAnimal = idAnimal;
            IdColaborador = idColaborador;
            Telemovel = telemovel;
            DataConsulta = dataConsulta;
            HoraConsulta = horaConsulta;
        }

        public Consulta(int id, int idDono, int idAnimal, int idColaborador, string telemovel, DateTime dataConsulta, DateTime horaConsulta)
        {
            Id = id;
            IdDono = idDono;
            IdAnimal = idAnimal;
            IdColaborador = idColaborador;
            Telemovel = telemovel;
            DataConsulta = dataConsulta;
            HoraConsulta = horaConsulta;
        }

        public static void InserirConsulta(Consulta consulta)
        {
            string query = "INSERT INTO Consultas (id_dono, id_animal, id_colaborador, telemovel, data_consulta, hora_consulta) " +
                "VALUES (@IdDono, @IdAnimal, @IdColaborador, @Telemovel, @DataConsulta, @HoraConsulta)";

            using (SqlConnection connection = new SqlConnection(ConexaoBD.conexao))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdDono", consulta.IdDono);
                    command.Parameters.AddWithValue("@IdAnimal", consulta.IdAnimal);
                    command.Parameters.AddWithValue("@IdColaborador", consulta.IdColaborador);
                    command.Parameters.AddWithValue("@Telemovel", consulta.Telemovel);
                    command.Parameters.AddWithValue("@DataConsulta", consulta.DataConsulta);
                    command.Parameters.AddWithValue("@HoraConsulta", consulta.HoraConsulta);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AtualizarConsulta(Consulta consulta)
        {
            string query = "UPDATE Consultas SET id_dono = @IdDono, id_animal = @IdAnimal, id_colaborador = @IdColaborador, " +
                "telemovel = @Telemovel, data_consulta = @DataConsulta, hora_consulta = @HoraConsulta WHERE id = @Id";

            using (SqlConnection connection = new SqlConnection(ConexaoBD.conexao))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdDono", consulta.IdDono);
                    command.Parameters.AddWithValue("@IdAnimal", consulta.IdAnimal);
                    command.Parameters.AddWithValue("@IdColaborador", consulta.IdColaborador);
                    command.Parameters.AddWithValue("@Telemovel", consulta.Telemovel);
                    command.Parameters.AddWithValue("@DataConsulta", consulta.DataConsulta);
                    command.Parameters.AddWithValue("@HoraConsulta", consulta.HoraConsulta);
                    command.Parameters.AddWithValue("@Id", consulta.Id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EliminarConsulta(int id)
        {
            string query = "DELETE FROM Consultas WHERE id = @Id";

            using (SqlConnection connection = new SqlConnection(ConexaoBD.conexao))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<Consulta> ListarConsultas()
        {
            List<Consulta> consultas = new List<Consulta>();

            string query = "SELECT id, id_dono, id_animal, id_colaborador, telemovel, data_consulta, hora_consulta FROM Consultas";

            using (SqlConnection connection = new SqlConnection(ConexaoBD.conexao))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["id"];
                            int idDono = (int)reader["id_dono"];
                            int idAnimal = (int)reader["id_animal"];
                            int idColaborador = (int)reader["id_colaborador"];
                            string telemovel = (string)reader["telemovel"];
                            DateTime dataConsulta = (DateTime)reader["data_consulta"];
                            DateTime horaConsulta = (DateTime)reader["hora_consulta"];

                            Consulta consulta = new Consulta(id, idDono, idAnimal, idColaborador, telemovel, dataConsulta, horaConsulta);
                            consultas.Add(consulta);
                        }
                    }
                }
            }

            return consultas;
        }

        public static List<Consulta> ListarConsultasDeHoje()
        {
              List<Consulta> consultas = new List<Consulta>();

            string query = "SELECT id, id_dono, id_animal, id_colaborador, telemovel, data_consulta, hora_consulta FROM Consultas " +
                "WHERE CAST(data_consulta AS DATE) = CAST(GETDATE() AS DATE)";

            using (SqlConnection connection = new SqlConnection(ConexaoBD.conexao))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // command.Parameters.AddWithValue("@DataConsulta", DateTime.Today.Date);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["id"];
                            int idDono = (int)reader["id_dono"];
                            int idAnimal = (int)reader["id_animal"];
                            int idColaborador = (int)reader["id_colaborador"];
                            string telemovel = (string)reader["telemovel"];
                            DateTime dataConsulta = (DateTime)reader["data_consulta"];
                            DateTime horaConsulta = (DateTime)reader["hora_consulta"];

                            Consulta consulta = new Consulta(id, idDono, idAnimal, idColaborador, telemovel, dataConsulta, horaConsulta);
                            consultas.Add(consulta);
                        }
                    }
                }
            }

            return consultas;   
        }
    }
}