namespace VeT_Animais_Domésticos.Forms.Colaboradores
{
    partial class Colaboradores_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Colaboradores_Principal));
            buttonColaboradoresInativos = new Button();
            buttonVoltarConsultar = new Button();
            dataGridViewColaboradores = new DataGridView();
            buttonEliminarColaboradores = new Button();
            buttonModificarColaboradores = new Button();
            buttonConsultarColaboradores = new Button();
            buttonAdicionarColaborador = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewColaboradores).BeginInit();
            SuspendLayout();
            // 
            // buttonColaboradoresInativos
            // 
            buttonColaboradoresInativos.Location = new Point(635, 384);
            buttonColaboradoresInativos.Name = "buttonColaboradoresInativos";
            buttonColaboradoresInativos.Size = new Size(142, 54);
            buttonColaboradoresInativos.TabIndex = 15;
            buttonColaboradoresInativos.Text = "Mostrar Colaboradores Inativos";
            buttonColaboradoresInativos.UseVisualStyleBackColor = true;
            buttonColaboradoresInativos.Click += buttonColaboradoresInativos_Click;
            // 
            // buttonVoltarConsultar
            // 
            buttonVoltarConsultar.Location = new Point(12, 397);
            buttonVoltarConsultar.Name = "buttonVoltarConsultar";
            buttonVoltarConsultar.Size = new Size(97, 41);
            buttonVoltarConsultar.TabIndex = 13;
            buttonVoltarConsultar.Text = "Voltar";
            buttonVoltarConsultar.UseVisualStyleBackColor = true;
            buttonVoltarConsultar.Click += buttonVoltarConsultar_Click;
            // 
            // dataGridViewColaboradores
            // 
            dataGridViewColaboradores.AccessibleRole = AccessibleRole.ScrollBar;
            dataGridViewColaboradores.AllowUserToResizeColumns = false;
            dataGridViewColaboradores.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = Color.Silver;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewColaboradores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewColaboradores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewColaboradores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewColaboradores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewColaboradores.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewColaboradores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColaboradores.ColumnHeadersVisible = false;
            dataGridViewColaboradores.Location = new Point(12, 12);
            dataGridViewColaboradores.Name = "dataGridViewColaboradores";
            dataGridViewColaboradores.RowTemplate.Height = 25;
            dataGridViewColaboradores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewColaboradores.ShowCellErrors = false;
            dataGridViewColaboradores.ShowCellToolTips = false;
            dataGridViewColaboradores.ShowEditingIcon = false;
            dataGridViewColaboradores.ShowRowErrors = false;
            dataGridViewColaboradores.Size = new Size(776, 257);
            dataGridViewColaboradores.StandardTab = true;
            dataGridViewColaboradores.TabIndex = 12;
            dataGridViewColaboradores.Visible = false;
            // 
            // buttonEliminarColaboradores
            // 
            buttonEliminarColaboradores.Location = new Point(551, 293);
            buttonEliminarColaboradores.Name = "buttonEliminarColaboradores";
            buttonEliminarColaboradores.Size = new Size(117, 44);
            buttonEliminarColaboradores.TabIndex = 11;
            buttonEliminarColaboradores.Text = "Eliminar IdColaborador";
            buttonEliminarColaboradores.UseVisualStyleBackColor = true;
            buttonEliminarColaboradores.Click += buttonEliminarColaboradores_Click;
            // 
            // buttonModificarColaboradores
            // 
            buttonModificarColaboradores.Location = new Point(396, 291);
            buttonModificarColaboradores.Name = "buttonModificarColaboradores";
            buttonModificarColaboradores.Size = new Size(114, 46);
            buttonModificarColaboradores.TabIndex = 10;
            buttonModificarColaboradores.Text = "Modificar IdColaborador";
            buttonModificarColaboradores.UseVisualStyleBackColor = true;
            buttonModificarColaboradores.Click += buttonModificarColaboradores_Click;
            // 
            // buttonConsultarColaboradores
            // 
            buttonConsultarColaboradores.Location = new Point(234, 291);
            buttonConsultarColaboradores.Name = "buttonConsultarColaboradores";
            buttonConsultarColaboradores.Size = new Size(132, 46);
            buttonConsultarColaboradores.TabIndex = 9;
            buttonConsultarColaboradores.Text = "Consultar Colaboradores";
            buttonConsultarColaboradores.UseVisualStyleBackColor = true;
            buttonConsultarColaboradores.Click += buttonConsultarColaboradores_Click;
            // 
            // buttonAdicionarColaborador
            // 
            buttonAdicionarColaborador.Location = new Point(89, 291);
            buttonAdicionarColaborador.Name = "buttonAdicionarColaborador";
            buttonAdicionarColaborador.Size = new Size(112, 46);
            buttonAdicionarColaborador.TabIndex = 8;
            buttonAdicionarColaborador.Text = "Adicionar IdColaborador";
            buttonAdicionarColaborador.UseVisualStyleBackColor = true;
            buttonAdicionarColaborador.Click += buttonAdicionarColaborador_Click;
            // 
            // Colaboradores_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonColaboradoresInativos);
            Controls.Add(buttonVoltarConsultar);
            Controls.Add(dataGridViewColaboradores);
            Controls.Add(buttonEliminarColaboradores);
            Controls.Add(buttonModificarColaboradores);
            Controls.Add(buttonConsultarColaboradores);
            Controls.Add(buttonAdicionarColaborador);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Colaboradores_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Colaboradores";
            ((System.ComponentModel.ISupportInitialize)dataGridViewColaboradores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonColaboradoresInativos;
        private Button buttonVoltarConsultar;
        private DataGridView dataGridViewColaboradores;
        private Button buttonEliminarColaboradores;
        private Button buttonModificarColaboradores;
        private Button buttonConsultarColaboradores;
        private Button buttonAdicionarColaborador;
    }
}