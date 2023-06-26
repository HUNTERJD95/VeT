namespace VeT_Animais_Domésticos.Forms
{
    partial class Ato_MedicosPrincipal
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
            buttonColaboradoresInativos = new Button();
            buttonVoltarConsultar = new Button();
            dataGridViewAtosMedicos = new DataGridView();
            buttonEliminarColaboradores = new Button();
            buttonModificarColaboradores = new Button();
            buttonConsultarColaboradores = new Button();
            buttonAdicionarAtoMedico = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtosMedicos).BeginInit();
            SuspendLayout();
            // 
            // buttonColaboradoresInativos
            // 
            buttonColaboradoresInativos.Location = new Point(635, 384);
            buttonColaboradoresInativos.Name = "buttonColaboradoresInativos";
            buttonColaboradoresInativos.Size = new Size(142, 54);
            buttonColaboradoresInativos.TabIndex = 22;
            buttonColaboradoresInativos.Text = "Mostrar Colaboradores Inativos";
            buttonColaboradoresInativos.UseVisualStyleBackColor = true;
            // 
            // buttonVoltarConsultar
            // 
            buttonVoltarConsultar.Location = new Point(12, 397);
            buttonVoltarConsultar.Name = "buttonVoltarConsultar";
            buttonVoltarConsultar.Size = new Size(97, 41);
            buttonVoltarConsultar.TabIndex = 21;
            buttonVoltarConsultar.Text = "Voltar";
            buttonVoltarConsultar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAtosMedicos
            // 
            dataGridViewAtosMedicos.AccessibleRole = AccessibleRole.ScrollBar;
            dataGridViewAtosMedicos.AllowUserToResizeColumns = false;
            dataGridViewAtosMedicos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewAtosMedicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAtosMedicos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAtosMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAtosMedicos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewAtosMedicos.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewAtosMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAtosMedicos.ColumnHeadersVisible = false;
            dataGridViewAtosMedicos.Location = new Point(12, 12);
            dataGridViewAtosMedicos.Name = "dataGridViewAtosMedicos";
            dataGridViewAtosMedicos.RowTemplate.Height = 25;
            dataGridViewAtosMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAtosMedicos.ShowCellErrors = false;
            dataGridViewAtosMedicos.ShowCellToolTips = false;
            dataGridViewAtosMedicos.ShowEditingIcon = false;
            dataGridViewAtosMedicos.ShowRowErrors = false;
            dataGridViewAtosMedicos.Size = new Size(776, 257);
            dataGridViewAtosMedicos.StandardTab = true;
            dataGridViewAtosMedicos.TabIndex = 20;
            dataGridViewAtosMedicos.Visible = false;
            // 
            // buttonEliminarColaboradores
            // 
            buttonEliminarColaboradores.Location = new Point(551, 293);
            buttonEliminarColaboradores.Name = "buttonEliminarColaboradores";
            buttonEliminarColaboradores.Size = new Size(117, 44);
            buttonEliminarColaboradores.TabIndex = 19;
            buttonEliminarColaboradores.Text = "Eliminar Colaborador";
            buttonEliminarColaboradores.UseVisualStyleBackColor = true;
            // 
            // buttonModificarColaboradores
            // 
            buttonModificarColaboradores.Location = new Point(396, 291);
            buttonModificarColaboradores.Name = "buttonModificarColaboradores";
            buttonModificarColaboradores.Size = new Size(114, 46);
            buttonModificarColaboradores.TabIndex = 18;
            buttonModificarColaboradores.Text = "Modificar Colaborador";
            buttonModificarColaboradores.UseVisualStyleBackColor = true;
            // 
            // buttonConsultarColaboradores
            // 
            buttonConsultarColaboradores.Location = new Point(234, 291);
            buttonConsultarColaboradores.Name = "buttonConsultarColaboradores";
            buttonConsultarColaboradores.Size = new Size(132, 46);
            buttonConsultarColaboradores.TabIndex = 17;
            buttonConsultarColaboradores.Text = "Consultar Colaboradores";
            buttonConsultarColaboradores.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarAtoMedico
            // 
            buttonAdicionarAtoMedico.Location = new Point(89, 291);
            buttonAdicionarAtoMedico.Name = "buttonAdicionarAtoMedico";
            buttonAdicionarAtoMedico.Size = new Size(112, 46);
            buttonAdicionarAtoMedico.TabIndex = 16;
            buttonAdicionarAtoMedico.Text = "Adicionar Ato Médico";
            buttonAdicionarAtoMedico.UseVisualStyleBackColor = true;
            // 
            // Ato_MedicosPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonColaboradoresInativos);
            Controls.Add(buttonVoltarConsultar);
            Controls.Add(dataGridViewAtosMedicos);
            Controls.Add(buttonEliminarColaboradores);
            Controls.Add(buttonModificarColaboradores);
            Controls.Add(buttonConsultarColaboradores);
            Controls.Add(buttonAdicionarAtoMedico);
            Name = "Ato_MedicosPrincipal";
            Text = "Ato_MedicosPrincipal";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtosMedicos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonColaboradoresInativos;
        private Button buttonVoltarConsultar;
        private DataGridView dataGridViewAtosMedicos;
        private Button buttonEliminarColaboradores;
        private Button buttonModificarColaboradores;
        private Button buttonConsultarColaboradores;
        private Button buttonAdicionarAtoMedico;
    }
}