namespace VeT_Animais_Domésticos.Forms.Produtos
{
    partial class ModificarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarProduto));
            buttonAtualizarProduto = new Button();
            buttonVoltarProdutos = new Button();
            textBoxNovoPrecoProduto = new TextBox();
            labelPrecoProduto = new Label();
            numericUpDownNovoQuantidade = new NumericUpDown();
            labelQuantidadeProduto = new Label();
            textBoxNovoDescricaoProduto = new TextBox();
            labelDescricaoProduto = new Label();
            labelTipoProduto = new Label();
            comboBoxNovoTipoProduto = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNovoQuantidade).BeginInit();
            SuspendLayout();
            // 
            // buttonAtualizarProduto
            // 
            buttonAtualizarProduto.Location = new Point(670, 392);
            buttonAtualizarProduto.Name = "buttonAtualizarProduto";
            buttonAtualizarProduto.Size = new Size(118, 46);
            buttonAtualizarProduto.TabIndex = 19;
            buttonAtualizarProduto.Text = "Atualizar Produto";
            buttonAtualizarProduto.UseVisualStyleBackColor = true;
            buttonAtualizarProduto.Click += buttonAtualizarProduto_Click;
            // 
            // buttonVoltarProdutos
            // 
            buttonVoltarProdutos.Location = new Point(12, 405);
            buttonVoltarProdutos.Name = "buttonVoltarProdutos";
            buttonVoltarProdutos.Size = new Size(87, 33);
            buttonVoltarProdutos.TabIndex = 18;
            buttonVoltarProdutos.Text = "Voltar";
            buttonVoltarProdutos.UseVisualStyleBackColor = true;
            buttonVoltarProdutos.Click += buttonVoltarProdutos_Click;
            // 
            // textBoxNovoPrecoProduto
            // 
            textBoxNovoPrecoProduto.Location = new Point(271, 201);
            textBoxNovoPrecoProduto.Name = "textBoxNovoPrecoProduto";
            textBoxNovoPrecoProduto.Size = new Size(100, 23);
            textBoxNovoPrecoProduto.TabIndex = 17;
            // 
            // labelPrecoProduto
            // 
            labelPrecoProduto.AutoSize = true;
            labelPrecoProduto.BackColor = Color.Transparent;
            labelPrecoProduto.Location = new Point(180, 209);
            labelPrecoProduto.Name = "labelPrecoProduto";
            labelPrecoProduto.Size = new Size(85, 15);
            labelPrecoProduto.TabIndex = 16;
            labelPrecoProduto.Text = "Preço Unitário:";
            // 
            // numericUpDownNovoQuantidade
            // 
            numericUpDownNovoQuantidade.Location = new Point(271, 155);
            numericUpDownNovoQuantidade.Name = "numericUpDownNovoQuantidade";
            numericUpDownNovoQuantidade.Size = new Size(120, 23);
            numericUpDownNovoQuantidade.TabIndex = 15;
            // 
            // labelQuantidadeProduto
            // 
            labelQuantidadeProduto.AutoSize = true;
            labelQuantidadeProduto.BackColor = Color.Transparent;
            labelQuantidadeProduto.Location = new Point(119, 163);
            labelQuantidadeProduto.Name = "labelQuantidadeProduto";
            labelQuantidadeProduto.Size = new Size(146, 15);
            labelQuantidadeProduto.TabIndex = 14;
            labelQuantidadeProduto.Text = "Quantidade em Armazém:";
            // 
            // textBoxNovoDescricaoProduto
            // 
            textBoxNovoDescricaoProduto.Location = new Point(271, 117);
            textBoxNovoDescricaoProduto.Name = "textBoxNovoDescricaoProduto";
            textBoxNovoDescricaoProduto.Size = new Size(527, 23);
            textBoxNovoDescricaoProduto.TabIndex = 13;
            // 
            // labelDescricaoProduto
            // 
            labelDescricaoProduto.AutoSize = true;
            labelDescricaoProduto.BackColor = Color.Transparent;
            labelDescricaoProduto.Location = new Point(204, 120);
            labelDescricaoProduto.Name = "labelDescricaoProduto";
            labelDescricaoProduto.Size = new Size(61, 15);
            labelDescricaoProduto.TabIndex = 12;
            labelDescricaoProduto.Text = "Descrição:";
            // 
            // labelTipoProduto
            // 
            labelTipoProduto.AutoSize = true;
            labelTipoProduto.BackColor = Color.Transparent;
            labelTipoProduto.FlatStyle = FlatStyle.Flat;
            labelTipoProduto.ForeColor = SystemColors.ControlText;
            labelTipoProduto.Location = new Point(186, 76);
            labelTipoProduto.Name = "labelTipoProduto";
            labelTipoProduto.Size = new Size(79, 15);
            labelTipoProduto.TabIndex = 11;
            labelTipoProduto.Text = "Tipo Produto:";
            // 
            // comboBoxNovoTipoProduto
            // 
            comboBoxNovoTipoProduto.FormattingEnabled = true;
            comboBoxNovoTipoProduto.Location = new Point(271, 76);
            comboBoxNovoTipoProduto.Name = "comboBoxNovoTipoProduto";
            comboBoxNovoTipoProduto.Size = new Size(121, 23);
            comboBoxNovoTipoProduto.TabIndex = 10;
            // 
            // ModificarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAtualizarProduto);
            Controls.Add(buttonVoltarProdutos);
            Controls.Add(textBoxNovoPrecoProduto);
            Controls.Add(labelPrecoProduto);
            Controls.Add(numericUpDownNovoQuantidade);
            Controls.Add(labelQuantidadeProduto);
            Controls.Add(textBoxNovoDescricaoProduto);
            Controls.Add(labelDescricaoProduto);
            Controls.Add(labelTipoProduto);
            Controls.Add(comboBoxNovoTipoProduto);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModificarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Produto";
            ((System.ComponentModel.ISupportInitialize)numericUpDownNovoQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAtualizarProduto;
        private Button buttonVoltarProdutos;
        private TextBox textBoxNovoPrecoProduto;
        private Label labelPrecoProduto;
        private NumericUpDown numericUpDownNovoQuantidade;
        private Label labelQuantidadeProduto;
        private TextBox textBoxNovoDescricaoProduto;
        private Label labelDescricaoProduto;
        private Label labelTipoProduto;
        private ComboBox comboBoxNovoTipoProduto;
    }
}