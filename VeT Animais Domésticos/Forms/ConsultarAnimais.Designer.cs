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
            buttonPesquisarComDono = new Button();
            buttonPesquisarSemDono = new Button();
            labelNIFDono = new Label();
            textBoxNIFDono = new TextBox();
            dataGridViewAnimais = new DataGridView();
            buttonVoltarConsultarAnimais = new Button();
            buttonModificarAnimal = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimais).BeginInit();
            SuspendLayout();
            // 
            // buttonPesquisarComDono
            // 
            buttonPesquisarComDono.Location = new Point(355, 65);
            buttonPesquisarComDono.Name = "buttonPesquisarComDono";
            buttonPesquisarComDono.Size = new Size(120, 52);
            buttonPesquisarComDono.TabIndex = 0;
            buttonPesquisarComDono.Text = "Pesquisar Animal com Dono";
            buttonPesquisarComDono.UseVisualStyleBackColor = true;
            buttonPesquisarComDono.Click += buttonPesquisarComDono_Click;
            // 
            // buttonPesquisarSemDono
            // 
            buttonPesquisarSemDono.Location = new Point(355, 364);
            buttonPesquisarSemDono.Name = "buttonPesquisarSemDono";
            buttonPesquisarSemDono.Size = new Size(120, 52);
            buttonPesquisarSemDono.TabIndex = 1;
            buttonPesquisarSemDono.Text = "Pesquisar Animal Sem Dono";
            buttonPesquisarSemDono.UseVisualStyleBackColor = true;
            buttonPesquisarSemDono.Click += buttonPesquisarSemDono_Click;
            // 
            // labelNIFDono
            // 
            labelNIFDono.AutoSize = true;
            labelNIFDono.Location = new Point(215, 39);
            labelNIFDono.Name = "labelNIFDono";
            labelNIFDono.Size = new Size(77, 15);
            labelNIFDono.TabIndex = 2;
            labelNIFDono.Text = "NIF do Dono:";
            // 
            // textBoxNIFDono
            // 
            textBoxNIFDono.Location = new Point(298, 36);
            textBoxNIFDono.Name = "textBoxNIFDono";
            textBoxNIFDono.Size = new Size(229, 23);
            textBoxNIFDono.TabIndex = 3;
            // 
            // dataGridViewAnimais
            // 
            dataGridViewAnimais.AccessibleRole = AccessibleRole.ScrollBar;
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
            dataGridViewAnimais.Location = new Point(63, 123);
            dataGridViewAnimais.Name = "dataGridViewAnimais";
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
            buttonModificarAnimal.Location = new Point(629, 367);
            buttonModificarAnimal.Name = "buttonModificarAnimal";
            buttonModificarAnimal.Size = new Size(112, 46);
            buttonModificarAnimal.TabIndex = 7;
            buttonModificarAnimal.Text = "Modificar Animal";
            buttonModificarAnimal.UseVisualStyleBackColor = false;
            buttonModificarAnimal.Click += buttonModificarAnimal_Click;
            // 
            // ConsultarAnimais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonModificarAnimal);
            Controls.Add(buttonVoltarConsultarAnimais);
            Controls.Add(dataGridViewAnimais);
            Controls.Add(textBoxNIFDono);
            Controls.Add(labelNIFDono);
            Controls.Add(buttonPesquisarSemDono);
            Controls.Add(buttonPesquisarComDono);
            Name = "ConsultarAnimais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Animais";
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
    }
}