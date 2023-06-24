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

namespace VeT_Animais_Domésticos.Forms
{
    public partial class ConsultarAnimais : Form
    {
        public ConsultarAnimais()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarDadosAnimais()
        {
            // Realiza a consulta ao banco de dados para obter os clientes atualizados
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                con.Open();
                string query = "SELECT * FROM Animais WHERE Ativo != 0";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewAnimais.DataSource = dataTable;
                    }
                }
            }
        }

        private void buttonPesquisarComDono_Click(object sender, EventArgs e)
        {
            // Se não tiver sido introduzido um NIF, escreve mensagem de erro
            if (textBoxNIFDono.Text == "")
            {
                MessageBox.Show("Introduza o NIF do Dono", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nifDono = textBoxNIFDono.Text;

            // Realizar a consulta na bd
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                con.Open();
                string query = "SELECT * FROM Animais WHERE dono_NIF = @NIFDono";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NIFDono", nifDono);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewAnimais.DataSource = dataTable;
                    }
                }

                // Mostrar o DataGridView
                dataGridViewAnimais.Visible = true;
            }
        }

        private void buttonPesquisarSemDono_Click(object sender, EventArgs e)
        {
            // mostra a datagrid com todos os animais que estão associados ao NIF 1
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                con.Open();
                string query = "SELECT * FROM Animais WHERE dono_NIF = 1";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewAnimais.DataSource = dataTable;
                    }
                }

                // Mostrar o DataGridView
                dataGridViewAnimais.Visible = true;
            }
        }

        private void buttonVoltarConsultarAnimais_Click(object sender, EventArgs e)
        {
            // Abre o form FormAnimais e fecha o corrente
            FormAnimais formAnimais = new FormAnimais();
            formAnimais.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Fecha o form e abre o FormAnimais
            FormAnimais formAnimais = new FormAnimais();
            formAnimais.Show();
            this.Hide();
        }

        private void buttonModificarAnimal_Click(object sender, EventArgs e)
        {
            // Verifique se há uma linha selecionada no DataGridView
            if (dataGridViewAnimais.SelectedRows.Count > 0)
            {
                // Obtenha o ID do animal selecionado na primeira coluna do DataGridView
                int animalId = Convert.ToInt32(dataGridViewAnimais.SelectedRows[0].Cells["ID"].Value);

                // Crie uma instância do formulário "ModificarAnimal"
                ModificarAnimal modificarAnimalForm = new ModificarAnimal();

                // Configure o ID do animal na propriedade AnimalId
                modificarAnimalForm.AnimalId = animalId;

                // Abra o formulário "ModificarAnimal" como janela modal
                modificarAnimalForm.ShowDialog();

                // Atualize a exibição dos animais após fechar o formulário "ModificarAnimal"
                AtualizarExibicaoAnimais();
            }
            else
            {
                MessageBox.Show("Selecione um animal para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ConsultarAnimais_Load(object sender, EventArgs e)
        {

        }

        private void AtualizarExibicaoAnimais()
        {
            string nifDono = textBoxNIFDono.Text;

            // Realizar a consulta na bd
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                con.Open();
                string query = "SELECT * FROM Animais WHERE dono_NIF = @NIFDono";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NIFDono", nifDono);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewAnimais.DataSource = dataTable;
                    }
                }

                // Mostrar o DataGridView
                dataGridViewAnimais.Visible = true;
            }
        }

        private void dataGridViewAnimais_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEliminarAnimal_Click(object sender, EventArgs e)
        {
            // Verifique se há uma linha selecionada no DataGridView
            if (dataGridViewAnimais.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum animal selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                // Obtenha o ID do animal selecionado na primeira coluna do DataGridView
                int animalId = Convert.ToInt32(dataGridViewAnimais.SelectedRows[0].Cells["ID"].Value);
               

                // Confirmar a exclusão com o usuário
                DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir/desativar este animal?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Atualizar a coluna Ativo para 0 na BD
                    using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
                    {
                        con.Open();
                        string query = "UPDATE Animais SET Ativo = 0, data_exclusao = GETDATE() WHERE Id = @Id";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Id", animalId);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Atualizar os dados do DataGridView
                    AtualizarDadosAnimais();

                    // Exibir mensagem de sucesso
                    MessageBox.Show("Animal excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao excluir o animal.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                dataGridViewAnimais.Refresh();
            }
        }

        private void buttonAnimaisInativos_Click(object sender, EventArgs e)
        {
            // Executa query para obter animais com a coluna Ativo = 0 e abre a datagridview
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                con.Open();
                string query = "SELECT * FROM Animais WHERE Ativo = 0";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewAnimais.DataSource = dataTable;
                    }
                }
                // Mostra a datagrid
                dataGridViewAnimais.Visible = true;

                dataGridViewAnimais.Refresh();
            }
        }
    }
}
