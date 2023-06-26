namespace VeT_Animais_Domésticos.Forms.Atos_Medicos
{
    partial class AdicionarAtoMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarAtoMedico));
            comboBoxNomeAtoMedico = new ComboBox();
            labelAtoMedico = new Label();
            textBoxDescricaoAtoMedico = new TextBox();
            labelDescricaoAtoMedico = new Label();
            textBoxCustoAtoMedico = new TextBox();
            labelCustoAtoMedico = new Label();
            buttonVoltarAdicionarAtoMedico = new Button();
            buttonRegistarAtoMedico = new Button();
            SuspendLayout();
            // 
            // comboBoxNomeAtoMedico
            // 
            comboBoxNomeAtoMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNomeAtoMedico.FormattingEnabled = true;
            comboBoxNomeAtoMedico.Items.AddRange(new object[] { "Consulta", "Pequena Cirurgia", "Vacinação", "Mudança de Penso", "Raio-X", "Análises Clínicas", "Desparatização", "Terapia" });
            comboBoxNomeAtoMedico.Location = new Point(302, 111);
            comboBoxNomeAtoMedico.Name = "comboBoxNomeAtoMedico";
            comboBoxNomeAtoMedico.Size = new Size(200, 23);
            comboBoxNomeAtoMedico.TabIndex = 35;
            // 
            // labelAtoMedico
            // 
            labelAtoMedico.AutoSize = true;
            labelAtoMedico.BackColor = Color.Transparent;
            labelAtoMedico.Location = new Point(224, 114);
            labelAtoMedico.Name = "labelAtoMedico";
            labelAtoMedico.Size = new Size(72, 15);
            labelAtoMedico.TabIndex = 34;
            labelAtoMedico.Text = "Ato Médico:";
            // 
            // textBoxDescricaoAtoMedico
            // 
            textBoxDescricaoAtoMedico.Location = new Point(302, 172);
            textBoxDescricaoAtoMedico.Name = "textBoxDescricaoAtoMedico";
            textBoxDescricaoAtoMedico.Size = new Size(202, 23);
            textBoxDescricaoAtoMedico.TabIndex = 37;
            // 
            // labelDescricaoAtoMedico
            // 
            labelDescricaoAtoMedico.AutoSize = true;
            labelDescricaoAtoMedico.BackColor = Color.Transparent;
            labelDescricaoAtoMedico.Location = new Point(235, 175);
            labelDescricaoAtoMedico.Name = "labelDescricaoAtoMedico";
            labelDescricaoAtoMedico.Size = new Size(61, 15);
            labelDescricaoAtoMedico.TabIndex = 36;
            labelDescricaoAtoMedico.Text = "Descrição:";
            // 
            // textBoxCustoAtoMedico
            // 
            textBoxCustoAtoMedico.Location = new Point(302, 235);
            textBoxCustoAtoMedico.Name = "textBoxCustoAtoMedico";
            textBoxCustoAtoMedico.Size = new Size(202, 23);
            textBoxCustoAtoMedico.TabIndex = 39;
            // 
            // labelCustoAtoMedico
            // 
            labelCustoAtoMedico.AutoSize = true;
            labelCustoAtoMedico.BackColor = Color.Transparent;
            labelCustoAtoMedico.Location = new Point(255, 238);
            labelCustoAtoMedico.Name = "labelCustoAtoMedico";
            labelCustoAtoMedico.Size = new Size(41, 15);
            labelCustoAtoMedico.TabIndex = 38;
            labelCustoAtoMedico.Text = "Custo:";
            // 
            // buttonVoltarAdicionarAtoMedico
            // 
            buttonVoltarAdicionarAtoMedico.Location = new Point(12, 403);
            buttonVoltarAdicionarAtoMedico.Name = "buttonVoltarAdicionarAtoMedico";
            buttonVoltarAdicionarAtoMedico.Size = new Size(91, 35);
            buttonVoltarAdicionarAtoMedico.TabIndex = 40;
            buttonVoltarAdicionarAtoMedico.Text = "Voltar";
            buttonVoltarAdicionarAtoMedico.UseVisualStyleBackColor = true;
            buttonVoltarAdicionarAtoMedico.Click += buttonVoltarAdicionarAtoMedico_Click;
            // 
            // buttonRegistarAtoMedico
            // 
            buttonRegistarAtoMedico.Location = new Point(703, 403);
            buttonRegistarAtoMedico.Name = "buttonRegistarAtoMedico";
            buttonRegistarAtoMedico.Size = new Size(85, 35);
            buttonRegistarAtoMedico.TabIndex = 41;
            buttonRegistarAtoMedico.Text = "Registar";
            buttonRegistarAtoMedico.UseVisualStyleBackColor = true;
            buttonRegistarAtoMedico.Click += buttonRegistarAtoMedico_Click;
            // 
            // AdicionarAtoMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRegistarAtoMedico);
            Controls.Add(buttonVoltarAdicionarAtoMedico);
            Controls.Add(textBoxCustoAtoMedico);
            Controls.Add(labelCustoAtoMedico);
            Controls.Add(textBoxDescricaoAtoMedico);
            Controls.Add(labelDescricaoAtoMedico);
            Controls.Add(comboBoxNomeAtoMedico);
            Controls.Add(labelAtoMedico);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdicionarAtoMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registar Ato Medico";
            Load += AdicionarAtoMedico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxNomeAtoMedico;
        private Label labelAtoMedico;
        private TextBox textBoxDescricaoAtoMedico;
        private Label labelDescricaoAtoMedico;
        private TextBox textBoxCustoAtoMedico;
        private Label labelCustoAtoMedico;
        private Button buttonVoltarAdicionarAtoMedico;
        private Button buttonRegistarAtoMedico;
    }
}