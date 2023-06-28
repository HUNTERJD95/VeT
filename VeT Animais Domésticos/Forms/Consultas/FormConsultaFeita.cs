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
using VeT_Animais_Domésticos.Forms.Colaboradores;
using VeT_Animais_Domésticos.Forms.Produtos;

namespace VeT_Animais_Domésticos.Forms
{
    public partial class FormConsultaFeita : Form
    {
        private int idAnimal;
        private int idFichaMedica;

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
            // Preencher combobox diagnosticos
            PreencherComboBoxDiagnosticos();
            // Preencher combobox atos medicos
            PreencherComboBoxAtosMedicos();

            // Execute the query to retrieve the names of collaborators
            string query = "SELECT id, nome FROM Colaboradores WHERE estado = '1'";

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
                            this.idFichaMedica = id;
                            dateTimePickerAtoMedico.Value = (DateTime)reader["data_ato_medico"];
                            comboBoxTipoConsulta.Text = (string)reader["tipo_consulta"];
                            int idColaborador = Convert.ToInt32(reader["id_colaborador"]);
                            comboBoxNomeColaborador.SelectedItem = comboBoxNomeColaborador.Items
                                .OfType<ColaboradorItem>()
                                .FirstOrDefault(item => item.Id == idColaborador);
                            double peso = reader.GetDouble(reader.GetOrdinal("peso"));
                            textBoxPesoAtoMedico.Text = peso.ToString();
                            textBoxObservacoesAtoMedico.Text = (string)reader["observacoes"];
                            textBoxPrescricaoAtoMedico.Text = (string)reader["prescricao_medica"];
                            dateTimePickerProximaVisita.Value = (DateTime)reader["proxima_visita"];
                        }
                    }
                }
            }

            // Populate the ListBox for Atos Medicos
            string queryAtosMedicos = "SELECT a.id, a.descricao FROM Atos_Medicos a INNER JOIN AtosMedicos_Ficha_Medica af ON a.id = af.id_atomedico WHERE af.id_ficha_medica = @ID";
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                using (SqlCommand cmd = new SqlCommand(queryAtosMedicos, con))
                {
                    cmd.Parameters.AddWithValue("@ID", this.idFichaMedica);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["id"];
                            string descricao = (string)reader["descricao"];
                            listBoxAtosMedicosFichaMedica.Items.Add(new AtoMedicoItem(id, descricao));
                        }
                    }
                }
            }

            // Populate the ListBox for Diagnosticos
            string queryDiagnosticos = "SELECT d.Id, d.Nome FROM Diagnosticos d INNER JOIN Diagnosticos_Ficha_Medica df ON d.Id = df.Id_diagnostico WHERE df.Id_ficha_medica = @ID";
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                using (SqlCommand cmd = new SqlCommand(queryDiagnosticos, con))
                {
                    cmd.Parameters.AddWithValue("@ID", this.idFichaMedica);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["Id"];
                            string nome = (string)reader["Nome"];
                            listBoxDiagnosticoFichaMedica.Items.Add(new DiagnosticoItem(id, nome));
                        }
                    }
                }
            }

            // Populate the ListBox for Produtos Utilizados
            string queryProdutos = "SELECT p.cod_produto, p.descricao_produto, p.quantidade_armazem FROM Produtos p INNER JOIN Ficha_Medica_Produtos fp ON p.cod_produto = fp.id_produto WHERE fp.id_ficha_medica = @ID";
            using (SqlConnection con = new SqlConnection(ConexaoBD.conexao))
            {
                using (SqlCommand cmd = new SqlCommand(queryProdutos, con))
                {
                    cmd.Parameters.AddWithValue("@ID", this.idFichaMedica);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int codigoProduto = (int)reader["cod_produto"];
                            string descricaoProduto = (string)reader["descricao_produto"];
                            int quantidadeArmazem = Convert.ToInt32(reader["quantidade_armazem"]);
                            listBoxProdutosUtilizados.Items.Add(new ProdutoItem(codigoProduto, descricaoProduto, quantidadeArmazem));
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

        private void buttonGuardarFichaMedica_Click(object sender, EventArgs e)
        {
            DateTime dataAtoMedico = dateTimePickerAtoMedico.Value;
            string tipoConsulta = comboBoxTipoConsulta.Text;
            int idColaborador = Convert.ToInt32(comboBoxNomeColaborador.SelectedValue);
            float peso = float.Parse(textBoxPesoAtoMedico.Text);
            string observacoes = textBoxObservacoesAtoMedico.Text;
            string prescricao = textBoxPrescricaoAtoMedico.Text;
            DateTime proximaVisita = dateTimePickerProximaVisita.Value;

            ListBox.ObjectCollection listaProdutos = listBoxProdutosUtilizados.Items;
            ListBox.ObjectCollection listaDiagnosticos = listBoxDiagnosticoFichaMedica.Items;
            ListBox.ObjectCollection listaAtos = listBoxAtosMedicosFichaMedica.Items;

            // validações

            if (tipoConsulta == null)
            {
                MessageBox.Show("Insira um tipo de consulta");
                return;
            }

            if (peso == 0)
            {
                MessageBox.Show("Insira um peso");
                return;
            }

            if (observacoes == null)
            {
                MessageBox.Show("Insira observações");
                return;
            }

            if (prescricao == null)
            {
                MessageBox.Show("Insira uma prescrição");
                return;
            }

            if (listaProdutos.Count == 0)
            {
                MessageBox.Show("Insira pelo menos um produto");
                return;
            }

            if (listaDiagnosticos.Count == 0)
            {
                MessageBox.Show("Insira pelo menos um diagnóstico");
                return;
            }

            if (listaAtos.Count == 0)
            {
                MessageBox.Show("Insira pelo menos um ato médico");
                return;
            }

            // guardar na BD
            // chamar GuardarFichaMedica
            // FichaMedica fichaMedica = new FichaMedica();
            if (this.idFichaMedica > 0)
            {
                FichaMedica.AtualizarFichaMedica(
                    this.idFichaMedica, dataAtoMedico, tipoConsulta,
                    idColaborador, peso, observacoes, prescricao,
                    proximaVisita, listaProdutos, listaDiagnosticos, listaAtos
                );
            }
            else
            {
                FichaMedica.CriarFichaMedica(
                    this.idAnimal, dataAtoMedico, tipoConsulta,
                    idColaborador, peso, observacoes, prescricao,
                    proximaVisita, listaProdutos, listaDiagnosticos, listaAtos
                );
            }


            MessageBox.Show("Ficha médica guardada com sucesso");
        }

        private void buttonVoltarFichaMedica_Click(object sender, EventArgs e)
        {
            // Abre o form ConsultarAnimais
            ConsultarAnimais ConsultarAnimais = new ConsultarAnimais();
            ConsultarAnimais.Show();
            this.Hide();
        }

        private void listBoxProdutosUtilizados_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDiagnosticoFichaMedica_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar se o limite de 5 itens foi atingido
            if (listBoxDiagnosticoFichaMedica.Items.Count < 5)
            {
                // Verificar se há um item selecionado na ComboBox
                if (comboBoxDiagnosticoFichaMedica.SelectedItem != null)
                {
                    bool itemAlreadySelected = false;

                    // Verificar se o item já foi selecionado anteriormente na ListBox
                    foreach (var item in listBoxDiagnosticoFichaMedica.Items)
                    {
                        if (item.ToString() == comboBoxDiagnosticoFichaMedica.SelectedItem.ToString())
                        {
                            itemAlreadySelected = true;
                            break;
                        }
                    }

                    // Se o item ainda não foi selecionado anteriormente, adicioná-lo à ListBox
                    if (!itemAlreadySelected)
                    {
                        listBoxDiagnosticoFichaMedica.Items.Add(comboBoxDiagnosticoFichaMedica.SelectedItem);
                    }
                    else
                    {
                        MessageBox.Show("Este item já foi selecionado.", "Item Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
                    bool itemAlreadySelected = false;

                    // Verificar se o item já foi selecionado anteriormente na ListBox
                    foreach (var item in listBoxAtosMedicosFichaMedica.Items)
                    {
                        if (item.ToString() == comboBoxAtoMedico.SelectedItem.ToString())
                        {
                            itemAlreadySelected = true;
                            break;
                        }
                    }

                    // Se o item ainda não foi selecionado anteriormente, adicioná-lo à ListBox
                    if (!itemAlreadySelected)
                    {
                        listBoxAtosMedicosFichaMedica.Items.Add(comboBoxAtoMedico.SelectedItem);
                    }
                    else
                    {
                        MessageBox.Show("Este item já foi selecionado.", "Item Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
                ProdutoItem produtoSelecionado = (ProdutoItem)comboBoxProdutosUtilizados.SelectedItem;

                bool itemAlreadySelected = false;

                // Verificar se o item já existe na ListBox
                foreach (var item in listBoxProdutosUtilizados.Items)
                {
                    if (item.ToString() == produtoSelecionado.ToString())
                    {
                        itemAlreadySelected = true;
                        break;
                    }
                }

                // Se o item ainda não foi selecionado anteriormente, adicioná-lo à ListBox
                if (!itemAlreadySelected)
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
                else
                {
                    MessageBox.Show("Este item já foi selecionado.", "Item Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // try
            //{
            string query = "SELECT cod_produto, descricao_produto, quantidade_armazem FROM Produtos WHERE estado = 'Ativo'";

            using (SqlConnection connection = new SqlConnection(ConexaoBD.conexao))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Crie uma lista para armazenar as descrições dos produtos
                    List<ProdutoItem> listaProdutos = new List<ProdutoItem>();

                    // Itere pelos registros retornados e adicione as descrições dos produtos à lista
                    while (reader.Read())
                    {
                        int codigoProduto = Convert.ToInt32(reader["cod_produto"]);
                        string descricaoProduto = (string)reader["descricao_produto"];
                        int quantidadeArmazem = Convert.ToInt32(reader["quantidade_armazem"]);

                        comboBoxProdutosUtilizados.Items.Add(new ProdutoItem(codigoProduto, descricaoProduto, quantidadeArmazem));
                    }

                    // Atribua a lista de descrições dos produtos à propriedade DataSource da ComboBox
                    //comboBoxProdutosUtilizados.DataSource = listaProdutos;

                    // Desabilite a seleção automática do primeiro item
                    comboBoxProdutosUtilizados.SelectedIndex = -1;
                }
            }
            // }
            // catch (Exception ex)
            //{
            // MessageBox.Show("Ocorreu um erro ao preencher a ComboBox de produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        // Preencher a ComboBox de diagnósticos
        private void PreencherComboBoxDiagnosticos()
        {
            try
            {
                string query = "SELECT Id, Nome FROM Diagnosticos";

                using (SqlConnection connection = new SqlConnection(ConexaoBD.conexao))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // Crie uma lista para armazenar as descrições dos diagnósticos
                        List<DiagnosticoItem> listaDiagnosticos = new List<DiagnosticoItem>();

                        // Itere pelos registros retornados e adicione as descrições dos diagnósticos à lista
                        while (reader.Read())
                        {
                            int codigoDiagnostico = Convert.ToInt32(reader["Id"]);
                            string descricaoDiagnostico = (string)reader["Nome"];

                            comboBoxDiagnosticoFichaMedica.Items.Add(new DiagnosticoItem(codigoDiagnostico, descricaoDiagnostico));
                        }

                        // Atribua a lista de descrições dos diagnósticos à propriedade DataSource da ComboBox
                        //comboBoxDiagnosticoFichaMedica.DataSource = listaDiagnosticos;

                        // Desabilite a seleção automática do primeiro item
                        comboBoxDiagnosticoFichaMedica.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao preencher a ComboBox de diagnósticos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Preencher a ComboBox de Atos medicos
        private void PreencherComboBoxAtosMedicos()
        {
            try
            {
                string query = "SELECT id, descricao FROM Atos_Medicos WHERE estado = 'Ativo'";

                using (SqlConnection connection = new SqlConnection(ConexaoBD.conexao))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // Crie uma lista para armazenar as descrições dos atos medicos
                        List<AtoMedicoItem> listaAtosMedicos = new List<AtoMedicoItem>();

                        // Itere pelos registros retornados e adicione as descrições dos atos medicos à lista
                        while (reader.Read())
                        {
                            int codigoAtoMedico = Convert.ToInt32(reader["id"]);
                            string descricaoAtoMedico = (string)reader["descricao"];

                            comboBoxAtoMedico.Items.Add(new AtoMedicoItem(codigoAtoMedico, descricaoAtoMedico));
                        }

                        // Atribua a lista de descrições dos atos medicos à propriedade DataSource da ComboBox
                        //comboBoxAtoMedico.DataSource = listaAtosMedicos;

                        // Desabilite a seleção automática do primeiro item
                        comboBoxAtoMedico.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao preencher a ComboBox de atos medicos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxAtosMedicosFichaMedica_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxAtosMedicosFichaMedica.SelectedItem != null)
            {
                listBoxAtosMedicosFichaMedica.Items.Remove(listBoxAtosMedicosFichaMedica.SelectedItem);
            }
        }

        private void listBoxDiagnosticoFichaMedica_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxDiagnosticoFichaMedica.SelectedItem != null)
            {
                listBoxDiagnosticoFichaMedica.Items.Remove(listBoxDiagnosticoFichaMedica.SelectedItem);
            }
        }

        private void listBoxProdutosUtilizados_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxProdutosUtilizados.SelectedItem != null)
            {
                listBoxProdutosUtilizados.Items.Remove(listBoxProdutosUtilizados.SelectedItem);
            }
        }
    }
}
