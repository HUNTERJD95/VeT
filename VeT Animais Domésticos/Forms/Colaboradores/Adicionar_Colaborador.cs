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
    public partial class Adicionar_Colaborador : Form
    {
        public Adicionar_Colaborador()
        {
            InitializeComponent();

            comboBoxTipoColaborador.Items.Add("Interno");
            comboBoxTipoColaborador.Items.Add("Externo");

            comboBoxFuncaoColaborador.Items.Add("Assistente Veterinário");
            comboBoxFuncaoColaborador.Items.Add("Médico Veterinário");

            comboBoxDisponibilidade.Items.Add("Diurno");
            comboBoxDisponibilidade.Items.Add("Noturno");


            // Botão voltar
            buttonVoltarRegistoColaborador.FlatStyle = FlatStyle.Flat;
            buttonVoltarRegistoColaborador.FlatAppearance.BorderSize = 2;
            buttonVoltarRegistoColaborador.FlatAppearance.BorderColor = Color.Blue;

            // Botão registar
            buttonRegistarAdicionarColaborador.FlatStyle = FlatStyle.Flat;
            buttonRegistarAdicionarColaborador.FlatAppearance.BorderSize = 2;
            buttonRegistarAdicionarColaborador.FlatAppearance.BorderColor = Color.Blue;
        }




        private void buttonVoltarRegistoColaborador_Click(object sender, EventArgs e)
        {
            // Fecha form e abre o form Colaboradores_Principal
            this.Close();
            Colaboradores_Principal colaboradores_Principal = new Colaboradores_Principal();
            colaboradores_Principal.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegistar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNomeCompletoColaborador.Text;
            string nif = textBoxNIFColaborador.Text;
            DateTime dataNascimento = dateNascimentoColaborador.Value.Date;
            string tipoColaborador = comboBoxTipoColaborador.Text;
            string funcaoColaborador = comboBoxFuncaoColaborador.Text;
            string disponibilidadeColaborador = comboBoxDisponibilidade.Text;
            string telemovel = textBoxTelemovelColaborador.Text;

            // Validar os campos
            if (!Colaborador.VerificarNomeColaborador(nome))
            {
                MessageBox.Show("Nome inválido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Colaborador.VerificarNIFColaborador(nif))
            {
                MessageBox.Show("NIF inválido! Deve conter 9 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Colaborador.ColaboradorJaRegistrado(nif))
            {
                MessageBox.Show("Já existe um cliente registrado com o mesmo NIF.", "Erro de Registro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Criar um novo colaborador
            Colaborador colaborador = new Colaborador(nome, nif, dataNascimento, tipoColaborador, funcaoColaborador, disponibilidadeColaborador, telemovel);

            // Inserir o colaborador na base de dados
            Colaborador.InserirColaborador(colaborador.Nome, colaborador.NIF, colaborador.DataNascimento, colaborador.TipoColaborador, colaborador.FuncaoColaborador, colaborador.DisponibilidadeColaborador, colaborador.Telemovel);

            int numeroColaborador = Colaborador.ObterNumeroColaborador();

            if (numeroColaborador > 0)
            {
                MessageBox.Show($"IdColaborador registrado com sucesso. Número de colaborador: {numeroColaborador}.",
                    "Registro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao registrar o colaborador.", "Erro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();


        }
    }
}
