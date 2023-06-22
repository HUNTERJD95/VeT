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
    public partial class AdicionarAnimal : Form
    {
        public AdicionarAnimal()
        {
            InitializeComponent();
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

        private void buttonVoltarRegistoAnimal_Click(object sender, EventArgs e)
        {
            // Fecha o form e abre o form animais
            FormAnimais FormAnimais = new FormAnimais();
            FormAnimais.Show();
            this.Hide();
        }

    }
}
