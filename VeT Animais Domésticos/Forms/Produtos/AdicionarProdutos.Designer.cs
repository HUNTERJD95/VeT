namespace VeT_Animais_Domésticos.Forms.Produtos
{
    partial class AdicionarProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarProdutos));
            comboBoxTipoProduto = new ComboBox();
            labelTipoProduto = new Label();
            labelDescricaoProduto = new Label();
            textBoxDescricaoProduto = new TextBox();
            labelQuantidadeProduto = new Label();
            numericUpDownQuantidade = new NumericUpDown();
            labelPrecoProduto = new Label();
            textBoxPrecoProduto = new TextBox();
            buttonVoltarProdutos = new Button();
            buttonRegistarProduto = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTipoProduto
            // 
            comboBoxTipoProduto.FormattingEnabled = true;
            comboBoxTipoProduto.Location = new Point(261, 83);
            comboBoxTipoProduto.Name = "comboBoxTipoProduto";
            comboBoxTipoProduto.Size = new Size(121, 23);
            comboBoxTipoProduto.TabIndex = 0;
            // 
            // labelTipoProduto
            // 
            labelTipoProduto.AutoSize = true;
            labelTipoProduto.BackColor = Color.Transparent;
            labelTipoProduto.Location = new Point(176, 86);
            labelTipoProduto.Name = "labelTipoProduto";
            labelTipoProduto.Size = new Size(79, 15);
            labelTipoProduto.TabIndex = 1;
            labelTipoProduto.Text = "Tipo Produto:";
            // 
            // labelDescricaoProduto
            // 
            labelDescricaoProduto.AutoSize = true;
            labelDescricaoProduto.BackColor = Color.Transparent;
            labelDescricaoProduto.Location = new Point(194, 125);
            labelDescricaoProduto.Name = "labelDescricaoProduto";
            labelDescricaoProduto.Size = new Size(61, 15);
            labelDescricaoProduto.TabIndex = 2;
            labelDescricaoProduto.Text = "Descrição:";
            // 
            // textBoxDescricaoProduto
            // 
            textBoxDescricaoProduto.Location = new Point(261, 122);
            textBoxDescricaoProduto.Name = "textBoxDescricaoProduto";
            textBoxDescricaoProduto.Size = new Size(527, 23);
            textBoxDescricaoProduto.TabIndex = 3;
            // 
            // labelQuantidadeProduto
            // 
            labelQuantidadeProduto.AutoSize = true;
            labelQuantidadeProduto.BackColor = Color.Transparent;
            labelQuantidadeProduto.Location = new Point(109, 163);
            labelQuantidadeProduto.Name = "labelQuantidadeProduto";
            labelQuantidadeProduto.Size = new Size(146, 15);
            labelQuantidadeProduto.TabIndex = 4;
            labelQuantidadeProduto.Text = "Quantidade em Armazém:";
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Location = new Point(262, 161);
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(120, 23);
            numericUpDownQuantidade.TabIndex = 5;
            // 
            // labelPrecoProduto
            // 
            labelPrecoProduto.AutoSize = true;
            labelPrecoProduto.BackColor = Color.Transparent;
            labelPrecoProduto.Location = new Point(420, 163);
            labelPrecoProduto.Name = "labelPrecoProduto";
            labelPrecoProduto.Size = new Size(85, 15);
            labelPrecoProduto.TabIndex = 6;
            labelPrecoProduto.Text = "Preço Unitário:";
            // 
            // textBoxPrecoProduto
            // 
            textBoxPrecoProduto.Location = new Point(511, 161);
            textBoxPrecoProduto.Name = "textBoxPrecoProduto";
            textBoxPrecoProduto.Size = new Size(100, 23);
            textBoxPrecoProduto.TabIndex = 7;
            // 
            // buttonVoltarProdutos
            // 
            buttonVoltarProdutos.Location = new Point(12, 405);
            buttonVoltarProdutos.Name = "buttonVoltarProdutos";
            buttonVoltarProdutos.Size = new Size(87, 33);
            buttonVoltarProdutos.TabIndex = 8;
            buttonVoltarProdutos.Text = "Voltar";
            buttonVoltarProdutos.UseVisualStyleBackColor = true;
            buttonVoltarProdutos.Click += buttonVoltarProdutos_Click;
            // 
            // buttonRegistarProduto
            // 
            buttonRegistarProduto.Location = new Point(613, 281);
            buttonRegistarProduto.Name = "buttonRegistarProduto";
            buttonRegistarProduto.Size = new Size(118, 46);
            buttonRegistarProduto.TabIndex = 9;
            buttonRegistarProduto.Text = "Registar Produto";
            buttonRegistarProduto.UseVisualStyleBackColor = true;
            buttonRegistarProduto.Click += buttonRegistarProduto_Click;
            // 
            // AdicionarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRegistarProduto);
            Controls.Add(buttonVoltarProdutos);
            Controls.Add(textBoxPrecoProduto);
            Controls.Add(labelPrecoProduto);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(labelQuantidadeProduto);
            Controls.Add(textBoxDescricaoProduto);
            Controls.Add(labelDescricaoProduto);
            Controls.Add(labelTipoProduto);
            Controls.Add(comboBoxTipoProduto);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdicionarProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Produtos";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTipoProduto;
        private Label labelTipoProduto;
        private Label labelDescricaoProduto;
        private TextBox textBoxDescricaoProduto;
        private Label labelQuantidadeProduto;
        private NumericUpDown numericUpDownQuantidade;
        private Label labelPrecoProduto;
        private TextBox textBoxPrecoProduto;
        private Button buttonVoltarProdutos;
        private Button buttonRegistarProduto;
    }
}