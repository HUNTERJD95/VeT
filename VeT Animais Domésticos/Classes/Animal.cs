using System;
using System.Data.SqlClient;

namespace VeT_Animais_Domésticos.Classes
{
    public class Animal
    {
        public int Id { get; set; }
        public string DonoNIF { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataFalecimento { get; set; }
        public DateTime DataUltimaConsulta { get; set; }
        public string TipoAnimal { get; set; }
        public string Raca { get; set; }
        public string Sexo { get; set; }
        public double Peso { get; set; }
        public string FiliaçãoMãe { get; set; }
        public string FiliaçãoPai { get; set; }
        public bool Ativo { get; set; }

        private static int proximoNumeroRegistro = 1;

        public Animal(string donoNIF, DateTime dataNascimento, string tipoAnimal, string raca, string sexo, double peso)
        {
            DonoNIF = donoNIF;
            DataNascimento = dataNascimento;
            TipoAnimal = tipoAnimal;
            Raca = raca;
            Sexo = sexo;
            Peso = peso;
            Id = proximoNumeroRegistro++;
            Ativo = true;
        }

        // Inserir Animal na BD
        public static void InserirAnimal(string donoNIF, string dataNascimento, string tipoAnimal, string raca, string sexo, double peso)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "INSERT INTO Animais (dono_NIF, data_nascimento, tipo_animal, raca, sexo, peso) VALUES (@DonoNIF, @DataNascimento, @TipoAnimal, @Raca, @Sexo, @Peso)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DonoNIF", donoNIF); // Corrigido para @DonoNIF
                    cmd.Parameters.AddWithValue("@DataNascimento", dataNascimento);
                    cmd.Parameters.AddWithValue("@TipoAnimal", tipoAnimal);
                    cmd.Parameters.AddWithValue("@Raca", raca);
                    cmd.Parameters.AddWithValue("@Sexo", sexo);
                    cmd.Parameters.AddWithValue("@Peso", peso);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Atualizar Animal na BD
        public static void AtualizarAnimal(int id, DateTime dataNascimento, string tipoAnimal, string raca, string sexo, double peso)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "UPDATE Animais SET DataNascimento = @DataNascimento, TipoAnimal = @TipoAnimal, Raca = @Raca, Sexo = @Sexo, Peso = @Peso WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@DataNascimento", dataNascimento);
                    cmd.Parameters.AddWithValue("@TipoAnimal", tipoAnimal);
                    cmd.Parameters.AddWithValue("@Raca", raca);
                    cmd.Parameters.AddWithValue("@Sexo", sexo);
                    cmd.Parameters.AddWithValue("@Peso", peso);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Alterar estado do animal para inativo
        public static void AlterarEstadoAnimal(int id)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "UPDATE Animais SET Ativo = @Ativo WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Ativo", false);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}