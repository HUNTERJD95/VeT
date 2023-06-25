using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeT_Animais_Domésticos.Forms
{
    public partial class FormAnimais : Form
    {
        public FormAnimais()
        {
            InitializeComponent();
        }

        private void buttonConsultarAnimal_Click(object sender, EventArgs e)
        {
            // Abre o form ConsultarAnimais e fecha o corrente
            ConsultarAnimais ConsultarAnimais = new ConsultarAnimais();
            ConsultarAnimais.Show();
            this.Hide();
        }

        private void buttonVoltarAnimais_Click(object sender, EventArgs e)
        {
            // Fecha o form animais e abre o form principal
            FormPrincipal FormPrincipal = new FormPrincipal();
            FormPrincipal.Show();
            this.Hide();
        }

        private void buttonAdicionarAnimal_Click(object sender, EventArgs e)
        {
            AdicionarAnimal adicionarAnimal = new AdicionarAnimal();
            adicionarAnimal.Show();
            this.Hide();
        }
    }
}
