using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using VeT_Animais_Domésticos.Classes;

namespace VeT_Animais_Domésticos.Forms
{
    public partial class FormConsultarClientes : Form
    {
        public FormConsultarClientes()
        {
            InitializeComponent();

            // Botão adicionar cliente
            buttonAdicionarCliente.FlatStyle = FlatStyle.Flat;
            buttonAdicionarCliente.FlatAppearance.BorderSize = 2;
            buttonAdicionarCliente.FlatAppearance.BorderColor = Color.Blue;

            // Botão consultar clientes
            buttonConsultarClientes.FlatStyle = FlatStyle.Flat;
            buttonConsultarClientes.FlatAppearance.BorderSize = 2;
            buttonConsultarClientes.FlatAppearance.BorderColor = Color.Blue;

            // Botão modificar clientes
            buttonModificarClientes.FlatStyle = FlatStyle.Flat;
            buttonModificarClientes.FlatAppearance.BorderSize = 2;
            buttonModificarClientes.FlatAppearance.BorderColor = Color.Blue;

            // Botão eliminar clientes
            buttonEliminarCliente.FlatStyle = FlatStyle.Flat;
            buttonEliminarCliente.FlatAppearance.BorderSize = 2;
            buttonEliminarCliente.FlatAppearance.BorderColor = Color.Blue;

            // Botão voltar
            buttonVoltarConsultar.FlatStyle = FlatStyle.Flat;
            buttonVoltarConsultar.FlatAppearance.BorderSize = 2;
            buttonVoltarConsultar.FlatAppearance.BorderColor = Color.Blue;

            // Botão clientes inativos
            buttonClientesInativos.FlatStyle = FlatStyle.Flat;
            buttonClientesInativos.FlatAppearance.BorderSize = 2;
            buttonClientesInativos.FlatAppearance.BorderColor = Color.Blue;

        }

        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            // Abre o formulário de Registro de Cliente e fecha o formulário atual
            RegistoCliente registoCliente = new RegistoCliente();
            registoCliente.Show();
            this.Hide();
        }

        private void buttonConsultarClientes_Click(object sender, EventArgs e)
        {
            // ao clicar fecha a picture box
            pictureBoxClientes.Visible = false;

            // Realiza a consulta ao banco de dados e atualiza a tabela de Clientes
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                con.Open();
                string query = "SELECT Id, Nome, DataNascimento, NIF, Telemovel, Data_Registo FROM Clientes WHERE Estado_Cliente != 0";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewClientes.DataSource = dataTable;
                    }
                }
            }

            // Mostra a datagrid
            dataGridViewClientes.Visible = true;

            dataGridViewClientes.Refresh();
        }


        private void buttonModificarClientes_Click(object sender, EventArgs e)
        {

            // Verificar se um cliente está selecionado no DataGridView
            if (dataGridViewClientes.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Nenhum cliente selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Obter o ID do cliente selecionado
                int clienteId = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells["Id"].Value);

                // Abrir o formulário "FormModificarClientes" e passar o ID do cliente como parâmetro
                using (FormAdicionarAnimal formModificarCliente = new FormAdicionarAnimal(clienteId))
                {
                    // Exibir o formulário como uma janela modal
                    DialogResult result = formModificarCliente.ShowDialog();

                    // Verificar se os dados foram alterados no formulário "FormModificarClientes"
                    if (result == DialogResult.OK)
                    {
                        // Obter os novos valores dos campos do cliente do formulário "FormModificarClientes"
                        string novoNome = formModificarCliente.NovoNome;
                        string novoNIF = formModificarCliente.NovoNIF;
                        DateTime novaDataNascimento = formModificarCliente.NovaDataNascimento;
                        string novoTelemovel = formModificarCliente.NovoTelemovel;

                        // Atualizar os dados do cliente no banco de dados
                        AtualizarClienteNoBancoDeDados(clienteId, novoNome, novoNIF, novaDataNascimento, novoTelemovel);

                        MessageBox.Show("Dados do cliente atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Atualizar os dados do DataGridView
                        AtualizarDadosClientes();
                    }
                }
            }
        }


        private void AtualizarClienteNoBancoDeDados(int clienteId, string novoNome, string novoNIF, DateTime novaDataNascimento, string novoTelemovel)
        {
            // Executar a instrução SQL UPDATE para atualizar o cliente no banco de dados
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                con.Open();
                string query = "UPDATE Clientes SET Nome = @Nome, NIF = @NIF, DataNascimento = @DataNascimento, Telemovel = @Telemovel WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", novoNome);
                    cmd.Parameters.AddWithValue("@NIF", novoNIF);
                    cmd.Parameters.AddWithValue("@DataNascimento", novaDataNascimento);
                    cmd.Parameters.AddWithValue("@Telemovel", novoTelemovel);
                    cmd.Parameters.AddWithValue("@Id", clienteId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void AtualizarDadosClientes()
        {
            // Realiza a consulta ao banco de dados para obter os clientes atualizados
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                con.Open();
                string query = "SELECT * FROM Clientes WHERE Estado_Cliente != 0";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewClientes.DataSource = dataTable;
                    }
                }
            }
        }

        private void FormConsultarClientes_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
            // Verificar se um cliente está selecionado no DataGridView
            if (dataGridViewClientes.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Nenhum cliente selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Obter o ID do cliente selecionado
                int clienteId = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells["Id"].Value);

                // Confirmar a exclusão com o usuário
                DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir/desativar este cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Atualizar a coluna Estado_Cliente para 0 no banco de dados
                    using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
                    {
                        con.Open();
                        string query = "UPDATE Clientes SET Estado_Cliente = 0, Data_Exclusao = GETDATE() WHERE Id = @Id";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Id", clienteId);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Atualizar os dados do DataGridView
                    AtualizarDadosClientes();

                    // Exibir mensagem de sucesso
                    MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao excluir o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonVoltarConsultar_Click(object sender, EventArgs e)
        {
            // Fecha este form e abre o FormPrincipal
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
            this.Hide();
        }

        private void buttonClientesInativos_Click(object sender, EventArgs e)
        {
            // Ocultar imagem
            pictureBoxClientes.Visible = false;
            // Executa query para obter clientes com a coluna Estado_Cliente = 0 e abre a datagridview
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                con.Open();
                string query = "SELECT Id, Nome, NIF, Telemovel, Data_Exclusao FROM Clientes WHERE Estado_Cliente = 0";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewClientes.DataSource = dataTable;
                    }
                }
                // Mostra a datagrid
                dataGridViewClientes.Visible = true;

                dataGridViewClientes.Refresh();
            }
        }
    }
}