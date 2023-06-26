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
    public partial class AlterarAtoMedico : Form
    {
        private int atomedicoId;
        internal float novoCusto;

        public AlterarAtoMedico(int atomedicoId)
        {
            InitializeComponent();
            this.atomedicoId = atomedicoId;

            // Botão voltar
            buttonVoltarAdicionarAtoMedico.FlatStyle = FlatStyle.Flat;
            buttonVoltarAdicionarAtoMedico.FlatAppearance.BorderSize = 2;
            buttonVoltarAdicionarAtoMedico.FlatAppearance.BorderColor = Color.Blue;

            // Botão alterar
            buttonAlterarAtoMedico.FlatStyle = FlatStyle.Flat;
            buttonAlterarAtoMedico.FlatAppearance.BorderSize = 2;
            buttonAlterarAtoMedico.FlatAppearance.BorderColor = Color.Blue;
        }

        private void buttonVoltarAdicionarAtoMedico_Click(object sender, EventArgs e)
        {
            // Fecha este form e abre o form Ato_MedicosPrincipal
            this.Close();
            Ato_MedicosPrincipal ato_MedicosPrincipal = new Ato_MedicosPrincipal();
            ato_MedicosPrincipal.Show();
        }

        private void buttonAlterarAtoMedico_Click(object sender, EventArgs e)
        {
            // Atribuir os valores atualizados às propriedades correspondentes na classe Ato_Medico
            novoNome = comboBoxNovoNomeAtoMedico.Text;
            novoDescricao = textBoxNovoDescricaoAtoMedico.Text;

            if (float.TryParse(textBoxNovoCustoAtoMedico.Text, out float novoCusto))
            {
                // Atualizar os dados do Ato Médico no banco de dados
                Ato_Medico.AtualizarAtoMedico(atomedicoId, novoNome, novoDescricao, novoCusto);

                MessageBox.Show("Dados do ato médico atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Valor inválido para o custo do ato médico!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string novoNome { get; set; }
        public string novoDescricao { get; set; }
        public float novoPreco { get; set; }
        public DateTime novoData_registo { get; set; }
        public string novoEstado { get; set; }
    }
}
