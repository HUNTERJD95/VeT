namespace VeT_Animais_Domésticos.Forms
{
    partial class FormConsultarAnimais
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            buttonPesquisarComDono = new Button();
            buttonPesquisarSemDono = new Button();
            labelNIFDono = new Label();
            textBoxNIFDono = new TextBox();
            dataGridViewAnimais = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimais).BeginInit();
            SuspendLayout();
            // 
            // buttonPesquisarComDono
            // 
            buttonPesquisarComDono.Location = new Point(325, 46);
            buttonPesquisarComDono.Name = "buttonPesquisarComDono";
            buttonPesquisarComDono.Size = new Size(120, 52);
            buttonPesquisarComDono.TabIndex = 0;
            buttonPesquisarComDono.Text = "Pesquisar Animal com Dono";
            buttonPesquisarComDono.UseVisualStyleBackColor = true;
            buttonPesquisarComDono.Click += buttonPesquisarComDono_Click;
            // 
            // buttonPesquisarSemDono
            // 
            buttonPesquisarSemDono.Location = new Point(626, 386);
            buttonPesquisarSemDono.Name = "buttonPesquisarSemDono";
            buttonPesquisarSemDono.Size = new Size(120, 52);
            buttonPesquisarSemDono.TabIndex = 1;
            buttonPesquisarSemDono.Text = "Pesquisar Animal Sem Dono";
            buttonPesquisarSemDono.UseVisualStyleBackColor = true;
            // 
            // labelNIFDono
            // 
            labelNIFDono.AutoSize = true;
            labelNIFDono.Location = new Point(125, 129);
            labelNIFDono.Name = "labelNIFDono";
            labelNIFDono.Size = new Size(77, 15);
            labelNIFDono.TabIndex = 2;
            labelNIFDono.Text = "NIF do Dono:";
            // 
            // textBoxNIFDono
            // 
            textBoxNIFDono.Location = new Point(208, 126);
            textBoxNIFDono.Name = "textBoxNIFDono";
            textBoxNIFDono.Size = new Size(229, 23);
            textBoxNIFDono.TabIndex = 3;
            // 
            // dataGridViewAnimais
            // 
            dataGridViewAnimais.AccessibleRole = AccessibleRole.ScrollBar;
            dataGridViewAnimais.AllowUserToResizeColumns = false;
            dataGridViewAnimais.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = Color.Silver;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewAnimais.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAnimais.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAnimais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAnimais.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewAnimais.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewAnimais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnimais.ColumnHeadersVisible = false;
            dataGridViewAnimais.Location = new Point(58, 172);
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
            // FormConsultarAnimais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewAnimais);
            Controls.Add(textBoxNIFDono);
            Controls.Add(labelNIFDono);
            Controls.Add(buttonPesquisarSemDono);
            Controls.Add(buttonPesquisarComDono);
            Name = "FormConsultarAnimais";
            Text = "FormConsultarAnimais";
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
    }
}