namespace VeT_Animais_Domésticos.Forms.Atos_Medicos
{
    partial class AlterarAtoMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarAtoMedico));
            buttonAlterarAtoMedico = new Button();
            buttonVoltarAdicionarAtoMedico = new Button();
            textBoxNovoCustoAtoMedico = new TextBox();
            labelCustoAtoMedico = new Label();
            textBoxNovoDescricaoAtoMedico = new TextBox();
            labelDescricaoAtoMedico = new Label();
            comboBoxNovoNomeAtoMedico = new ComboBox();
            labelAtoMedico = new Label();
            SuspendLayout();
            // 
            // buttonAlterarAtoMedico
            // 
            buttonAlterarAtoMedico.Location = new Point(705, 407);
            buttonAlterarAtoMedico.Name = "buttonAlterarAtoMedico";
            buttonAlterarAtoMedico.Size = new Size(85, 35);
            buttonAlterarAtoMedico.TabIndex = 49;
            buttonAlterarAtoMedico.Text = "Alterar";
            buttonAlterarAtoMedico.UseVisualStyleBackColor = true;
            buttonAlterarAtoMedico.Click += buttonAlterarAtoMedico_Click;
            // 
            // buttonVoltarAdicionarAtoMedico
            // 
            buttonVoltarAdicionarAtoMedico.Location = new Point(14, 407);
            buttonVoltarAdicionarAtoMedico.Name = "buttonVoltarAdicionarAtoMedico";
            buttonVoltarAdicionarAtoMedico.Size = new Size(91, 35);
            buttonVoltarAdicionarAtoMedico.TabIndex = 48;
            buttonVoltarAdicionarAtoMedico.Text = "Voltar";
            buttonVoltarAdicionarAtoMedico.UseVisualStyleBackColor = true;
            buttonVoltarAdicionarAtoMedico.Click += buttonVoltarAdicionarAtoMedico_Click;
            // 
            // textBoxNovoCustoAtoMedico
            // 
            textBoxNovoCustoAtoMedico.Location = new Point(282, 222);
            textBoxNovoCustoAtoMedico.Name = "textBoxNovoCustoAtoMedico";
            textBoxNovoCustoAtoMedico.Size = new Size(202, 23);
            textBoxNovoCustoAtoMedico.TabIndex = 47;
            // 
            // labelCustoAtoMedico
            // 
            labelCustoAtoMedico.AutoSize = true;
            labelCustoAtoMedico.BackColor = Color.Transparent;
            labelCustoAtoMedico.Location = new Point(235, 225);
            labelCustoAtoMedico.Name = "labelCustoAtoMedico";
            labelCustoAtoMedico.Size = new Size(41, 15);
            labelCustoAtoMedico.TabIndex = 46;
            labelCustoAtoMedico.Text = "Custo:";
            // 
            // textBoxNovoDescricaoAtoMedico
            // 
            textBoxNovoDescricaoAtoMedico.Location = new Point(282, 177);
            textBoxNovoDescricaoAtoMedico.Name = "textBoxNovoDescricaoAtoMedico";
            textBoxNovoDescricaoAtoMedico.Size = new Size(202, 23);
            textBoxNovoDescricaoAtoMedico.TabIndex = 45;
            // 
            // labelDescricaoAtoMedico
            // 
            labelDescricaoAtoMedico.AutoSize = true;
            labelDescricaoAtoMedico.BackColor = Color.Transparent;
            labelDescricaoAtoMedico.Location = new Point(217, 180);
            labelDescricaoAtoMedico.Name = "labelDescricaoAtoMedico";
            labelDescricaoAtoMedico.Size = new Size(61, 15);
            labelDescricaoAtoMedico.TabIndex = 44;
            labelDescricaoAtoMedico.Text = "Descrição:";
            // 
            // comboBoxNovoNomeAtoMedico
            // 
            comboBoxNovoNomeAtoMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNovoNomeAtoMedico.FormattingEnabled = true;
            comboBoxNovoNomeAtoMedico.Items.AddRange(new object[] { "Consulta", "Pequena Cirurgia", "Vacinação", "Mudança de Penso", "Raio-X", "Análises Clínicas", "Desparatização", "Terapia" });
            comboBoxNovoNomeAtoMedico.Location = new Point(284, 130);
            comboBoxNovoNomeAtoMedico.Name = "comboBoxNovoNomeAtoMedico";
            comboBoxNovoNomeAtoMedico.Size = new Size(200, 23);
            comboBoxNovoNomeAtoMedico.TabIndex = 43;
            // 
            // labelAtoMedico
            // 
            labelAtoMedico.AutoSize = true;
            labelAtoMedico.BackColor = Color.Transparent;
            labelAtoMedico.Location = new Point(206, 133);
            labelAtoMedico.Name = "labelAtoMedico";
            labelAtoMedico.Size = new Size(72, 15);
            labelAtoMedico.TabIndex = 42;
            labelAtoMedico.Text = "Ato Médico:";
            // 
            // AlterarAtoMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAlterarAtoMedico);
            Controls.Add(buttonVoltarAdicionarAtoMedico);
            Controls.Add(textBoxNovoCustoAtoMedico);
            Controls.Add(labelCustoAtoMedico);
            Controls.Add(textBoxNovoDescricaoAtoMedico);
            Controls.Add(labelDescricaoAtoMedico);
            Controls.Add(comboBoxNovoNomeAtoMedico);
            Controls.Add(labelAtoMedico);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AlterarAtoMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alterar Ato Médico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAlterarAtoMedico;
        private Button buttonVoltarAdicionarAtoMedico;
        private TextBox textBoxNovoCustoAtoMedico;
        private Label labelCustoAtoMedico;
        private TextBox textBoxNovoDescricaoAtoMedico;
        private Label labelDescricaoAtoMedico;
        private ComboBox comboBoxNovoNomeAtoMedico;
        private Label labelAtoMedico;
    }
}