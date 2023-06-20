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
    public partial class FormConsultarAnimais : Form
    {
        public FormConsultarAnimais()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPesquisarComDono_Click(object sender, EventArgs e)
        {
            string nifDono = textBoxNIFDono.Text;

            // Realizar a consulta ao banco de dados
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
    }
}
