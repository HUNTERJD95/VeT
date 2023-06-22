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

        }
    }
}
