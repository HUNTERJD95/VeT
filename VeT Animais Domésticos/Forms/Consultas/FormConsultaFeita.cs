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

namespace VeT_Animais_Domésticos.Forms
{
    public partial class FormConsultaFeita : Form
    {
        private int idAnimal;

        public FormConsultaFeita(int idAnimal)
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
            // Preencher combobox produtos
            PreencherComboBoxProdutos();

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

            // Obter nome de colaboradores para a combobox
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
                            comboBoxDiagnosticoFichaMedica.Text = (string)reader["diagnostico"];
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
                MessageBox.Show("Selecione um colaborador");
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

        private void comboBoxDiagnosticoFichaMedica_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar se o limite de 5 itens foi atingido
            if (listBoxDiagnosticoFichaMedica.Items.Count < 5)
            {
                // Verificar se há um item selecionado na ComboBox
                if (comboBoxDiagnosticoFichaMedica.SelectedItem != null)
                {
                    listBoxDiagnosticoFichaMedica.Items.Add(comboBoxDiagnosticoFichaMedica.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Você atingiu o limite de 5 itens selecionados.", "Limite de Itens", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxAtoMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar se o limite de 5 itens foi atingido
            if (listBoxAtosMedicosFichaMedica.Items.Count < 5)
            {
                // Verificar se há um item selecionado na ComboBox
                if (comboBoxAtoMedico.SelectedItem != null)
                {
                    listBoxAtosMedicosFichaMedica.Items.Add(comboBoxAtoMedico.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Você atingiu o limite de 5 itens selecionados.", "Limite de Itens", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxProdutosUtilizados_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar se há um item selecionado na ComboBox
            if (comboBoxProdutosUtilizados.SelectedItem != null)
            {
                string produtoSelecionado = comboBoxProdutosUtilizados.SelectedItem.ToString();

                // Verificar se o item já existe na ListBox
                if (!listBoxProdutosUtilizados.Items.Contains(produtoSelecionado))
                {
                    // Verificar se o limite de 10 produtos foi atingido
                    if (listBoxProdutosUtilizados.Items.Count < 10)
                    {
                        listBoxProdutosUtilizados.Items.Add(produtoSelecionado);
                    }
                    else
                    {
                        MessageBox.Show("Limite de 10 produtos selecionados atingido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                // Limpar a ListBox de produtos
                listBoxProdutosUtilizados.Items.Clear();
            }
        }

        private void PreencherComboBoxProdutos()
        {
            try
            {
                string query = "SELECT descricao_produto FROM Produtos WHERE estado = 'Ativo'";

                using (SqlConnection connection = new SqlConnection(ConexaoBD.conexao))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // Crie uma lista para armazenar as descrições dos produtos
                        List<string> descricoesProdutos = new List<string>();

                        // Itere pelos registros retornados e adicione as descrições dos produtos à lista
                        while (reader.Read())
                        {
                            string descricaoProduto = (string)reader["descricao_produto"];
                            descricoesProdutos.Add(descricaoProduto);
                        }

                        // Atribua a lista de descrições dos produtos à propriedade DataSource da ComboBox
                        comboBoxProdutosUtilizados.DataSource = descricoesProdutos;

                        // Desabilite a seleção automática do primeiro item
                        comboBoxProdutosUtilizados.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao preencher a ComboBox de produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
