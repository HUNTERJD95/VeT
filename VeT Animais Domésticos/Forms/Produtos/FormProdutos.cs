using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeT_Animais_Domésticos.Classes;
using VeT_Animais_Domésticos.Classes.Produtos;
using VeT_Animais_Domésticos.Forms.Colaboradores;

namespace VeT_Animais_Domésticos.Forms.Produtos
{
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {

            InitializeComponent();

            // Botão Produtos
            buttonAdicionarProduto.FlatStyle = FlatStyle.Flat;
            buttonAdicionarProduto.FlatAppearance.BorderSize = 2;
            buttonAdicionarProduto.FlatAppearance.BorderColor = Color.Blue;

            // Botão Consultar Produtos
            buttonConsultarProdutos.FlatStyle = FlatStyle.Flat;
            buttonConsultarProdutos.FlatAppearance.BorderSize = 2;
            buttonConsultarProdutos.FlatAppearance.BorderColor = Color.Blue;

            // Botão Modificar Produtos
            buttonModificarProdutos.FlatStyle = FlatStyle.Flat;
            buttonModificarProdutos.FlatAppearance.BorderSize = 2;
            buttonModificarProdutos.FlatAppearance.BorderColor = Color.Blue;

            // Botão Eliminar Produtos
            buttonEliminarProdutos.FlatStyle = FlatStyle.Flat;
            buttonEliminarProdutos.FlatAppearance.BorderSize = 2;
            buttonEliminarProdutos.FlatAppearance.BorderColor = Color.Blue;

            // Botão Voltar
            buttonVoltarProdutos.FlatStyle = FlatStyle.Flat;
            buttonVoltarProdutos.FlatAppearance.BorderSize = 2;
            buttonVoltarProdutos.FlatAppearance.BorderColor = Color.Blue;

            // Botão Produtos Inativos
            buttonProdutosInativos.FlatStyle = FlatStyle.Flat;
            buttonProdutosInativos.FlatAppearance.BorderSize = 2;
            buttonProdutosInativos.FlatAppearance.BorderColor = Color.Blue;

        }

        private void buttonConsultarProdutos_Click(object sender, EventArgs e)
        {
            // Realiza a consulta ao banco de dados e atualiza a tabela de Produtos
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                con.Open();
                string query = "SELECT * FROM Produtos WHERE estado != 0";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewProdutos.DataSource = dataTable;
                    }
                }
            }

            // Mostra a datagrid
            dataGridViewProdutos.Visible = true;

            dataGridViewProdutos.Refresh();
        }

        private void buttonModificarProdutos_Click(object sender, EventArgs e)
        {

        }


        private void buttonModificarProdutos_Click_1(object sender, EventArgs e)
        {
            // Verificar se um produto está selecionado no DataGridView
            if (dataGridViewProdutos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Nenhum produto selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Obter o ID do colaborador selecionado
                int produtoId = Convert.ToInt32(dataGridViewProdutos.SelectedRows[0].Cells["cod_produto"].Value);

                // Abrir o formulário "ModificarProduto" e passar o ID do produto como parâmetro
                using (ModificarProduto modificarProduto = new ModificarProduto(produtoId))
                {
                    // Exibir o formulário ModificarProduto como uma janela modal
                    DialogResult result = modificarProduto.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        // Obter os novos valores dos campos do produto do formulário "ModificarProduto"
                        string novoTipo = modificarProduto.novoTipoProduto;
                        string novaDescricao = modificarProduto.novoDescricaoProduto;
                        int novaQuantidadeEmArmazem = modificarProduto.novoQuantidadeArmazem;
                        decimal novoPrecoUnitario = modificarProduto.novoPrecoUnitario;

                        // Atualizar o produto na base de dados
                        Produto.AtualizarProduto(produtoId, novoTipo, novaDescricao, novaQuantidadeEmArmazem, novoPrecoUnitario, "ativo");

                        MessageBox.Show("Produto atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Atualizar os dados na exibição do grid ou em qualquer outra ação necessária após a atualização do produto
                        AtualizarDadosProdutos();
                    }
                }
            }
        }

        private void AtualizarDadosProdutos()
        {
            // Realiza a consulta ao banco de dados para obter os colaboradores atualizados
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                con.Open();
                string query = "SELECT * FROM Produtos WHERE estado != '0'";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewProdutos.DataSource = dataTable;
                    }
                }
            }
        }

        private void buttonVoltarProdutos_Click(object sender, EventArgs e)
        {
            // Fecha esta janela e volta ao FormPrincipal
            this.Close();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void buttonEliminarProdutos_Click(object sender, EventArgs e)
        {
            // Verificar se um produto está selecionado no DataGridView
            if (dataGridViewProdutos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Nenhum produto selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Obter o ID do produto selecionado
                int colaboradorID = Convert.ToInt32(dataGridViewProdutos.SelectedRows[0].Cells["cod_produto"].Value);

                // Confirmar a exclusão com o usuário
                DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir/desativar este produto?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Atualizar a coluna estado para 0 no banco de dados
                    using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
                    {
                        con.Open();
                        string query = "UPDATE Produtos SET estado = '0' WHERE cod_produto = @Id";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Id", colaboradorID);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Atualizar os dados do DataGridView
                    AtualizarDadosProdutos();

                    // Exibir mensagem de sucesso
                    MessageBox.Show("Produto excluído/desativado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao excluir o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonProdutosInativos_Click(object sender, EventArgs e)
        {
            // Executa query para obter produtos com a coluna estado = 0 e abre a datagridview
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                con.Open();
                string query = "SELECT * FROM Produtos WHERE estado = '0'";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewProdutos.DataSource = dataTable;
                    }
                }
                // Mostra a datagrid
                dataGridViewProdutos.Visible = true;

                dataGridViewProdutos.Refresh();
            }
        }

        private void buttonAdicionarProduto_Click(object sender, EventArgs e)
        {
            // Abre o form AdicionarProduto como janela modal
            AdicionarProdutos adicionarProdutos = new AdicionarProdutos();
            DialogResult result = adicionarProdutos.ShowDialog();
        }

        private void buttonConsultarProdutos_Click_1(object sender, EventArgs e)
        {
            // Realiza a consulta ao banco de dados e atualiza a tabela de Produtos
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                con.Open();
                string query = "SELECT cod_produto, tipo_produto, descricao_produto, quantidade_armazem, preco_unitario FROM Produtos WHERE estado != '0'";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewProdutos.DataSource = dataTable;
                    }
                }
            }

            // Mostra a datagrid
            dataGridViewProdutos.Visible = true;

            dataGridViewProdutos.Refresh();
        }

        private void dataGridViewProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }
    }
}