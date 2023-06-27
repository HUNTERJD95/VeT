using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeT_Animais_Domésticos.Classes
{
    public class Colaborador
    {
        public string Nome { get; set; }
        public string NIF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string TipoColaborador { get; set; }
        public string FuncaoColaborador { get; set; }
        public string DisponibilidadeColaborador { get; set; }
        public string Telemovel { get; set; }

        public Colaborador(string nome, string nif, DateTime dataNascimento, string tipoColaborador, string funcaoColaborador, string disponibilidadeColaborador, string telemovel)
        {
            Nome = nome;
            NIF = nif;
            DataNascimento = dataNascimento;
            TipoColaborador = tipoColaborador;
            FuncaoColaborador = funcaoColaborador;
            DisponibilidadeColaborador = disponibilidadeColaborador;
            Telemovel = telemovel;
        }

        // Inserir IdColaborador na BD
        public static void InserirColaborador(string nome, string nif, DateTime dataNascimento, string tipoColaborador, string funcaoColaborador, string disponibilidadeColaborador, string telemovel)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "INSERT INTO Colaboradores (nome, nif, data_nascimento, tipo_colaborador, funcao, disponibilidade_horario, telemovel) VALUES (@Nome, @NIF, @DataNascimento, @TipoColaborador, @FuncaoColaborador, @DisponibilidadeColaborador, @Telemovel)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@NIF", nif);
                    cmd.Parameters.AddWithValue("@DataNascimento", dataNascimento);
                    cmd.Parameters.AddWithValue("@TipoColaborador", tipoColaborador);
                    cmd.Parameters.AddWithValue("@FuncaoColaborador", funcaoColaborador);
                    cmd.Parameters.AddWithValue("@DisponibilidadeColaborador", disponibilidadeColaborador);
                    cmd.Parameters.AddWithValue("@Telemovel", telemovel);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Atualizar IdColaborador na BD
        public static void AtualizarColaborador(int Id, string nome, string nif, DateTime dataNascimento, string tipoColaborador, string funcaoColaborador, string disponibilidadeColaborador, string telemovel)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "UPDATE Colaboradores SET nome = @Nome, nif = @NIF, data_nascimento = @DataNascimento, tipo_colaborador = @TipoColaborador, funcao = @FuncaoColaborador, disponibilidade_horario = @DisponibilidadeColaborador, telemovel = @Telemovel WHERE id = @ID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", Id);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@NIF", nif);
                    cmd.Parameters.AddWithValue("@DataNascimento", dataNascimento);
                    cmd.Parameters.AddWithValue("@TipoColaborador", tipoColaborador);
                    cmd.Parameters.AddWithValue("@FuncaoColaborador", funcaoColaborador);
                    cmd.Parameters.AddWithValue("@DisponibilidadeColaborador", disponibilidadeColaborador);
                    cmd.Parameters.AddWithValue("@Telemovel", telemovel);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Eliminar IdColaborador da BD
        public static void EliminarColaborador(int Id)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "DELETE FROM Colaboradores WHERE id = @ID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", Id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // verifica em loop dentro do input se cada caracter é uma letra ou se contém um "espaço"
        public static bool VerificarNomeColaborador(string nome)
        {
            foreach (char c in nome)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        // Validação do NIF
        public static bool VerificarNIFColaborador(string nif)
        {
            if (nif.Length != 9)
            {
                return false;
            }
            else
            {
                foreach (char c in nif)
                {
                    if (!char.IsDigit(c))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public static bool ColaboradorJaRegistrado(string nif)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "SELECT COUNT(*) FROM Colaboradores WHERE NIF = @NIF";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NIF", nif);

                    con.Open();
                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        public static int ObterNumeroColaborador()
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "SELECT MAX(id) FROM Colaboradores";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

       
    }



}
