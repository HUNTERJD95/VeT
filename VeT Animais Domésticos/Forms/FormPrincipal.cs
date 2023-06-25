using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeT_Animais_Domésticos.Forms.Produtos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            FormAnimais FormAnimais = new FormAnimais();
            FormAnimais.Show();
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
    }
}
