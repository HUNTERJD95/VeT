using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeT_Animais_Domésticos.Forms.Consultas;
using VeT_Animais_Domésticos.Forms.Produtos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace VeT_Animais_Domésticos.Forms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            //Abre form pretendido e fecha o corrente
            FormConsultarClientes formConsultarClientes = new FormConsultarClientes();
            formConsultarClientes.Show();
            this.Hide();
        }

        private void buttonAnimais_Click(object sender, EventArgs e)
        {
            // Abre o form Animais e fecha o corrente
            ConsultarAnimais ConsultarAnimais = new ConsultarAnimais();
            ConsultarAnimais.Show();
            this.Hide();

        }

        private void buttonColaboradores_Click(object sender, EventArgs e)
        {
            // Fecha o form atual e abre o form Colaboradores_Principal
            Colaboradores.Colaboradores_Principal colaboradores_Principal = new Colaboradores.Colaboradores_Principal();
            colaboradores_Principal.Show();
            this.Hide();
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            // Fecha o form atual e abre o FormProdutos
            FormProdutos formProdutos = new FormProdutos();
            formProdutos.Show();
            this.Hide();
        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            // Fecha o form atual e abre o form AgendarConsulta
            AgendarConsulta agendarConsulta = new AgendarConsulta();
            agendarConsulta.Show();
            this.Hide();
        }

        private void buttonAtosMedicos_Click(object sender, EventArgs e)
        {
            // Fecha o form atual e abre o form Ato_MedicosPrincipal
            Ato_MedicosPrincipal ato_MedicosPrincipal = new Ato_MedicosPrincipal();
            ato_MedicosPrincipal.Show();
            this.Hide();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

            // Modificação Layout botões Clientes, Animais, Colaboradores, Produtos, Consultas e Atos Médicos

            // Clientes
            buttonClientes.FlatStyle = FlatStyle.Flat;
            buttonClientes.FlatAppearance.BorderSize = 1;
            buttonClientes.FlatAppearance.BorderColor = Color.Blue;

            // Animais
            buttonAnimais.FlatStyle = FlatStyle.Flat;
            buttonAnimais.FlatAppearance.BorderSize = 2;
            buttonAnimais.FlatAppearance.BorderColor = Color.Blue;

            // Colaboradores
            buttonColaboradores.FlatStyle = FlatStyle.Flat;
            buttonColaboradores.FlatAppearance.BorderSize = 2;
            buttonColaboradores.FlatAppearance.BorderColor = Color.Blue;

            // Produtos
            buttonProdutos.FlatStyle = FlatStyle.Flat;
            buttonProdutos.FlatAppearance.BorderSize = 2;
            buttonProdutos.FlatAppearance.BorderColor = Color.Blue;

            // Consultas
            buttonConsultas.FlatStyle = FlatStyle.Flat;
            buttonConsultas.FlatAppearance.BorderSize = 2;
            buttonConsultas.FlatAppearance.BorderColor = Color.Blue;

            // Atos Médicos
            buttonAtosMedicos.FlatStyle = FlatStyle.Flat;
            buttonAtosMedicos.FlatAppearance.BorderSize = 2;
            buttonAtosMedicos.FlatAppearance.BorderColor = Color.Blue;
        }
    }
}
