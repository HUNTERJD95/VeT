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

            buttonAtualizarProduto.FlatStyle = FlatStyle.Flat;
            buttonAtualizarProduto.FlatAppearance.BorderSize = 2;
            buttonAtualizarProduto.FlatAppearance.BorderColor = Color.Blue;

            buttonVoltarProdutos.FlatStyle = FlatStyle.Flat;
            buttonVoltarProdutos.FlatAppearance.BorderSize = 2;
            buttonVoltarProdutos.FlatAppearance.BorderColor = Color.Blue;
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

            if (comboBoxNovoTipoProduto == null)
            {
                MessageBox.Show("Tem de selecionar um tipo de produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxNovoDescricaoProduto.Text == "")
            {
                MessageBox.Show("Tem de inserir uma descrição para o produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numericUpDownNovoQuantidade.Value < 0)
            {
                MessageBox.Show("Não existem quantidades negativas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxNovoPrecoProduto.Text == "")
            {
                MessageBox.Show("Tem de inserir um preço para o produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Fazer update na BD
            Produto.AtualizarProduto(id, novoTipoProduto, novoDescricaoProduto, novoQuantidadeArmazem, novoPrecoUnitario, novoEstado);

            DialogResult = DialogResult.OK; // Definir o resultado do diálogo como OK
            this.Hide();
        }

        private void buttonVoltarProdutos_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

