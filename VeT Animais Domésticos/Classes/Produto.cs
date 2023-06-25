using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeT_Animais_Domésticos.Classes.Produtos
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeEmArmazem { get; set; }
        public decimal PrecoUnitario { get; set; }
        public string Estado { get; set; }

        public Produto(string tipo, string descricao, int quantidadeEmArmazem, decimal precoUnitario, string estado)
        {
            Tipo = tipo;
            Descricao = descricao;
            QuantidadeEmArmazem = quantidadeEmArmazem;
            PrecoUnitario = precoUnitario;
            Estado = estado;
        }

        // Inserir produto na BD
        public static void InserirProduto(string tipo, string descricao, int quantidadeEmArmazem, decimal precoUnitario, string estado)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "INSERT INTO Produtos (tipo_produto, descricao_produto, quantidade_armazem, preco_unitario, estado) VALUES (@Tipo, @Descricao, @QuantidadeEmArmazem, @PrecoUnitario, @Estado)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Descricao", descricao);
                    cmd.Parameters.AddWithValue("@QuantidadeEmArmazem", quantidadeEmArmazem);
                    cmd.Parameters.AddWithValue("@PrecoUnitario", precoUnitario);
                    cmd.Parameters.AddWithValue("@Estado", estado);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Atualizar produto na BD
        public static void AtualizarProduto(int codProduto, string tipoProduto, string descricaoProduto, int quantidadeArmazem, decimal precoUnitario, string estado)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "UPDATE Produtos SET tipo_produto = @TipoProduto, descricao_produto = @DescricaoProduto, quantidade_armazem = @QuantidadeArmazem, preco_unitario = @PrecoUnitario WHERE cod_produto = @CodProduto";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CodProduto", codProduto);
                    cmd.Parameters.AddWithValue("@TipoProduto", tipoProduto);
                    cmd.Parameters.AddWithValue("@DescricaoProduto", descricaoProduto);
                    cmd.Parameters.AddWithValue("@QuantidadeArmazem", quantidadeArmazem);
                    cmd.Parameters.AddWithValue("@PrecoUnitario", precoUnitario);
                    

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static int ObterNumeroProduto()
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "SELECT MAX(cod_produto) FROM Produtos";
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

        public static bool ExisteProduto(string descricao)
        {
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                string query = "SELECT COUNT(*) FROM Produtos WHERE descricao_produto = @Descricao";
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
