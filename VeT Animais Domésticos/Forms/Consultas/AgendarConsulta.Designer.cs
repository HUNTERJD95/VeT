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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendarConsulta));
            labelProcurarPorNIFDono = new Label();
            textBoxPesquisarNIFDono = new TextBox();
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
            dataGridViewAgendarConsulta = new DataGridView();
            buttonListaConsultas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgendarConsulta).BeginInit();
            SuspendLayout();
            // 
            // labelProcurarPorNIFDono
            // 
            labelProcurarPorNIFDono.AutoSize = true;
            labelProcurarPorNIFDono.BackColor = Color.Transparent;
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
            labelColaboradorConsulta.BackColor = Color.Transparent;
            labelColaboradorConsulta.Location = new Point(27, 254);
            labelColaboradorConsulta.Name = "labelColaboradorConsulta";
            labelColaboradorConsulta.Size = new Size(76, 15);
            labelColaboradorConsulta.TabIndex = 4;
            labelColaboradorConsulta.Text = "Colaborador:";
            labelColaboradorConsulta.Visible = false;
            // 
            // labelTelemovelConsulta
            // 
            labelTelemovelConsulta.AutoSize = true;
            labelTelemovelConsulta.BackColor = Color.Transparent;
            labelTelemovelConsulta.Location = new Point(40, 287);
            labelTelemovelConsulta.Name = "labelTelemovelConsulta";
            labelTelemovelConsulta.Size = new Size(63, 15);
            labelTelemovelConsulta.TabIndex = 5;
            labelTelemovelConsulta.Text = "Telemóvel:";
            labelTelemovelConsulta.Visible = false;
            // 
            // labelDataConsultaAgendarConsulta
            // 
            labelDataConsultaAgendarConsulta.AutoSize = true;
            labelDataConsultaAgendarConsulta.BackColor = Color.Transparent;
            labelDataConsultaAgendarConsulta.Location = new Point(19, 324);
            labelDataConsultaAgendarConsulta.Name = "labelDataConsultaAgendarConsulta";
            labelDataConsultaAgendarConsulta.Size = new Size(84, 15);
            labelDataConsultaAgendarConsulta.TabIndex = 6;
            labelDataConsultaAgendarConsulta.Text = "Data Consulta:";
            labelDataConsultaAgendarConsulta.Visible = false;
            // 
            // labelHoraConsultaAgendarConsulta
            // 
            labelHoraConsultaAgendarConsulta.AutoSize = true;
            labelHoraConsultaAgendarConsulta.BackColor = Color.Transparent;
            labelHoraConsultaAgendarConsulta.Location = new Point(17, 359);
            labelHoraConsultaAgendarConsulta.Name = "labelHoraConsultaAgendarConsulta";
            labelHoraConsultaAgendarConsulta.Size = new Size(86, 15);
            labelHoraConsultaAgendarConsulta.TabIndex = 7;
            labelHoraConsultaAgendarConsulta.Text = "Hora Consulta:";
            labelHoraConsultaAgendarConsulta.Visible = false;
            // 
            // comboBoxColaboradorAgendarConsulta
            // 
            comboBoxColaboradorAgendarConsulta.FormattingEnabled = true;
            comboBoxColaboradorAgendarConsulta.Location = new Point(109, 251);
            comboBoxColaboradorAgendarConsulta.Name = "comboBoxColaboradorAgendarConsulta";
            comboBoxColaboradorAgendarConsulta.Size = new Size(149, 23);
            comboBoxColaboradorAgendarConsulta.TabIndex = 8;
            comboBoxColaboradorAgendarConsulta.Visible = false;
            // 
            // dateTimePickerDataConsultaAgendarConsulta
            // 
            dateTimePickerDataConsultaAgendarConsulta.Format = DateTimePickerFormat.Short;
            dateTimePickerDataConsultaAgendarConsulta.Location = new Point(109, 318);
            dateTimePickerDataConsultaAgendarConsulta.Name = "dateTimePickerDataConsultaAgendarConsulta";
            dateTimePickerDataConsultaAgendarConsulta.Size = new Size(200, 23);
            dateTimePickerDataConsultaAgendarConsulta.TabIndex = 9;
            dateTimePickerDataConsultaAgendarConsulta.Visible = false;
            // 
            // textBoxTelemovelAgendarConsulta
            // 
            textBoxTelemovelAgendarConsulta.Location = new Point(109, 284);
            textBoxTelemovelAgendarConsulta.Name = "textBoxTelemovelAgendarConsulta";
            textBoxTelemovelAgendarConsulta.Size = new Size(149, 23);
            textBoxTelemovelAgendarConsulta.TabIndex = 10;
            textBoxTelemovelAgendarConsulta.Visible = false;
            // 
            // buttonConfirmarAgendarConsulta
            // 
            buttonConfirmarAgendarConsulta.Location = new Point(342, 323);
            buttonConfirmarAgendarConsulta.Name = "buttonConfirmarAgendarConsulta";
            buttonConfirmarAgendarConsulta.Size = new Size(93, 51);
            buttonConfirmarAgendarConsulta.TabIndex = 11;
            buttonConfirmarAgendarConsulta.Text = "Confirmar";
            buttonConfirmarAgendarConsulta.UseVisualStyleBackColor = true;
            buttonConfirmarAgendarConsulta.Visible = false;
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
            dateTimePickerHoraConsultaAgendarConsulta.Visible = false;
            // 
            // dataGridViewAgendarConsulta
            // 
            dataGridViewAgendarConsulta.AccessibleRole = AccessibleRole.ScrollBar;
            dataGridViewAgendarConsulta.AllowUserToAddRows = false;
            dataGridViewAgendarConsulta.AllowUserToDeleteRows = false;
            dataGridViewAgendarConsulta.AllowUserToResizeColumns = false;
            dataGridViewAgendarConsulta.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewAgendarConsulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAgendarConsulta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAgendarConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAgendarConsulta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewAgendarConsulta.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewAgendarConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAgendarConsulta.ColumnHeadersVisible = false;
            dataGridViewAgendarConsulta.Location = new Point(27, 83);
            dataGridViewAgendarConsulta.Name = "dataGridViewAgendarConsulta";
            dataGridViewAgendarConsulta.ReadOnly = true;
            dataGridViewAgendarConsulta.RowTemplate.Height = 25;
            dataGridViewAgendarConsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAgendarConsulta.ShowCellErrors = false;
            dataGridViewAgendarConsulta.ShowCellToolTips = false;
            dataGridViewAgendarConsulta.ShowEditingIcon = false;
            dataGridViewAgendarConsulta.ShowRowErrors = false;
            dataGridViewAgendarConsulta.Size = new Size(743, 146);
            dataGridViewAgendarConsulta.StandardTab = true;
            dataGridViewAgendarConsulta.TabIndex = 13;
            dataGridViewAgendarConsulta.Visible = false;
            // 
            // buttonListaConsultas
            // 
            buttonListaConsultas.Location = new Point(654, 342);
            buttonListaConsultas.Name = "buttonListaConsultas";
            buttonListaConsultas.Size = new Size(116, 75);
            buttonListaConsultas.TabIndex = 14;
            buttonListaConsultas.Text = "Listar Consultas Para o Dia";
            buttonListaConsultas.UseVisualStyleBackColor = true;
            buttonListaConsultas.Click += buttonListaConsultas_Click;
            // 
            // AgendarConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonListaConsultas);
            Controls.Add(dataGridViewAgendarConsulta);
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
            Controls.Add(textBoxPesquisarNIFDono);
            Controls.Add(labelProcurarPorNIFDono);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AgendarConsulta";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendar Consulta";
            Load += AgendarConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgendarConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProcurarPorNIFDono;
        private TextBox textBoxPesquisarNIFDono;
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
        private DataGridView dataGridViewAgendarConsulta;
        private Button buttonListaConsultas;
    }
}