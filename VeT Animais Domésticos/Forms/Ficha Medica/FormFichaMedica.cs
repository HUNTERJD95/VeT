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
    public partial class FormFichaMedica : Form
    {
        private int idAnimal;

        public FormFichaMedica(int idAnimal)
        {
            InitializeComponent();
            this.idAnimal = idAnimal;

            // Botão guardar
            buttonGuardarFichaMedica.FlatStyle = FlatStyle.Flat;
            buttonGuardarFichaMedica.FlatAppearance.BorderSize = 2;
            buttonGuardarFichaMedica.FlatAppearance.BorderColor = Color.Blue;

            // Botão voltar
            buttonVoltarFichaMedica.FlatStyle = FlatStyle.Flat;
            buttonVoltarFichaMedica.FlatAppearance.BorderSize = 2;
            buttonVoltarFichaMedica.FlatAppearance.BorderColor = Color.Blue;
        }

        private void FormFichaMedica_Load(object sender, EventArgs e)
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
                            comboBoxNomeColaborador.Items.Add(new ColaboradorItem(id, nome));
                        }
                    }
                }
            }

            // Load ficha medica
            // Execute the query to retrieve the names of collaborators
            string queryFichaMedica = "SELECT * FROM Ficha_Medica WHERE id_animal = @ID";

            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                using (SqlCommand cmd = new SqlCommand(queryFichaMedica, con))
                {
                    cmd.Parameters.AddWithValue("@ID", this.idAnimal);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = (int)reader["id"];
                            dateTimePickerAtoMedico.Value = (DateTime)reader["data_ato_medico"];
                            comboBoxTipoConsulta.Text = (string)reader["tipo_consulta"];
                            comboBoxNomeColaborador.Text = (string)reader["nome_colaborador"];
                            textBoxDiagnosticoFichaMedica.Text = (string)reader["diagnostico"];
                            comboBoxAtoMedico.Text = (string)reader["ato_medico"];
                            float peso = reader.GetFloat(reader.GetOrdinal("peso"));
                            textBoxPesoAtoMedico.Text = peso.ToString();
                            textBoxObservacoesAtoMedico.Text = (string)reader["observacoes"];
                            textBoxPrescricaoAtoMedico.Text = (string)reader["prescricao_medica"];
                            dateTimePickerProximaVisita.Value = (DateTime)reader["proxima_visita"];
                        }
                    }
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColaboradorItem selectedItem = (ColaboradorItem)comboBoxNomeColaborador.SelectedItem;

            if (selectedItem == null)
            {
                // mostrar erro? message box?
                return;
            }

            int idColaborador = selectedItem.Id;

            // usar este id para guardar o valor da dropdown na BD
        }

        private void buttonVoltarFichaMedica_Click(object sender, EventArgs e)
        {
            // Abre o form ConsultarAnimais
            ConsultarAnimais ConsultarAnimais = new ConsultarAnimais();
            ConsultarAnimais.Show();
            this.Hide();
        }
    }
}
