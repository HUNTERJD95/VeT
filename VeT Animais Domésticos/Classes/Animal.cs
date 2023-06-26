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
                if (string.IsNullOrEmpty(donoNIF))
                {
                    donoNIF = "1"; // Associar animais sem donos ao cliente com código 1
                }

                using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
                {
                    string query = "INSERT INTO Animais (dono_NIF, data_nascimento, tipo_animal, raca, sexo, peso) VALUES (@donoNIF, @data_nascimento, @tipo_animal, @raca, @sexo, @peso)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@donoNIF", donoNIF);
                    cmd.Parameters.AddWithValue("@data_nascimento", dataNascimento);
                    cmd.Parameters.AddWithValue("@tipo_animal", tipoAnimal);
                    cmd.Parameters.AddWithValue("@raca", raca);
                    cmd.Parameters.AddWithValue("@sexo", sexo);
                    cmd.Parameters.AddWithValue("@peso", peso);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            }


        // Atualizar Animal na BD
        public static void AtualizarAnimal(int id, string donoNIF, string dataNascimento, string tipoAnimal, string raca, string sexo, double peso)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "UPDATE Animais SET dono_NIF = @DonoNIF, data_nascimento = @DataNascimento, tipo_animal = @TipoAnimal, raca = @Raca, sexo = @Sexo, peso = @Peso WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@DonoNIF", donoNIF);
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

        public static List<Animal> ObterAnimaisPorNIFDono(string donoNIF)
        {
            List<Animal> animais = new List<Animal>();

            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "SELECT * FROM Animais WHERE dono_NIF = @donoNIF";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@donoNIF", donoNIF);

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(reader.GetOrdinal("Id"));
                            //DateTime dataNascimento = reader.GetDateTime(reader.GetOrdinal("data_nascimento"));
                            string dataNascimentoStr = reader.GetString(reader.GetOrdinal("data_nascimento"));
                            DateTime dataNascimento = DateTime.Parse(dataNascimentoStr);
                            string tipoAnimal = reader.GetString(reader.GetOrdinal("tipo_animal"));
                            string raca = reader.GetString(reader.GetOrdinal("raca"));
                            string sexo = reader.GetString(reader.GetOrdinal("sexo"));
                            double peso = reader.GetDouble(reader.GetOrdinal("peso"));

                            Animal animal = new Animal(donoNIF, dataNascimento, tipoAnimal, raca, sexo, peso);
                            animal.Id = id;
                            animais.Add(animal);
                        }
                    }
                }
            }

            return animais;
        }

        public static Animal ObterAnimalPorId(int id)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "SELECT * FROM Animais WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string donoNIF = reader.GetString(reader.GetOrdinal("dono_NIF"));
                            DateTime dataNascimento = reader.GetDateTime(reader.GetOrdinal("data_nascimento"));
                            string tipoAnimal = reader.GetString(reader.GetOrdinal("tipo_animal"));
                            string raca = reader.GetString(reader.GetOrdinal("raca"));
                            string sexo = reader.GetString(reader.GetOrdinal("sexo"));
                            double peso = reader.GetDouble(reader.GetOrdinal("peso"));

                            Animal animal = new Animal(donoNIF, dataNascimento, tipoAnimal, raca, sexo, peso);
                            animal.Id = id;
                            animal.DataFalecimento = reader.GetDateTime(reader.GetOrdinal("data_falecimento"));
                            // Preencha outros detalhes do animal que deseja obter

                            return animal;
                        }
                    }
                }
            }

            return null; // Retornar null se o animal não for encontrado com o ID fornecido
        }

        public override string ToString()
        {
            return $"ID: {Id}, DonoNIF: {DonoNIF}, DataNascimento: {DataNascimento}, DataFalecimento: {DataFalecimento}, DataUltimaConsulta: {DataUltimaConsulta}, TipoAnimal: {TipoAnimal}, Raca: {Raca}, Sexo: {Sexo}, Peso: {Peso}, Ativo: {Ativo}";
        }
    }
}