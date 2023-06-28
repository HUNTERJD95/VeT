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

namespace VeT_Animais_Domésticos.Forms.Colaboradores
{
    public partial class Colaboradores_Principal : Form
    {
        public Colaboradores_Principal()
        {
            InitializeComponent();

            // Botão adicionar colaborador
            buttonAdicionarColaborador.FlatStyle = FlatStyle.Flat;
            buttonAdicionarColaborador.FlatAppearance.BorderSize = 2;
            buttonAdicionarColaborador.FlatAppearance.BorderColor = Color.Blue;

            // Botão consultar colaboradores
            buttonConsultarColaboradores.FlatStyle = FlatStyle.Flat;
            buttonConsultarColaboradores.FlatAppearance.BorderSize = 2;
            buttonConsultarColaboradores.FlatAppearance.BorderColor = Color.Blue;

            // Botão modificar colaboradores
            buttonModificarColaboradores.FlatStyle = FlatStyle.Flat;
            buttonModificarColaboradores.FlatAppearance.BorderSize = 2;
            buttonModificarColaboradores.FlatAppearance.BorderColor = Color.Blue;

            // Botão eliminar colaboradores
            buttonEliminarColaboradores.FlatStyle = FlatStyle.Flat;
            buttonEliminarColaboradores.FlatAppearance.BorderSize = 2;
            buttonEliminarColaboradores.FlatAppearance.BorderColor = Color.Blue;

            // Botão voltar
            buttonVoltarConsultar.FlatStyle = FlatStyle.Flat;
            buttonVoltarConsultar.FlatAppearance.BorderSize = 2;
            buttonVoltarConsultar.FlatAppearance.BorderColor = Color.Blue;

            // Botão Colaboradores Inativos
            buttonColaboradoresInativos.FlatStyle = FlatStyle.Flat;
            buttonColaboradoresInativos.FlatAppearance.BorderSize = 2;
            buttonColaboradoresInativos.FlatAppearance.BorderColor = Color.Blue;

        }

        private void buttonVoltarConsultar_Click(object sender, EventArgs e)
        {
            // Fecha este form e abre o FormPrincipal
            this.Close();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void buttonAdicionarColaborador_Click(object sender, EventArgs e)
        {
            // Abre o form Adicionar_Colaborador como janela modal
            Adicionar_Colaborador adicionar_Colaborador = new Adicionar_Colaborador();
            adicionar_Colaborador.ShowDialog();
        }

        private void buttonConsultarColaboradores_Click(object sender, EventArgs e)
        {
            // Realiza a consulta ao banco de dados e atualiza a tabela de Colaboradores
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                con.Open();
                string query = "SELECT id, nome, data_nascimento, tipo_colaborador, funcao, data_inicio_colaboracao, telemovel, disponibilidade_horario FROM Colaboradores WHERE estado != 0";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewColaboradores.DataSource = dataTable;
                    }
                }
            }

            // Mostra a datagrid
            dataGridViewColaboradores.Visible = true;

            dataGridViewColaboradores.Refresh();
        }

        private void buttonModificarColaboradores_Click(object sender, EventArgs e)
        {
            // Verificar se um colaborador está selecionado no DataGridView
            if (dataGridViewColaboradores.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Nenhum colaborador selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Obter o ID do colaborador selecionado
                int colaboradorId = Convert.ToInt32(dataGridViewColaboradores.SelectedRows[0].Cells["Id"].Value);

                // Abrir o formulário "ModificarColaborador" e passar o ID do colaborador como parâmetro
                using (ModificarColaborador modificarColaborador = new ModificarColaborador(colaboradorId))
                {
                    // Exibir o formulário ModificarColaborador como uma janela modal
                    DialogResult result = modificarColaborador.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        // Obter os novos valores dos campos do colaborador do formulário "ModificarColaborador"
                        string novoNome = modificarColaborador.novoNome;
                        DateTime novaDataNascimento = modificarColaborador.novoDataNascimento;
                        string novoNIF = modificarColaborador.novoNIF;
                        string novoTipo = modificarColaborador.novoTipo;
                        string novoFuncao = modificarColaborador.novoFuncao;
                        string novoTelemovel = modificarColaborador.novoTelemovel;
                        string novoDisponibilidade = modificarColaborador.novoDisponibilidade;
                    }
                }
            }

            // Atualizar os dados do DataGridView
            AtualizarDadosColaboradores();
        }
        private void AtualizarDadosColaboradores()
        {
            // Realiza a consulta ao banco de dados para obter os colaboradores atualizados
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                con.Open();
                string query = "SELECT * FROM Colaboradores WHERE estado != 0";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewColaboradores.DataSource = dataTable;
                    }
                }
            }
        }

        private void buttonEliminarColaboradores_Click(object sender, EventArgs e)
        {
            // Verificar se um colaborador está selecionado no DataGridView
            if (dataGridViewColaboradores.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Nenhum colaborador selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Obter o ID do colaborador selecionado
                int colaboradorID = Convert.ToInt32(dataGridViewColaboradores.SelectedRows[0].Cells["Id"].Value);

                // Confirmar a exclusão com o usuário
                DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir/desativar este colaborador?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Atualizar a coluna estado para 0 no banco de dados
                    using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
                    {
                        con.Open();
                        string query = "UPDATE Colaboradores SET estado = 0, data_fim_colaboracao = GETDATE() WHERE Id = @Id";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Id", colaboradorID);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Atualizar os dados do DataGridView
                    AtualizarDadosColaboradores();

                    // Exibir mensagem de sucesso
                    MessageBox.Show("Colaborador excluído/desativado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao excluir o colaborador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonColaboradoresInativos_Click(object sender, EventArgs e)
        {
            // Executa query para obter colaboradores com a coluna estado = 0 e abre a datagridview
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                con.Open();
                string query = "SELECT * FROM Colaboradores WHERE estado = 0";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewColaboradores.DataSource = dataTable;
                    }
                }
                // Mostra a datagrid
                dataGridViewColaboradores.Visible = true;

                dataGridViewColaboradores.Refresh();
            }
        }
    }
}
