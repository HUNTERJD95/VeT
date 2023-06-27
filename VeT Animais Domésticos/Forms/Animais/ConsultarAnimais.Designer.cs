namespace VeT_Animais_Domésticos.Forms
{
    partial class ConsultarAnimais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarAnimais));
            buttonPesquisarComDono = new Button();
            buttonPesquisarSemDono = new Button();
            labelNIFDono = new Label();
            textBoxNIFDono = new TextBox();
            dataGridViewAnimais = new DataGridView();
            buttonVoltarConsultarAnimais = new Button();
            buttonModificarAnimal = new Button();
            buttonEliminarAnimal = new Button();
            buttonAnimaisInativos = new Button();
            buttonConsultarFichaMedica = new Button();
            buttonAdicionarAnimal = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimais).BeginInit();
            SuspendLayout();
            // 
            // buttonPesquisarComDono
            // 
            buttonPesquisarComDono.Location = new Point(104, 65);
            buttonPesquisarComDono.Name = "buttonPesquisarComDono";
            buttonPesquisarComDono.Size = new Size(120, 52);
            buttonPesquisarComDono.TabIndex = 0;
            buttonPesquisarComDono.Text = "Pesquisar Animal com Dono";
            buttonPesquisarComDono.UseVisualStyleBackColor = true;
            buttonPesquisarComDono.Click += buttonPesquisarComDono_Click;
            // 
            // buttonPesquisarSemDono
            // 
            buttonPesquisarSemDono.BackColor = Color.CornflowerBlue;
            buttonPesquisarSemDono.Location = new Point(356, 33);
            buttonPesquisarSemDono.Name = "buttonPesquisarSemDono";
            buttonPesquisarSemDono.Size = new Size(120, 52);
            buttonPesquisarSemDono.TabIndex = 1;
            buttonPesquisarSemDono.Text = "Pesquisar Animal Sem Dono";
            buttonPesquisarSemDono.UseVisualStyleBackColor = false;
            buttonPesquisarSemDono.Click += buttonPesquisarSemDono_Click;
            // 
            // labelNIFDono
            // 
            labelNIFDono.AutoSize = true;
            labelNIFDono.Location = new Point(21, 39);
            labelNIFDono.Name = "labelNIFDono";
            labelNIFDono.Size = new Size(77, 15);
            labelNIFDono.TabIndex = 2;
            labelNIFDono.Text = "NIF do Dono:";
            // 
            // textBoxNIFDono
            // 
            textBoxNIFDono.Location = new Point(104, 36);
            textBoxNIFDono.Name = "textBoxNIFDono";
            textBoxNIFDono.Size = new Size(229, 23);
            textBoxNIFDono.TabIndex = 3;
            // 
            // dataGridViewAnimais
            // 
            dataGridViewAnimais.AccessibleRole = AccessibleRole.ScrollBar;
            dataGridViewAnimais.AllowUserToAddRows = false;
            dataGridViewAnimais.AllowUserToDeleteRows = false;
            dataGridViewAnimais.AllowUserToResizeColumns = false;
            dataGridViewAnimais.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewAnimais.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAnimais.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAnimais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAnimais.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewAnimais.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewAnimais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnimais.ColumnHeadersVisible = false;
            dataGridViewAnimais.Location = new Point(12, 123);
            dataGridViewAnimais.Name = "dataGridViewAnimais";
            dataGridViewAnimais.ReadOnly = true;
            dataGridViewAnimais.RowTemplate.Height = 25;
            dataGridViewAnimais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAnimais.ShowCellErrors = false;
            dataGridViewAnimais.ShowCellToolTips = false;
            dataGridViewAnimais.ShowEditingIcon = false;
            dataGridViewAnimais.ShowRowErrors = false;
            dataGridViewAnimais.Size = new Size(678, 219);
            dataGridViewAnimais.StandardTab = true;
            dataGridViewAnimais.TabIndex = 5;
            dataGridViewAnimais.Visible = false;
            dataGridViewAnimais.CellClick += dataGridViewAnimais_CellClick;
            // 
            // buttonVoltarConsultarAnimais
            // 
            buttonVoltarConsultarAnimais.Location = new Point(12, 404);
            buttonVoltarConsultarAnimais.Name = "buttonVoltarConsultarAnimais";
            buttonVoltarConsultarAnimais.Size = new Size(86, 34);
            buttonVoltarConsultarAnimais.TabIndex = 6;
            buttonVoltarConsultarAnimais.Text = "Voltar";
            buttonVoltarConsultarAnimais.UseVisualStyleBackColor = true;
            buttonVoltarConsultarAnimais.Click += button1_Click;
            // 
            // buttonModificarAnimal
            // 
            buttonModificarAnimal.BackColor = Color.FromArgb(255, 255, 128);
            buttonModificarAnimal.Location = new Point(482, 36);
            buttonModificarAnimal.Name = "buttonModificarAnimal";
            buttonModificarAnimal.Size = new Size(112, 46);
            buttonModificarAnimal.TabIndex = 7;
            buttonModificarAnimal.Text = "Modificar Animal";
            buttonModificarAnimal.UseVisualStyleBackColor = false;
            buttonModificarAnimal.Click += buttonModificarAnimal_Click;
            // 
            // buttonEliminarAnimal
            // 
            buttonEliminarAnimal.BackColor = Color.OrangeRed;
            buttonEliminarAnimal.Location = new Point(600, 36);
            buttonEliminarAnimal.Name = "buttonEliminarAnimal";
            buttonEliminarAnimal.Size = new Size(112, 46);
            buttonEliminarAnimal.TabIndex = 8;
            buttonEliminarAnimal.Text = "Eliminar Animal";
            buttonEliminarAnimal.UseVisualStyleBackColor = false;
            buttonEliminarAnimal.Click += buttonEliminarAnimal_Click;
            // 
            // buttonAnimaisInativos
            // 
            buttonAnimaisInativos.Location = new Point(647, 370);
            buttonAnimaisInativos.Name = "buttonAnimaisInativos";
            buttonAnimaisInativos.Size = new Size(112, 50);
            buttonAnimaisInativos.TabIndex = 9;
            buttonAnimaisInativos.Text = "Consultar Animais Inativos";
            buttonAnimaisInativos.UseVisualStyleBackColor = true;
            buttonAnimaisInativos.Click += buttonAnimaisInativos_Click;
            // 
            // buttonConsultarFichaMedica
            // 
            buttonConsultarFichaMedica.BackColor = Color.FromArgb(0, 192, 0);
            buttonConsultarFichaMedica.Location = new Point(526, 370);
            buttonConsultarFichaMedica.Name = "buttonConsultarFichaMedica";
            buttonConsultarFichaMedica.Size = new Size(106, 50);
            buttonConsultarFichaMedica.TabIndex = 10;
            buttonConsultarFichaMedica.Text = "Consultar Ficha Médica";
            buttonConsultarFichaMedica.UseVisualStyleBackColor = false;
            buttonConsultarFichaMedica.Click += buttonFichaMedica_Click;
            // 
            // buttonAdicionarAnimal
            // 
            buttonAdicionarAnimal.Location = new Point(287, 370);
            buttonAdicionarAnimal.Name = "buttonAdicionarAnimal";
            buttonAdicionarAnimal.Size = new Size(112, 46);
            buttonAdicionarAnimal.TabIndex = 11;
            buttonAdicionarAnimal.Text = "Adicionar Animal";
            buttonAdicionarAnimal.UseVisualStyleBackColor = true;
            buttonAdicionarAnimal.Click += buttonAdicionarAnimal_Click;
            // 
            // ConsultarAnimais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAdicionarAnimal);
            Controls.Add(buttonConsultarFichaMedica);
            Controls.Add(buttonAnimaisInativos);
            Controls.Add(buttonEliminarAnimal);
            Controls.Add(buttonModificarAnimal);
            Controls.Add(buttonVoltarConsultarAnimais);
            Controls.Add(dataGridViewAnimais);
            Controls.Add(textBoxNIFDono);
            Controls.Add(labelNIFDono);
            Controls.Add(buttonPesquisarSemDono);
            Controls.Add(buttonPesquisarComDono);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConsultarAnimais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Animais";
            Load += ConsultarAnimais_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPesquisarComDono;
        private Button buttonPesquisarSemDono;
        private Label labelNIFDono;
        private TextBox textBoxNIFDono;
        private DataGridView dataGridViewAnimais;
        private Button buttonVoltarConsultarAnimais;
        private Button buttonModificarAnimal;
        private Button buttonEliminarAnimal;
        private Button buttonAnimaisInativos;
        private Button buttonConsultarFichaMedica;
        private Button buttonAdicionarAnimal;
    }
}