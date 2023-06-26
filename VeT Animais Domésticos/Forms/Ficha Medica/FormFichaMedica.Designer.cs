namespace VeT_Animais_Domésticos.Forms
{
    partial class FormFichaMedica
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewFichaMedica = new DataGridView();
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
            textBoxDiagnosticoFichaMedica = new TextBox();
            textBoxPrescricaoAtoMedico = new TextBox();
            labelPrescricaoMedica = new Label();
            buttonGuardarFichaMedica = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFichaMedica).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFichaMedica
            // 
            dataGridViewFichaMedica.AccessibleRole = AccessibleRole.ScrollBar;
            dataGridViewFichaMedica.AllowUserToAddRows = false;
            dataGridViewFichaMedica.AllowUserToDeleteRows = false;
            dataGridViewFichaMedica.AllowUserToResizeColumns = false;
            dataGridViewFichaMedica.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewFichaMedica.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewFichaMedica.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewFichaMedica.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFichaMedica.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewFichaMedica.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewFichaMedica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFichaMedica.ColumnHeadersVisible = false;
            dataGridViewFichaMedica.Location = new Point(57, 12);
            dataGridViewFichaMedica.Name = "dataGridViewFichaMedica";
            dataGridViewFichaMedica.ReadOnly = true;
            dataGridViewFichaMedica.RowTemplate.Height = 25;
            dataGridViewFichaMedica.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFichaMedica.ShowCellErrors = false;
            dataGridViewFichaMedica.ShowCellToolTips = false;
            dataGridViewFichaMedica.ShowEditingIcon = false;
            dataGridViewFichaMedica.ShowRowErrors = false;
            dataGridViewFichaMedica.Size = new Size(678, 236);
            dataGridViewFichaMedica.StandardTab = true;
            dataGridViewFichaMedica.TabIndex = 6;
            dataGridViewFichaMedica.Visible = false;
            // 
            // labelDataAtoMedico
            // 
            labelDataAtoMedico.AutoSize = true;
            labelDataAtoMedico.Location = new Point(57, 267);
            labelDataAtoMedico.Name = "labelDataAtoMedico";
            labelDataAtoMedico.Size = new Size(116, 15);
            labelDataAtoMedico.TabIndex = 7;
            labelDataAtoMedico.Text = "Data do Ato Médico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 294);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 8;
            label2.Text = "Tipo de Consulta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 323);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 9;
            label3.Text = "Nome do Colaborador:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 352);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 10;
            label4.Text = "Diagnóstico:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 387);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 11;
            label1.Text = "Ato Médico:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(470, 262);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 12;
            label5.Text = "Peso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(428, 291);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 13;
            label6.Text = "Observações:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(420, 328);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 15;
            label8.Text = "Próxima Visita:";
            // 
            // textBoxPesoAtoMedico
            // 
            textBoxPesoAtoMedico.Location = new Point(511, 259);
            textBoxPesoAtoMedico.Name = "textBoxPesoAtoMedico";
            textBoxPesoAtoMedico.Size = new Size(100, 23);
            textBoxPesoAtoMedico.TabIndex = 16;
            // 
            // textBoxObservacoesAtoMedico
            // 
            textBoxObservacoesAtoMedico.Location = new Point(511, 288);
            textBoxObservacoesAtoMedico.Name = "textBoxObservacoesAtoMedico";
            textBoxObservacoesAtoMedico.Size = new Size(203, 23);
            textBoxObservacoesAtoMedico.TabIndex = 17;
            // 
            // dateTimePickerProximaVisita
            // 
            dateTimePickerProximaVisita.Location = new Point(511, 323);
            dateTimePickerProximaVisita.Name = "dateTimePickerProximaVisita";
            dateTimePickerProximaVisita.Size = new Size(203, 23);
            dateTimePickerProximaVisita.TabIndex = 18;
            // 
            // comboBoxAtoMedico
            // 
            comboBoxAtoMedico.FormattingEnabled = true;
            comboBoxAtoMedico.Items.AddRange(new object[] { "Consulta", "Pequena Cirurgia", "Vacinação", "Mudança de penso", "Grande Cirurgia" });
            comboBoxAtoMedico.Location = new Point(179, 379);
            comboBoxAtoMedico.Name = "comboBoxAtoMedico";
            comboBoxAtoMedico.Size = new Size(121, 23);
            comboBoxAtoMedico.TabIndex = 19;
            // 
            // dateTimePickerAtoMedico
            // 
            dateTimePickerAtoMedico.Location = new Point(179, 262);
            dateTimePickerAtoMedico.Name = "dateTimePickerAtoMedico";
            dateTimePickerAtoMedico.Size = new Size(203, 23);
            dateTimePickerAtoMedico.TabIndex = 20;
            // 
            // comboBoxTipoConsulta
            // 
            comboBoxTipoConsulta.FormattingEnabled = true;
            comboBoxTipoConsulta.Items.AddRange(new object[] { "Consulta Rápida", "Banho", "Vacinação", "Mudança de penso", "Desparatização", "Tosquia do Pêlo" });
            comboBoxTipoConsulta.Location = new Point(179, 291);
            comboBoxTipoConsulta.Name = "comboBoxTipoConsulta";
            comboBoxTipoConsulta.Size = new Size(203, 23);
            comboBoxTipoConsulta.TabIndex = 21;
            // 
            // comboBoxNomeColaborador
            // 
            comboBoxNomeColaborador.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxNomeColaborador.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxNomeColaborador.FormattingEnabled = true;
            comboBoxNomeColaborador.Location = new Point(179, 320);
            comboBoxNomeColaborador.Name = "comboBoxNomeColaborador";
            comboBoxNomeColaborador.Size = new Size(203, 23);
            comboBoxNomeColaborador.TabIndex = 22;
            comboBoxNomeColaborador.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // textBoxDiagnosticoFichaMedica
            // 
            textBoxDiagnosticoFichaMedica.Location = new Point(179, 349);
            textBoxDiagnosticoFichaMedica.Name = "textBoxDiagnosticoFichaMedica";
            textBoxDiagnosticoFichaMedica.Size = new Size(203, 23);
            textBoxDiagnosticoFichaMedica.TabIndex = 23;
            // 
            // textBoxPrescricaoAtoMedico
            // 
            textBoxPrescricaoAtoMedico.Location = new Point(511, 352);
            textBoxPrescricaoAtoMedico.Name = "textBoxPrescricaoAtoMedico";
            textBoxPrescricaoAtoMedico.Size = new Size(203, 23);
            textBoxPrescricaoAtoMedico.TabIndex = 24;
            // 
            // labelPrescricaoMedica
            // 
            labelPrescricaoMedica.AutoSize = true;
            labelPrescricaoMedica.Location = new Point(399, 357);
            labelPrescricaoMedica.Name = "labelPrescricaoMedica";
            labelPrescricaoMedica.Size = new Size(106, 15);
            labelPrescricaoMedica.TabIndex = 25;
            labelPrescricaoMedica.Text = "Prescrição Médica:";
            // 
            // buttonGuardarFichaMedica
            // 
            buttonGuardarFichaMedica.BackColor = Color.Lime;
            buttonGuardarFichaMedica.Location = new Point(624, 397);
            buttonGuardarFichaMedica.Name = "buttonGuardarFichaMedica";
            buttonGuardarFichaMedica.Size = new Size(90, 41);
            buttonGuardarFichaMedica.TabIndex = 26;
            buttonGuardarFichaMedica.Text = "Guardar";
            buttonGuardarFichaMedica.UseVisualStyleBackColor = false;
            // 
            // FormFichaMedica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGuardarFichaMedica);
            Controls.Add(labelPrescricaoMedica);
            Controls.Add(textBoxPrescricaoAtoMedico);
            Controls.Add(textBoxDiagnosticoFichaMedica);
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
            Controls.Add(dataGridViewFichaMedica);
            Name = "FormFichaMedica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ficha Médica";
            Load += FormFichaMedica_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFichaMedica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewFichaMedica;
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
        private TextBox textBoxDiagnosticoFichaMedica;
        private TextBox textBoxPrescricaoAtoMedico;
        private Label labelPrescricaoMedica;
        private Button buttonGuardarFichaMedica;
    }
}