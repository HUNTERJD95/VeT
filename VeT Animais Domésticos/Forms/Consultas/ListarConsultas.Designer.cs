namespace VeT_Animais_Domésticos.Forms.Consultas
{
    partial class ListarConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarConsultas));
            dataGridViewListarConsulta = new DataGridView();
            buttonVoltarListarConsultas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListarConsulta).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewListarConsulta
            // 
            dataGridViewListarConsulta.AccessibleRole = AccessibleRole.ScrollBar;
            dataGridViewListarConsulta.AllowUserToAddRows = false;
            dataGridViewListarConsulta.AllowUserToDeleteRows = false;
            dataGridViewListarConsulta.AllowUserToResizeColumns = false;
            dataGridViewListarConsulta.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewListarConsulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewListarConsulta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewListarConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListarConsulta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewListarConsulta.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewListarConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListarConsulta.ColumnHeadersVisible = false;
            dataGridViewListarConsulta.Location = new Point(21, 40);
            dataGridViewListarConsulta.Name = "dataGridViewListarConsulta";
            dataGridViewListarConsulta.ReadOnly = true;
            dataGridViewListarConsulta.RowTemplate.Height = 25;
            dataGridViewListarConsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewListarConsulta.ShowCellErrors = false;
            dataGridViewListarConsulta.ShowCellToolTips = false;
            dataGridViewListarConsulta.ShowEditingIcon = false;
            dataGridViewListarConsulta.ShowRowErrors = false;
            dataGridViewListarConsulta.Size = new Size(743, 346);
            dataGridViewListarConsulta.StandardTab = true;
            dataGridViewListarConsulta.TabIndex = 14;
            // 
            // buttonVoltarListarConsultas
            // 
            buttonVoltarListarConsultas.Location = new Point(346, 400);
            buttonVoltarListarConsultas.Name = "buttonVoltarListarConsultas";
            buttonVoltarListarConsultas.Size = new Size(88, 38);
            buttonVoltarListarConsultas.TabIndex = 15;
            buttonVoltarListarConsultas.Text = "Voltar";
            buttonVoltarListarConsultas.UseVisualStyleBackColor = true;
            buttonVoltarListarConsultas.Click += buttonVoltarListarConsultas_Click;
            // 
            // ListarConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonVoltarListarConsultas);
            Controls.Add(dataGridViewListarConsulta);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListarConsultas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListarConsultas";
            Load += ListarConsultas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewListarConsulta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewListarConsulta;
        private Button buttonVoltarListarConsultas;
    }
}