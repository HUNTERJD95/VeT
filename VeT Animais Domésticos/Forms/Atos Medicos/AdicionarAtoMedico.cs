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

namespace VeT_Animais_Domésticos.Forms.Atos_Medicos
{
    public partial class AdicionarAtoMedico : Form
    {
        public AdicionarAtoMedico()
        {
            InitializeComponent();

            // Botão voltar
            buttonVoltarAdicionarAtoMedico.FlatStyle = FlatStyle.Flat;
            buttonVoltarAdicionarAtoMedico.FlatAppearance.BorderSize = 2;
            buttonVoltarAdicionarAtoMedico.FlatAppearance.BorderColor = Color.Blue;

            // Botão registar
            buttonRegistarAtoMedico.FlatStyle = FlatStyle.Flat;
            buttonRegistarAtoMedico.FlatAppearance.BorderSize = 2;
            buttonRegistarAtoMedico.FlatAppearance.BorderColor = Color.Blue;
            

        }

        private void buttonVoltarAdicionarAtoMedico_Click(object sender, EventArgs e)
        {
            // Fecha este form e abre o form Ato_MedicosPrincipal
            this.Close();
            Ato_MedicosPrincipal ato_MedicosPrincipal = new Ato_MedicosPrincipal();
            ato_MedicosPrincipal.Show();
        }

        private void buttonRegistarAtoMedico_Click(object sender, EventArgs e)
        {
            string nome = comboBoxNomeAtoMedico.Text;
            string descricao = textBoxDescricaoAtoMedico.Text;
            DateTime data_registo = DateTime.Now;
            string estado = "Ativo";

            if (comboBoxNomeAtoMedico.SelectedItem == null)
            {
                MessageBox.Show("Tem de selecionar um Ato Médico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxDescricaoAtoMedico.Text))
            {
                MessageBox.Show("Tem de inserir uma descrição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(textBoxCustoAtoMedico.Text, out float custo))
            {
                MessageBox.Show("O custo inserido não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se a descrição já existe na base de dados
            if (Ato_Medico.VerificarDescricaoAtoMedico(descricao))
            {
                MessageBox.Show("A descrição inserida já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Ato_Medico.ObterNumeroAtoMedico() + 1;
            Ato_Medico.InserirAto(id, nome, descricao, custo, data_registo, estado);
            MessageBox.Show("Ato Médico inserido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

        }

        private void AdicionarAtoMedico_Load(object sender, EventArgs e)
        {

        }
    }
}
