using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace VeT_Animais_Domésticos.Classes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NIF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telemovel { get; set; }
        public int NumeroCliente { get; set; }

        private static int proximoNumeroCliente = 1;

        public Cliente(string nome, DateTime dataNascimento,string nif, string telemovel)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            NIF = nif;
            Telemovel = telemovel;
            NumeroCliente = proximoNumeroCliente++;
        }
        



        // Inserir Cliente na BD
        public static void InserirCliente(string nome, string nif, DateTime dataNascimento, string telemovel)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "INSERT INTO Clientes (Nome, NIF, DataNascimento, Telemovel) VALUES (@Nome, @NIF, @DataNascimento, @Telemovel)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@NIF", nif);
                    cmd.Parameters.AddWithValue("@DataNascimento", dataNascimento);
                    cmd.Parameters.AddWithValue("@Telemovel", telemovel);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Atualizar Cliente na BD
               public static void AtualizarCliente(int Id, string nome, string nif, DateTime dataNascimento, string telemovel)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "UPDATE Clientes SET Nome = @Nome, DataNascimento = @DataNascimento, Telemovel = @Telemovel, NIF = @NIF WHERE Id = @ID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", Id);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@NIF", nif);
                    cmd.Parameters.AddWithValue("@DataNascimento", dataNascimento);
                    cmd.Parameters.AddWithValue("@Telemovel", telemovel);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // verifica em loop dentro do input se cada caracter é uma letra ou se contém um "espaço"
        public static bool ValidarNome(string nome)
        {
            if (string.IsNullOrEmpty(nome)) { return false; }
            return nome.All(c => char.IsLetter(c) || c == ' ');
        }

        // Validação de NIF
        public static bool ValidarNIF(string nif)
        {
            return (nif == "1" || (!string.IsNullOrEmpty(nif) && nif.Length == 9));
        }

        //Verifica se nº telemóvel são apenas números
        public static string? ValidarTelemovel(string telemovel)
        {
            if (!string.IsNullOrEmpty(telemovel) && telemovel.All(char.IsDigit))
            {
                return "O número de telefone deve conter apenas números.";
            }
            return null;
        }

        // Função obter nome cliente
        public static string ObterNomeCliente(int clienteId)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "SELECT Nome FROM Clientes WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", clienteId);

                    con.Open();
                    string nome = (string)cmd.ExecuteScalar();

                    return nome;
                }
            }
        }
        public static bool ClienteJaRegistrado(string nif)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "SELECT COUNT(*) FROM Clientes WHERE NIF = @NIF";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NIF", nif);

                    con.Open();
                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }
    }
}

