using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using VeT_Animais_Domésticos.Classes;

namespace VeT_Animais_Domésticos.Forms.Consultas
{
    public partial class AgendarConsulta : Form
    {
        private List<Animal> animais = new List<Animal>();

        public AgendarConsulta()
        {
            InitializeComponent();

            // Botão confirmar NIF dono
            buttonConfirmarNIFDono.FlatStyle = FlatStyle.Flat;
            buttonConfirmarNIFDono.FlatAppearance.BorderSize = 2;
            buttonConfirmarNIFDono.FlatAppearance.BorderColor = Color.Blue;

            // Botão confirmar agendar consulta
            buttonConfirmarAgendarConsulta.FlatStyle = FlatStyle.Flat;
            buttonConfirmarAgendarConsulta.FlatAppearance.BorderSize = 2;
            buttonConfirmarAgendarConsulta.FlatAppearance.BorderColor = Color.Blue;
        }

        private void buttonConfirmarNIFDono_Click(object sender, EventArgs e)
        {
            dataGridViewAgendarConsulta.DataSource = null;
            dataGridViewAgendarConsulta.Rows.Clear();

            this.animais = Animal.ObterAnimaisPorNIFDono(textBoxPesquisarNIFDono.Text);

            dataGridViewAgendarConsulta.DataSource = animais;
        }

        private void buttonConfirmarAgendarConsulta_Click(object sender, EventArgs e)
        {
            // Verifique se um animal foi selecionado na DataGridView
            if (dataGridViewAgendarConsulta.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um animal para agendar a consulta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedIndex = dataGridViewAgendarConsulta.SelectedRows[0].Index;
            Animal selectedAnimal = animais[selectedIndex];
            int idSelectedAnimal = selectedAnimal.Id;
            string telemovel = textBoxTelemovelAgendarConsulta.Text;

            DateTime dataConsulta = dateTimePickerDataConsultaAgendarConsulta.Value;

            if (dataConsulta.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Não é possível agendar consultas ao domingo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime horaConsulta = dateTimePickerHoraConsultaAgendarConsulta.Value;

            if (horaConsulta.Hour < 7 || horaConsulta.Hour > 21)
            {
                MessageBox.Show("Não é possível agendar consultas fora do horário de funcionamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (telemovel.Length != 9)
            {
                MessageBox.Show("O telemóvel do dono do animal não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxColaboradorAgendarConsulta.SelectedItem == null)
            {
                MessageBox.Show("Tem de selecionar um colaborador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idColaborador = ((ColaboradorItem)comboBoxColaboradorAgendarConsulta.SelectedItem).Id;

            // Resto do código...
        }

        private void AgendarConsulta_Load(object sender, EventArgs e)
        {
            // Execute the query to retrieve the names of collaborators
            string query = "SELECT id, nome FROM Colaboradores";

            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["id"];
                            string nome = (string)reader["nome"];

                            // Add the name to the ComboBox
                            comboBoxColaboradorAgendarConsulta.Items.Add(new ColaboradorItem(id, nome));
                        }
                    }
                }
            }
        }
    }
}