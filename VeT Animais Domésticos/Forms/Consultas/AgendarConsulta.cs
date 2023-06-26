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
        }

        private void buttonConfirmarNIFDono_Click(object sender, EventArgs e)
        {
            listBoxAnimaisPesquisados.Items.Clear();

            this.animais = Animal.ObterAnimaisPorNIFDono(textBoxPesquisarNIFDono.Text);

            foreach (Animal animal in animais)
            {
                listBoxAnimaisPesquisados.Items.Add(animal.ToString());
            }

            listBoxAnimaisPesquisados.Show();
        }

        private void buttonConfirmarAgendarConsulta_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxAnimaisPesquisados.SelectedIndex;
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