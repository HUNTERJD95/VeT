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
using VeT_Animais_Domésticos.Classes.Produtos;

namespace VeT_Animais_Domésticos.Forms.Produtos
{
    public partial class ModificarProduto : Form
    {
        private int id;
        public ModificarProduto(int produtoId)
        {
            InitializeComponent();
            id = produtoId;

            comboBoxNovoTipoProduto.Items.Add("Fármaco");
            comboBoxNovoTipoProduto.Items.Add("Alimentar");
            comboBoxNovoTipoProduto.Items.Add("Suplementar");
        }

        public string novoTipoProduto { get; set; }
        public string novoDescricaoProduto { get; set; }
        public int novoQuantidadeArmazem { get; set; }
        public decimal novoPrecoUnitario { get; set; }
        public string novoEstado { get; set; }

        private void buttonAtualizarProduto_Click(object sender, EventArgs e)
        {
            

            // Atribuir os novos valores às propriedades correspondentes
           novoTipoProduto = comboBoxNovoTipoProduto.Text;
            novoDescricaoProduto = textBoxNovoDescricaoProduto.Text;
            novoQuantidadeArmazem = (int)numericUpDownNovoQuantidade.Value;
            novoPrecoUnitario = decimal.Parse(textBoxNovoPrecoProduto.Text);
           
            


            // Fazer update na BD
           Produto.AtualizarProduto(id, novoTipoProduto, novoDescricaoProduto, novoQuantidadeArmazem, novoPrecoUnitario, novoEstado);

            DialogResult = DialogResult.OK; // Definir o resultado do diálogo como OK
            this.Hide();
        }
        private void buttonVoltarProdutos_Click(object sender, EventArgs e)
        {
           
        }
    }
}

