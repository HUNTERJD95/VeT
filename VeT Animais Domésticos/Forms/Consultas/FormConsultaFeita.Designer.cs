namespace VeT_Animais_Domésticos.Forms
{
    partial class FormConsultaFeita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaFeita));
            labelDataAtoMedico = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            textBoxPesoAtoMedico = new TextBox();
            textBoxObservacoesAtoMedico = new TextBox();
            dateTimePickerProximaVisita = new DateTimePicker();
            comboBoxAtoMedico = new ComboBox();
            dateTimePickerAtoMedico = new DateTimePicker();
            comboBoxTipoConsulta = new ComboBox();
            comboBoxNomeColaborador = new ComboBox();
            textBoxPrescricaoAtoMedico = new TextBox();
            labelPrescricaoMedica = new Label();
            buttonGuardarFichaMedica = new Button();
            buttonVoltarFichaMedica = new Button();
            comboBoxDiagnosticoFichaMedica = new ComboBox();
            listBoxDiagnosticoFichaMedica = new ListBox();
            listBoxAtosMedicosFichaMedica = new ListBox();
            labelProdutosUtilizados = new Label();
            comboBoxProdutosUtilizados = new ComboBox();
            listBoxProdutosUtilizados = new ListBox();
            SuspendLayout();
            // 
            // labelDataAtoMedico
            // 
            labelDataAtoMedico.AutoSize = true;
            labelDataAtoMedico.Location = new Point(12, 28);
            labelDataAtoMedico.Name = "labelDataAtoMedico";
            labelDataAtoMedico.Size = new Size(116, 15);
            labelDataAtoMedico.TabIndex = 7;
            labelDataAtoMedico.Text = "Data do Ato Médico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 84);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 8;
            label2.Text = "Tipo de Consulta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-1, 137);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 9;
            label3.Text = "Nome do Colaborador:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 187);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 10;
            label4.Text = "Diagnóstico:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 248);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 11;
            label1.Text = "Ato Médico:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(544, 23);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 12;
            label5.Text = "Peso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(502, 79);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 13;
            label6.Text = "Observações:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(494, 154);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 15;
            label8.Text = "Próxima Visita:";
            // 
            // textBoxPesoAtoMedico
            // 
            textBoxPesoAtoMedico.Location = new Point(585, 20);
            textBoxPesoAtoMedico.Name = "textBoxPesoAtoMedico";
            textBoxPesoAtoMedico.Size = new Size(100, 23);
            textBoxPesoAtoMedico.TabIndex = 16;
            // 
            // textBoxObservacoesAtoMedico
            // 
            textBoxObservacoesAtoMedico.Location = new Point(585, 76);
            textBoxObservacoesAtoMedico.Multiline = true;
            textBoxObservacoesAtoMedico.Name = "textBoxObservacoesAtoMedico";
            textBoxObservacoesAtoMedico.Size = new Size(203, 23);
            textBoxObservacoesAtoMedico.TabIndex = 17;
            // 
            // dateTimePickerProximaVisita
            // 
            dateTimePickerProximaVisita.Location = new Point(585, 149);
            dateTimePickerProximaVisita.Name = "dateTimePickerProximaVisita";
            dateTimePickerProximaVisita.Size = new Size(203, 23);
            dateTimePickerProximaVisita.TabIndex = 18;
            // 
            // comboBoxAtoMedico
            // 
            comboBoxAtoMedico.FormattingEnabled = true;
            comboBoxAtoMedico.Items.AddRange(new object[] { "Consulta", "Pequena Cirurgia", "Vacinação", "Mudança de penso", "Grande Cirurgia" });
            comboBoxAtoMedico.Location = new Point(135, 240);
            comboBoxAtoMedico.Name = "comboBoxAtoMedico";
            comboBoxAtoMedico.Size = new Size(121, 23);
            comboBoxAtoMedico.TabIndex = 19;
            comboBoxAtoMedico.SelectedIndexChanged += comboBoxAtoMedico_SelectedIndexChanged;
            // 
            // dateTimePickerAtoMedico
            // 
            dateTimePickerAtoMedico.Location = new Point(134, 23);
            dateTimePickerAtoMedico.Name = "dateTimePickerAtoMedico";
            dateTimePickerAtoMedico.Size = new Size(203, 23);
            dateTimePickerAtoMedico.TabIndex = 20;
            // 
            // comboBoxTipoConsulta
            // 
            comboBoxTipoConsulta.FormattingEnabled = true;
            comboBoxTipoConsulta.Items.AddRange(new object[] { "Consulta Rápida", "Banho", "Vacinação", "Mudança de penso", "Desparatização", "Tosquia do Pêlo" });
            comboBoxTipoConsulta.Location = new Point(134, 81);
            comboBoxTipoConsulta.Name = "comboBoxTipoConsulta";
            comboBoxTipoConsulta.Size = new Size(203, 23);
            comboBoxTipoConsulta.TabIndex = 21;
            // 
            // comboBoxNomeColaborador
            // 
            comboBoxNomeColaborador.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxNomeColaborador.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxNomeColaborador.FormattingEnabled = true;
            comboBoxNomeColaborador.Location = new Point(134, 134);
            comboBoxNomeColaborador.Name = "comboBoxNomeColaborador";
            comboBoxNomeColaborador.Size = new Size(203, 23);
            comboBoxNomeColaborador.TabIndex = 22;
            comboBoxNomeColaborador.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // textBoxPrescricaoAtoMedico
            // 
            textBoxPrescricaoAtoMedico.Location = new Point(585, 198);
            textBoxPrescricaoAtoMedico.Multiline = true;
            textBoxPrescricaoAtoMedico.Name = "textBoxPrescricaoAtoMedico";
            textBoxPrescricaoAtoMedico.Size = new Size(203, 23);
            textBoxPrescricaoAtoMedico.TabIndex = 24;
            // 
            // labelPrescricaoMedica
            // 
            labelPrescricaoMedica.AutoSize = true;
            labelPrescricaoMedica.Location = new Point(473, 203);
            labelPrescricaoMedica.Name = "labelPrescricaoMedica";
            labelPrescricaoMedica.Size = new Size(106, 15);
            labelPrescricaoMedica.TabIndex = 25;
            labelPrescricaoMedica.Text = "Prescrição Médica:";
            // 
            // buttonGuardarFichaMedica
            // 
            buttonGuardarFichaMedica.BackColor = Color.Lime;
            buttonGuardarFichaMedica.Location = new Point(370, 397);
            buttonGuardarFichaMedica.Name = "buttonGuardarFichaMedica";
            buttonGuardarFichaMedica.Size = new Size(90, 41);
            buttonGuardarFichaMedica.TabIndex = 26;
            buttonGuardarFichaMedica.Text = "Guardar";
            buttonGuardarFichaMedica.UseVisualStyleBackColor = false;
            // 
            // buttonVoltarFichaMedica
            // 
            buttonVoltarFichaMedica.Location = new Point(12, 408);
            buttonVoltarFichaMedica.Name = "buttonVoltarFichaMedica";
            buttonVoltarFichaMedica.Size = new Size(83, 30);
            buttonVoltarFichaMedica.TabIndex = 27;
            buttonVoltarFichaMedica.Text = "Voltar";
            buttonVoltarFichaMedica.UseVisualStyleBackColor = true;
            buttonVoltarFichaMedica.Click += buttonVoltarFichaMedica_Click;
            // 
            // comboBoxDiagnosticoFichaMedica
            // 
            comboBoxDiagnosticoFichaMedica.FormattingEnabled = true;
            comboBoxDiagnosticoFichaMedica.Items.AddRange(new object[] { "Febre", "Obsesso", "Fratura", "Parasitas", "Diarreia" });
            comboBoxDiagnosticoFichaMedica.Location = new Point(134, 184);
            comboBoxDiagnosticoFichaMedica.Name = "comboBoxDiagnosticoFichaMedica";
            comboBoxDiagnosticoFichaMedica.Size = new Size(203, 23);
            comboBoxDiagnosticoFichaMedica.TabIndex = 30;
            comboBoxDiagnosticoFichaMedica.SelectedIndexChanged += comboBoxDiagnosticoFichaMedica_SelectedIndexChanged;
            // 
            // listBoxDiagnosticoFichaMedica
            // 
            listBoxDiagnosticoFichaMedica.FormattingEnabled = true;
            listBoxDiagnosticoFichaMedica.ItemHeight = 15;
            listBoxDiagnosticoFichaMedica.Location = new Point(340, 184);
            listBoxDiagnosticoFichaMedica.Name = "listBoxDiagnosticoFichaMedica";
            listBoxDiagnosticoFichaMedica.Size = new Size(120, 94);
            listBoxDiagnosticoFichaMedica.TabIndex = 32;
            // 
            // listBoxAtosMedicosFichaMedica
            // 
            listBoxAtosMedicosFichaMedica.FormattingEnabled = true;
            listBoxAtosMedicosFichaMedica.ItemHeight = 15;
            listBoxAtosMedicosFichaMedica.Location = new Point(136, 269);
            listBoxAtosMedicosFichaMedica.Name = "listBoxAtosMedicosFichaMedica";
            listBoxAtosMedicosFichaMedica.Size = new Size(120, 94);
            listBoxAtosMedicosFichaMedica.TabIndex = 33;
            // 
            // labelProdutosUtilizados
            // 
            labelProdutosUtilizados.AutoSize = true;
            labelProdutosUtilizados.Location = new Point(467, 272);
            labelProdutosUtilizados.Name = "labelProdutosUtilizados";
            labelProdutosUtilizados.Size = new Size(112, 15);
            labelProdutosUtilizados.TabIndex = 34;
            labelProdutosUtilizados.Text = "Produtos Utilizados:";
            // 
            // comboBoxProdutosUtilizados
            // 
            comboBoxProdutosUtilizados.FormattingEnabled = true;
            comboBoxProdutosUtilizados.Items.AddRange(new object[] { "Consulta", "Pequena Cirurgia", "Vacinação", "Mudança de penso", "Grande Cirurgia" });
            comboBoxProdutosUtilizados.Location = new Point(585, 269);
            comboBoxProdutosUtilizados.Name = "comboBoxProdutosUtilizados";
            comboBoxProdutosUtilizados.Size = new Size(203, 23);
            comboBoxProdutosUtilizados.TabIndex = 35;
            comboBoxProdutosUtilizados.SelectedIndexChanged += comboBoxProdutosUtilizados_SelectedIndexChanged;
            // 
            // listBoxProdutosUtilizados
            // 
            listBoxProdutosUtilizados.FormattingEnabled = true;
            listBoxProdutosUtilizados.ItemHeight = 15;
            listBoxProdutosUtilizados.Location = new Point(623, 298);
            listBoxProdutosUtilizados.Name = "listBoxProdutosUtilizados";
            listBoxProdutosUtilizados.Size = new Size(120, 94);
            listBoxProdutosUtilizados.TabIndex = 36;
            // 
            // FormFichaMedica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxProdutosUtilizados);
            Controls.Add(comboBoxProdutosUtilizados);
            Controls.Add(labelProdutosUtilizados);
            Controls.Add(listBoxAtosMedicosFichaMedica);
            Controls.Add(listBoxDiagnosticoFichaMedica);
            Controls.Add(comboBoxDiagnosticoFichaMedica);
            Controls.Add(buttonVoltarFichaMedica);
            Controls.Add(buttonGuardarFichaMedica);
            Controls.Add(labelPrescricaoMedica);
            Controls.Add(textBoxPrescricaoAtoMedico);
            Controls.Add(comboBoxNomeColaborador);
            Controls.Add(comboBoxTipoConsulta);
            Controls.Add(dateTimePickerAtoMedico);
            Controls.Add(comboBoxAtoMedico);
            Controls.Add(dateTimePickerProximaVisita);
            Controls.Add(textBoxObservacoesAtoMedico);
            Controls.Add(textBoxPesoAtoMedico);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelDataAtoMedico);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFichaMedica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ficha Médica";
            Load += FormFichaMedica_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelDataAtoMedico;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox textBoxPesoAtoMedico;
        private TextBox textBoxObservacoesAtoMedico;
        private DateTimePicker dateTimePickerProximaVisita;
        private ComboBox comboBoxAtoMedico;
        private DateTimePicker dateTimePickerAtoMedico;
        private ComboBox comboBoxTipoConsulta;
        private ComboBox comboBoxNomeColaborador;
        private TextBox textBoxPrescricaoAtoMedico;
        private Label labelPrescricaoMedica;
        private Button buttonGuardarFichaMedica;
        private Button buttonVoltarFichaMedica;
        private ComboBox comboBoxDiagnosticoFichaMedica;
        private ListBox listBoxDiagnosticoFichaMedica;
        private ListBox listBoxAtosMedicosFichaMedica;
        private Label labelProdutosUtilizados;
        private ComboBox comboBoxProdutosUtilizados;
        private ListBox listBoxProdutosUtilizados;
    }
}