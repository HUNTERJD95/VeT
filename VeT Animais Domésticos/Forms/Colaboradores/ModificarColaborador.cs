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

namespace VeT_Animais_Domésticos.Forms.Colaboradores
{
    public partial class ModificarColaborador : Form
    {
        private int id;
        public ModificarColaborador(int colaboradorId)
        {
            InitializeComponent();
            id = colaboradorId;


            comboBoxNovoTipoColaborador.Items.Add("Interno");
            comboBoxNovoTipoColaborador.Items.Add("Externo");

            comboBoxNovoFuncaoColaborador.Items.Add("Assistente Veterinário");
            comboBoxNovoFuncaoColaborador.Items.Add("Médico Veterinário");

            comboBoxNovoDisponibilidade.Items.Add("Diurno");
            comboBoxNovoDisponibilidade.Items.Add("Noturno");

            // Botão voltar
            buttonVoltarModificarColaborador.FlatStyle = FlatStyle.Flat;
            buttonVoltarModificarColaborador.FlatAppearance.BorderSize = 2;
            buttonVoltarModificarColaborador.FlatAppearance.BorderColor = Color.Blue;

            // Botão atualizar
            buttonAtualizarColaborador.FlatStyle = FlatStyle.Flat;
            buttonAtualizarColaborador.FlatAppearance.BorderSize = 2;
            buttonAtualizarColaborador.FlatAppearance.BorderColor = Color.Blue;
        }




        public string novoNome { get; set; }
        public DateTime novoDataNascimento { get; set; }
        public string novoNIF { get; set; }
        public string novoTipo { get; set; }
        public string novoFuncao { get; set; }
        public string novoTelemovel { get; set; }
        public string novoDisponibilidade { get; set; }
        public string novoEstado { get; set; }

        private void ModificarColaborador_Load(object sender, EventArgs e)
        {

        }

        private void buttonAtualizarColaborador_Click(object sender, EventArgs e)
        {
            // Validar nome
            if (!Colaborador.VerificarNomeColaborador(textBoxNovoNomeCompletoColaborador.Text))
            {
                MessageBox.Show("Nome inválido. Insira pelo menos primeiro e último nome e não insira números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar NIF
            if (!Colaborador.VerificarNIFColaborador(textBoxNovoNIFColaborador.Text))
            {
                MessageBox.Show("NIF inválido. Deve conter 9 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Atribuir os novos valores às propriedades correspondentes
            novoNome = textBoxNovoNomeCompletoColaborador.Text;
            novoDataNascimento = dateNovoNascimentoColaborador.Value;
            novoNIF = textBoxNovoNIFColaborador.Text;
            novoTipo = comboBoxNovoTipoColaborador.Text;
            novoFuncao = comboBoxNovoFuncaoColaborador.Text;
            novoTelemovel = textBoxNovoTelemovelColaborador.Text;
            novoDisponibilidade = comboBoxNovoDisponibilidade.Text;


            // Fazer update na BD
            Colaborador.AtualizarColaborador(id, novoNome, novoNIF, novoDataNascimento, novoTipo, novoFuncao, novoDisponibilidade, novoTelemovel);
            MessageBox.Show("Dados do colaborador atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK; // Definir o resultado do diálogo como OK
            this.Hide();
        }

        private void buttonVoltarModificarColaborador_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
