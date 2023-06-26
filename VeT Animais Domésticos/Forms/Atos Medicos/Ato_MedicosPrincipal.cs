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
using VeT_Animais_Domésticos.Forms.Atos_Medicos;
using VeT_Animais_Domésticos.Forms.Colaboradores;

namespace VeT_Animais_Domésticos.Forms
{
    public partial class Ato_MedicosPrincipal : Form
    {
        public Ato_MedicosPrincipal()
        {
            InitializeComponent();

            // Botão voltar
            buttonVoltarAtosMedicos.FlatStyle = FlatStyle.Flat;
            buttonVoltarAtosMedicos.FlatAppearance.BorderSize = 2;
            buttonVoltarAtosMedicos.FlatAppearance.BorderColor = Color.Blue;

            // Botão consultar
            buttonConsultarAtosMedicos.FlatStyle = FlatStyle.Flat;
            buttonConsultarAtosMedicos.FlatAppearance.BorderSize = 2;
            buttonConsultarAtosMedicos.FlatAppearance.BorderColor = Color.Blue;

            // Botão adicionar
            buttonAdicionarAtoMedico.FlatStyle = FlatStyle.Flat;
            buttonAdicionarAtoMedico.FlatAppearance.BorderSize = 2;
            buttonAdicionarAtoMedico.FlatAppearance.BorderColor = Color.Blue;

            // Botão editar
            buttonAlterarAtosMedicos.FlatStyle = FlatStyle.Flat;
            buttonAlterarAtosMedicos.FlatAppearance.BorderSize = 2;
            buttonAlterarAtosMedicos.FlatAppearance.BorderColor = Color.Blue;

            // Botão eliminar
            buttonEliminarAtoMedico.FlatStyle = FlatStyle.Flat;
            buttonEliminarAtoMedico.FlatAppearance.BorderSize = 2;
            buttonEliminarAtoMedico.FlatAppearance.BorderColor = Color.Blue;

            // Botão atos medicos inativos
            buttonAtosMedicosInativos.FlatStyle = FlatStyle.Flat;
            buttonAtosMedicosInativos.FlatAppearance.BorderSize = 2;
            buttonAtosMedicosInativos.FlatAppearance.BorderColor = Color.Blue;

        }

        private void buttonVoltarAtosMedicos_Click(object sender, EventArgs e)
        {
            // Fechar o form atual e abrir o form principal
            this.Close();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void buttonConsultarAtosMedicos_Click(object sender, EventArgs e)
        {
            // Realiza a consulta ao banco de dados e atualiza a tabela de Atos Médicos
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                con.Open();
                string query = "SELECT * FROM Atos_Medicos WHERE estado != '0'";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewAtosMedicos.DataSource = dataTable;
                    }
                }
            }

            // Mostra a datagrid
            dataGridViewAtosMedicos.Visible = true;

            dataGridViewAtosMedicos.Refresh();
        }

        private void buttonAdicionarAtoMedico_Click(object sender, EventArgs e)
        {
            // Abre o form AdicionarAtoMedico como janela modal
            AdicionarAtoMedico adicionarAtoMedico = new AdicionarAtoMedico();
            adicionarAtoMedico.ShowDialog();
        }

        private void buttonAlterarAtosMedicos_Click(object sender, EventArgs e)
        {
            // Verificar se um ato médico está selecionado no DataGridView
            if (dataGridViewAtosMedicos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Nenhum Ato Médico selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Obter o ID do ato médico selecionado
                int atomedicoId = Convert.ToInt32(dataGridViewAtosMedicos.SelectedRows[0].Cells["id"].Value);

                // Abrir o formulário "AlterarAtoMedico" e passar o ID do ato medico como parâmetro
                using (AlterarAtoMedico alterarAtoMedico = new AlterarAtoMedico(atomedicoId))
                {
                    // Exibir o formulário AlterarAtoMedico como uma janela modal
                    DialogResult result = alterarAtoMedico.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        // Obter os novos valores dos campos do ato medico do formulário "AlterarAtoMedico"
                        string novoNome = alterarAtoMedico.novoNome;
                        string novoDescricao = alterarAtoMedico.novoDescricao;
                        float novoCusto = alterarAtoMedico.novoCusto;
                        DateTime novoData_registo = alterarAtoMedico.novoData_registo;

                        // Verificar se a data está dentro do intervalo válido
                        if (novoData_registo < DateTime.MinValue || novoData_registo > DateTime.MaxValue)
                        {
                            // Atribuir a data atual como valor padrão
                            novoData_registo = DateTime.Now;
                        }
                    }
                }
            }
        }

        private void buttonEliminarAtoMedico_Click(object sender, EventArgs e)
        {
            // Verificar se um ato médico está selecionado no DataGridView
            if (dataGridViewAtosMedicos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Nenhum ato médico selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Obter o ID do colaborador selecionado
                int atomedicoID = Convert.ToInt32(dataGridViewAtosMedicos.SelectedRows[0].Cells["id"].Value);

                // Confirmar a exclusão com o usuário
                DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir/desativar este ato médico?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Atualizar a coluna estado para 0 no banco de dados
                    using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
                    {
                        con.Open();
                        string query = "UPDATE Atos_Medicos SET estado = '0' WHERE id = @Id";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@id", atomedicoID);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    dataGridViewAtosMedicos.Visible = true;
                    dataGridViewAtosMedicos.Refresh();

                    // Exibir mensagem de sucesso
                    MessageBox.Show("Ato Médico excluído/desativado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao excluir o Ato Médico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAtosMedicosInativos_Click(object sender, EventArgs e)
        {
            // Executa query para obter atos médicos com a coluna estado = 0 e abre a datagridview
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                con.Open();
                string query = "SELECT * FROM Atos_Medicos WHERE estado = '0'";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewAtosMedicos.DataSource = dataTable;
                    }
                }
                // Mostra a datagrid
                dataGridViewAtosMedicos.Visible = true;

                dataGridViewAtosMedicos.Refresh();
            }
        }
    }
}
