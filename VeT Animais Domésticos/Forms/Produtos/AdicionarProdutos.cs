using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeT_Animais_Domésticos.Classes.Produtos;

namespace VeT_Animais_Domésticos.Forms.Produtos
{
    public partial class AdicionarProdutos : Form
    {
        public AdicionarProdutos()
        {
            InitializeComponent();

            comboBoxTipoProduto.Items.Add("Fármaco");
            comboBoxTipoProduto.Items.Add("Alimentar");
            comboBoxTipoProduto.Items.Add("Suplementar");

            // Botão registar produto
            buttonRegistarProduto.FlatAppearance.BorderSize = 2;
            buttonRegistarProduto.FlatStyle = FlatStyle.Flat;
            buttonRegistarProduto.ForeColor = Color.Blue;
            
            // Botão voltar
            buttonVoltarProdutos.FlatAppearance.BorderSize = 2;
            buttonVoltarProdutos.FlatStyle = FlatStyle.Flat;
            buttonVoltarProdutos.ForeColor = Color.Blue;
        }

        private void buttonRegistarProduto_Click(object sender, EventArgs e)
        {
            string tipoProduto = comboBoxTipoProduto.Text;
            string descricao = textBoxDescricaoProduto.Text;
            int quantidadeEmArmazem = (int)numericUpDownQuantidade.Value;
            decimal precoUnitario;

            if (string.IsNullOrEmpty(tipoProduto))
            {
                MessageBox.Show("Selecione um tipo de produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(descricao))
            {
                MessageBox.Show("Digite uma descrição para o produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se já existir um produto com a mesma descrição, não permitir o registo
            if (Produto.ExisteProduto(descricao))
            {
                MessageBox.Show("Este produto já foi registado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantidadeEmArmazem <= 0)
            {
                MessageBox.Show("Selecione uma quantidade válida. Não pode ser negativa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBoxPrecoProduto.Text, out precoUnitario) || precoUnitario <= 0)
            {
                MessageBox.Show("Digite um preço válido para o produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Criar um novo produto
            Produto produto = new Produto(tipoProduto, descricao, quantidadeEmArmazem, precoUnitario, "ativo");

            // Inserir o produto na base de dados
            Produto.InserirProduto(produto.Tipo, produto.Descricao, produto.QuantidadeEmArmazem, produto.PrecoUnitario, produto.Estado);

            int numeroProduto = Produto.ObterNumeroProduto();

            if (numeroProduto > 0)
            {
                MessageBox.Show($"Produto registrado com sucesso. Número do produto: {numeroProduto}.",
                    "Registro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao registrar o produto.", "Erro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();
        }

        private void buttonVoltarProdutos_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}