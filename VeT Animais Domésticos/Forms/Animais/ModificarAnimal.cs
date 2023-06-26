using System;
using System.Windows.Forms;
using VeT_Animais_Domésticos.Classes;

namespace VeT_Animais_Domésticos.Forms
{
    public partial class ModificarAnimal : Form
    {
        public Animal animal;

        public string NovodonoNIF { get; set; }
        public string NovaDataNascimento { get; set; }
        public string NovoTipo { get; set; }
        public string NovaRaca { get; set; }
        public string NovoSexo { get; set; }
        public double NovoPeso { get; set; }


        // Adicione outras propriedades relevantes do animal aqui

        public ModificarAnimal()
        {
            InitializeComponent();

            // Botão voltar
            buttonVoltarModificarAnimal.FlatStyle = FlatStyle.Flat;
            buttonVoltarModificarAnimal.FlatAppearance.BorderSize = 2;
            buttonVoltarModificarAnimal.FlatAppearance.BorderColor = Color.Blue;

            // Botão modificar
            buttonModificarAnimalFinal.FlatStyle = FlatStyle.Flat;
            buttonModificarAnimalFinal.FlatAppearance.BorderSize = 2;
            buttonModificarAnimalFinal.FlatAppearance.BorderColor = Color.Blue;
        }

        public ModificarAnimal(int id) : this()
        {
            // Recuperar os detalhes do animal do banco de dados usando o ID
            animal = Animal.ObterAnimalPorId(id);


        }

        private void ModificarAnimal_Load(object sender, EventArgs e)
        {
            // Preencher os campos do formulário com os detalhes do animal
            textBoxDono.Text = animal.DonoNIF.ToString();
            textBoxModificarRacaAnimal.Text = animal.Raca;
            textBoxModificarSexoAnimal.Text = animal.Sexo;
            textBoxModificarPesoAnimal.Text = animal.Peso.ToString();
            textBoxModificarDataNascimentoAnimal.Text = animal.DataNascimento.ToString();
            textBoxModificarTipoAnimal.Text = animal.TipoAnimal;
        }


        private void buttonVoltarModificarAnimal_Click(object sender, EventArgs e)
        {
            // Fechar o formulário
            Close();
        }

        private void buttonModificarAnimalFinal_Click(object sender, EventArgs e)
        {
            // Valide os campos do formulário, se necessário

            // Atualize o animal no banco de dados com os novos valores
            if (double.TryParse(textBoxModificarPesoAnimal.Text, out double novoPeso))
            {

                Animal.AtualizarAnimal(animal.Id, textBoxDono.Text, textBoxModificarDataNascimentoAnimal.Text, textBoxModificarTipoAnimal.Text, textBoxModificarRacaAnimal.Text, textBoxModificarSexoAnimal.Text, novoPeso);

                // Atribua os novos valores às propriedades correspondentes
                NovodonoNIF = textBoxDono.Text;
                NovaDataNascimento = textBoxModificarDataNascimentoAnimal.Text;
                NovoTipo = textBoxModificarTipoAnimal.Text;
                NovaRaca = textBoxModificarRacaAnimal.Text;
                NovoSexo = textBoxModificarSexoAnimal.Text;
                NovoPeso = novoPeso;

                // Mensagem de sucesso
                MessageBox.Show("Animal atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close(); // Fechar o formulário
            }
            else
            {
                MessageBox.Show("O valor do peso inserido é inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}