using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeT_Animais_Domésticos.Classes;

namespace VeT_Animais_Domésticos.Forms
{
    public partial class FormModificarCliente : Form
    {
        private int id;
        public FormModificarCliente(int clienteId)
        {
            InitializeComponent();
            id = clienteId;
        }

        public string NovoNome { get; set; }
        public string NovoNIF { get; set; }
        public DateTime NovaDataNascimento { get; set; }
        public string NovoTelemovel { get; set; }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            // Validar nome
            if (!Cliente.ValidarNome(textBoxAtualizarNomeCompleto.Text))
            {
                MessageBox.Show("Nome inválido. Insira pelo menos primeiro e último nome e não insira números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar NIF

            if (!Cliente.ValidarNIF(textBoxAtualizarNIF.Text))
            {
                MessageBox.Show("NIF inválido. Deve conter 9 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Fazer update na BD
            Cliente.AtualizarCliente(id, textBoxAtualizarNomeCompleto.Text, textBoxAtualizarNIF.Text, AtualizardateNascimento.Value, textBoxAtualizarTelemovel.Text);



            // Atribuir os novos valores às propriedades correspondentes
            NovoNome = textBoxAtualizarNomeCompleto.Text;
            NovoNIF = textBoxAtualizarNIF.Text;
            NovaDataNascimento = AtualizardateNascimento.Value;
            NovoTelemovel = textBoxAtualizarTelemovel.Text;

            DialogResult = DialogResult.OK; // Definir o resultado do diálogo como OK
            Close(); // Fechar o formulário
        }

        private void FormModificarCliente_Load(object sender, EventArgs e)
        {

        }

        private void textBoxAtualizarNomeCompleto_TextChanged(object sender, EventArgs e)
        {
            
           
            
        }

        public FormModificarCliente(int clienteId, string nomeCliente)
        {
            InitializeComponent();
            id = clienteId;
            NovoNome = nomeCliente;
        }
    }
}
