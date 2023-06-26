namespace VeT_Animais_Domésticos.Forms.Consultas
{
    partial class AgendarConsulta
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
            labelProcurarPorNIFDono = new Label();
            textBoxPesquisarNIFDono = new TextBox();
            listBoxAnimaisPesquisados = new ListBox();
            buttonConfirmarNIFDono = new Button();
            labelColaboradorConsulta = new Label();
            labelTelemovelConsulta = new Label();
            labelDataConsultaAgendarConsulta = new Label();
            labelHoraConsultaAgendarConsulta = new Label();
            comboBoxColaboradorAgendarConsulta = new ComboBox();
            dateTimePickerDataConsultaAgendarConsulta = new DateTimePicker();
            textBoxTelemovelAgendarConsulta = new TextBox();
            buttonConfirmarAgendarConsulta = new Button();
            dateTimePickerHoraConsultaAgendarConsulta = new DateTimePicker();
            SuspendLayout();
            // 
            // labelProcurarPorNIFDono
            // 
            labelProcurarPorNIFDono.AutoSize = true;
            labelProcurarPorNIFDono.Location = new Point(12, 45);
            labelProcurarPorNIFDono.Name = "labelProcurarPorNIFDono";
            labelProcurarPorNIFDono.Size = new Size(118, 15);
            labelProcurarPorNIFDono.TabIndex = 0;
            labelProcurarPorNIFDono.Text = "Insira o NIF do Dono:";
            // 
            // textBoxPesquisarNIFDono
            // 
            textBoxPesquisarNIFDono.Location = new Point(136, 42);
            textBoxPesquisarNIFDono.Name = "textBoxPesquisarNIFDono";
            textBoxPesquisarNIFDono.Size = new Size(166, 23);
            textBoxPesquisarNIFDono.TabIndex = 1;
            // 
            // listBoxAnimaisPesquisados
            // 
            listBoxAnimaisPesquisados.FormattingEnabled = true;
            listBoxAnimaisPesquisados.HorizontalScrollbar = true;
            listBoxAnimaisPesquisados.ItemHeight = 15;
            listBoxAnimaisPesquisados.Location = new Point(12, 113);
            listBoxAnimaisPesquisados.MultiColumn = true;
            listBoxAnimaisPesquisados.Name = "listBoxAnimaisPesquisados";
            listBoxAnimaisPesquisados.ScrollAlwaysVisible = true;
            listBoxAnimaisPesquisados.Size = new Size(776, 109);
            listBoxAnimaisPesquisados.TabIndex = 2;
            listBoxAnimaisPesquisados.Visible = false;
            // 
            // buttonConfirmarNIFDono
            // 
            buttonConfirmarNIFDono.Location = new Point(332, 28);
            buttonConfirmarNIFDono.Name = "buttonConfirmarNIFDono";
            buttonConfirmarNIFDono.Size = new Size(75, 49);
            buttonConfirmarNIFDono.TabIndex = 3;
            buttonConfirmarNIFDono.Text = "Confirmar";
            buttonConfirmarNIFDono.UseVisualStyleBackColor = true;
            buttonConfirmarNIFDono.Click += buttonConfirmarNIFDono_Click;
            // 
            // labelColaboradorConsulta
            // 
            labelColaboradorConsulta.AutoSize = true;
            labelColaboradorConsulta.Location = new Point(27, 254);
            labelColaboradorConsulta.Name = "labelColaboradorConsulta";
            labelColaboradorConsulta.Size = new Size(76, 15);
            labelColaboradorConsulta.TabIndex = 4;
            labelColaboradorConsulta.Text = "Colaborador:";
            // 
            // labelTelemovelConsulta
            // 
            labelTelemovelConsulta.AutoSize = true;
            labelTelemovelConsulta.Location = new Point(40, 287);
            labelTelemovelConsulta.Name = "labelTelemovelConsulta";
            labelTelemovelConsulta.Size = new Size(63, 15);
            labelTelemovelConsulta.TabIndex = 5;
            labelTelemovelConsulta.Text = "Telemóvel:";
            // 
            // labelDataConsultaAgendarConsulta
            // 
            labelDataConsultaAgendarConsulta.AutoSize = true;
            labelDataConsultaAgendarConsulta.Location = new Point(19, 324);
            labelDataConsultaAgendarConsulta.Name = "labelDataConsultaAgendarConsulta";
            labelDataConsultaAgendarConsulta.Size = new Size(84, 15);
            labelDataConsultaAgendarConsulta.TabIndex = 6;
            labelDataConsultaAgendarConsulta.Text = "Data Consulta:";
            // 
            // labelHoraConsultaAgendarConsulta
            // 
            labelHoraConsultaAgendarConsulta.AutoSize = true;
            labelHoraConsultaAgendarConsulta.Location = new Point(17, 359);
            labelHoraConsultaAgendarConsulta.Name = "labelHoraConsultaAgendarConsulta";
            labelHoraConsultaAgendarConsulta.Size = new Size(86, 15);
            labelHoraConsultaAgendarConsulta.TabIndex = 7;
            labelHoraConsultaAgendarConsulta.Text = "Hora Consulta:";
            // 
            // comboBoxColaboradorAgendarConsulta
            // 
            comboBoxColaboradorAgendarConsulta.FormattingEnabled = true;
            comboBoxColaboradorAgendarConsulta.Location = new Point(109, 251);
            comboBoxColaboradorAgendarConsulta.Name = "comboBoxColaboradorAgendarConsulta";
            comboBoxColaboradorAgendarConsulta.Size = new Size(149, 23);
            comboBoxColaboradorAgendarConsulta.TabIndex = 8;
            // 
            // dateTimePickerDataConsultaAgendarConsulta
            // 
            dateTimePickerDataConsultaAgendarConsulta.Format = DateTimePickerFormat.Short;
            dateTimePickerDataConsultaAgendarConsulta.Location = new Point(109, 318);
            dateTimePickerDataConsultaAgendarConsulta.Name = "dateTimePickerDataConsultaAgendarConsulta";
            dateTimePickerDataConsultaAgendarConsulta.Size = new Size(200, 23);
            dateTimePickerDataConsultaAgendarConsulta.TabIndex = 9;
            // 
            // textBoxTelemovelAgendarConsulta
            // 
            textBoxTelemovelAgendarConsulta.Location = new Point(109, 284);
            textBoxTelemovelAgendarConsulta.Name = "textBoxTelemovelAgendarConsulta";
            textBoxTelemovelAgendarConsulta.Size = new Size(149, 23);
            textBoxTelemovelAgendarConsulta.TabIndex = 10;
            // 
            // buttonConfirmarAgendarConsulta
            // 
            buttonConfirmarAgendarConsulta.Location = new Point(657, 370);
            buttonConfirmarAgendarConsulta.Name = "buttonConfirmarAgendarConsulta";
            buttonConfirmarAgendarConsulta.Size = new Size(93, 51);
            buttonConfirmarAgendarConsulta.TabIndex = 11;
            buttonConfirmarAgendarConsulta.Text = "Confirmar";
            buttonConfirmarAgendarConsulta.UseVisualStyleBackColor = true;
            buttonConfirmarAgendarConsulta.Click += buttonConfirmarAgendarConsulta_Click;
            // 
            // dateTimePickerHoraConsultaAgendarConsulta
            // 
            dateTimePickerHoraConsultaAgendarConsulta.Format = DateTimePickerFormat.Time;
            dateTimePickerHoraConsultaAgendarConsulta.Location = new Point(109, 353);
            dateTimePickerHoraConsultaAgendarConsulta.Name = "dateTimePickerHoraConsultaAgendarConsulta";
            dateTimePickerHoraConsultaAgendarConsulta.ShowUpDown = true;
            dateTimePickerHoraConsultaAgendarConsulta.Size = new Size(200, 23);
            dateTimePickerHoraConsultaAgendarConsulta.TabIndex = 12;
            // 
            // AgendarConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePickerHoraConsultaAgendarConsulta);
            Controls.Add(buttonConfirmarAgendarConsulta);
            Controls.Add(textBoxTelemovelAgendarConsulta);
            Controls.Add(dateTimePickerDataConsultaAgendarConsulta);
            Controls.Add(comboBoxColaboradorAgendarConsulta);
            Controls.Add(labelHoraConsultaAgendarConsulta);
            Controls.Add(labelDataConsultaAgendarConsulta);
            Controls.Add(labelTelemovelConsulta);
            Controls.Add(labelColaboradorConsulta);
            Controls.Add(buttonConfirmarNIFDono);
            Controls.Add(listBoxAnimaisPesquisados);
            Controls.Add(textBoxPesquisarNIFDono);
            Controls.Add(labelProcurarPorNIFDono);
            Name = "AgendarConsulta";
            Text = "AgendarConsulta";
            Load += AgendarConsulta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProcurarPorNIFDono;
        private TextBox textBoxPesquisarNIFDono;
        private ListBox listBoxAnimaisPesquisados;
        private Button buttonConfirmarNIFDono;
        private Label labelColaboradorConsulta;
        private Label labelTelemovelConsulta;
        private Label labelDataConsultaAgendarConsulta;
        private Label labelHoraConsultaAgendarConsulta;
        private ComboBox comboBoxColaboradorAgendarConsulta;
        private DateTimePicker dateTimePickerDataConsultaAgendarConsulta;
        private TextBox textBoxTelemovelAgendarConsulta;
        private Button buttonConfirmarAgendarConsulta;
        private DateTimePicker dateTimePickerHoraConsultaAgendarConsulta;
    }
}