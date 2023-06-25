using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using VeT_Animais_Domésticos.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Win32;

namespace VeT_Animais_Domésticos.Forms
{
    public partial class RegistoCliente : Form
    {
        private List<Cliente> clientes;
        private string connectionString;

        public RegistoCliente()
        {
            InitializeComponent();
            clientes = new List<Cliente>();
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\cs_ba\\source\\repos\\testeIP\\VeT Animais Domésticos\\VeT Animais Domésticos\\BaseDados\\BaseDados.mdf\";Integrated Security=True";
        }

        private void buttonRegistar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNomeCompleto.Text;
            DateTime dataNascimento = dateNascimento.Value.Date;
            string nif = textBoxNIF.Text;
            string telemovel = textBoxTelemovel.Text;


            // Validar os campos
            if (!Cliente.ValidarNome(nome))
            {
                MessageBox.Show("Nome inválido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Cliente.ValidarNIF(nif))
            {
                MessageBox.Show("NIF inválido! Deve conter 9 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Cliente.ClienteJaRegistrado(nif))
            {
                MessageBox.Show("Já existe um cliente registrado com o mesmo NIF.", "Erro de Registro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Criar um novo cliente
            Cliente cliente = new Cliente(nome, dataNascimento, nif, telemovel);
            clientes.Add(cliente);

            // Inserir o cliente na base de dados
            int numeroCliente = InserirCliente(cliente);

            if (numeroCliente > 0)
            {
                MessageBox.Show($"Cliente registrado com sucesso. Número de cliente: {numeroCliente}. Registe agora o seu animal.",
                    "Registro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao registrar o cliente.", "Erro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Após registo, abrir tabPageAnimal
            tabControlRegistoClienteAnimal.SelectedTab = tabPageAnimal;





        }

        private int InserirCliente(Cliente cliente)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Clientes (Nome, DataNascimento, NIF, Telemovel) VALUES (@Nome, @DataNascimento, @NIF, @Telemovel); SELECT SCOPE_IDENTITY()";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
                    cmd.Parameters.AddWithValue("@NIF", cliente.NIF);
                    cmd.Parameters.AddWithValue("@Telemovel", cliente.Telemovel);

                    try
                    {
                        con.Open();
                        int numeroCliente = Convert.ToInt32(cmd.ExecuteScalar());
                        cliente.NumeroCliente = numeroCliente;
                        return numeroCliente;
                    }
                    catch (Exception ex)
                    {
                        // Tratar exceção
                        return 0;
                    }
                }
            }
        }
        private void buttonAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {

        }

        private void RegistoCliente_Load(object sender, EventArgs e)
        {

        }

        private void buttonVoltarRegistoCliente_Click(object sender, EventArgs e)
        {
            FormConsultarClientes formConsultarClientes = new FormConsultarClientes();
            formConsultarClientes.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void buttonVoltarRegistoAnimal_Click(object sender, EventArgs e)
        {
            // Ao clicar abre a tabPageCliente
            tabControlRegistoClienteAnimal.SelectedTab = tabPageCliente;
        }

        private void buttonRegistarAnimal_Click(object sender, EventArgs e)
        {
            string donoNIF = textBoxDono.Text;
            string dataNascimento = textBoxDataNascimentoAnimal.Text;
            string tipoAnimal = textBoxTipoAnimal.Text;
            string raca = textBoxRacaAnimal.Text;
            string sexo = textBoxSexoAnimal.Text;
            string peso = textBoxPesoAnimal.Text;


            // Validar os campos
            if (!Cliente.ValidarNIF(donoNIF))
            {
                MessageBox.Show("NIF inválido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            double pesoAnimal;
            if (!double.TryParse(peso, out pesoAnimal))
            {
                MessageBox.Show("Peso inválido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar se o dono já está registrado
            if (!Cliente.ClienteJaRegistrado(donoNIF))
            {
                MessageBox.Show("O dono com o NIF fornecido não está registrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Inserir o novo animal na base de dados
            Animal.InserirAnimal(donoNIF, dataNascimento, tipoAnimal, raca, sexo, pesoAnimal);

            MessageBox.Show("Animal registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpar os campos do formulário após o registro
            textBoxDono.Clear();
            textBoxDataNascimentoAnimal.Clear();
            textBoxTipoAnimal.Clear();
            textBoxRacaAnimal.Clear();
            textBoxSexoAnimal.Clear();
            textBoxPesoAnimal.Clear();


        }

        private void textBoxFiliacaoPai_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFiliacaoMae_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxPesoAnimal_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxSexoAnimal_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxRacaAnimal_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxTipoAnimal_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxDataNascimentoAnimal_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelFiliacaoPai_Click(object sender, EventArgs e)
        {
        }

        private void labelFiliacaoMae_Click(object sender, EventArgs e)
        {
        }

        private void labelPesoAnimal_Click(object sender, EventArgs e)
        {
        }

        private void labelSexoAnimal_Click(object sender, EventArgs e)
        {
        }

        private void labelRaçaAnimal_Click(object sender, EventArgs e)
        {
        }

        private void labelTipoAnimal_Click(object sender, EventArgs e)
        {
        }

        private void labelDataNascimentoAnimal_Click(object sender, EventArgs e)
        {
        }

        private void labelDonoNIF_Click(object sender, EventArgs e)
        {
        }
    }
}

