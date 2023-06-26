using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeT_Animais_Domésticos.Classes
{
    public class Ato_Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Custo { get; set; }
        public DateTime Data_registo { get; set; }
        public string Estado { get; set; }

        public Ato_Medico(int id, string nome, string descricao, float custo, DateTime data_registo, string estado)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Custo = custo;
            Data_registo = data_registo;
            Estado = estado;
            
        }

        // Inserir ato_medico na BD
        public static void InserirAto(int id, string nome, string descricao, float custo, DateTime data_registo, string estado)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "INSERT INTO Atos_Medicos (id, nome, descricao, custo, data_registo, estado) VALUES (@Id, @Nome, @Descricao, @Custo, @Data_Registo, @Estado)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Descricao", descricao);
                    cmd.Parameters.AddWithValue("@Custo", custo);
                    cmd.Parameters.AddWithValue("@Data_Registo", data_registo);
                    cmd.Parameters.AddWithValue("@Estado", estado);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Atualizar Ato_medico na BD
        public static void AtualizarAtoMedico(int id, string nome, string descricao, float custo)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "UPDATE Atos_Medicos SET nome = @Nome, descricao = @Descricao, custo = @Custo WHERE id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Descricao", descricao);
                    cmd.Parameters.AddWithValue("@Custo", custo);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static int ObterNumeroAtoMedico()
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "SELECT MAX(id) FROM Atos_Medicos";
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

        public static bool ExisteAtoMedico(string id)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "SELECT COUNT(*) FROM Atos_Medicos WHERE id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Descricao", id);

                    con.Open();
                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        // Função VerificarDescricaoAtoMedico
        public static bool VerificarDescricaoAtoMedico(string descricao)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "SELECT COUNT(*) FROM Atos_Medicos WHERE descricao = @Descricao";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Descricao", descricao);

                    con.Open();
                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }
    }
}
