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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ato_MedicosPrincipal));
            buttonAtosMedicosInativos = new Button();
            buttonVoltarAtosMedicos = new Button();
            dataGridViewAtosMedicos = new DataGridView();
            buttonEliminarAtoMedico = new Button();
            buttonAlterarAtosMedicos = new Button();
            buttonConsultarAtosMedicos = new Button();
            buttonAdicionarAtoMedico = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtosMedicos).BeginInit();
            SuspendLayout();
            // 
            // buttonAtosMedicosInativos
            // 
            buttonAtosMedicosInativos.Location = new Point(635, 384);
            buttonAtosMedicosInativos.Name = "buttonAtosMedicosInativos";
            buttonAtosMedicosInativos.Size = new Size(142, 54);
            buttonAtosMedicosInativos.TabIndex = 22;
            buttonAtosMedicosInativos.Text = "Mostrar Atos Médicos Inativos";
            buttonAtosMedicosInativos.UseVisualStyleBackColor = true;
            buttonAtosMedicosInativos.Click += buttonAtosMedicosInativos_Click;
            // 
            // buttonVoltarAtosMedicos
            // 
            buttonVoltarAtosMedicos.Location = new Point(12, 397);
            buttonVoltarAtosMedicos.Name = "buttonVoltarAtosMedicos";
            buttonVoltarAtosMedicos.Size = new Size(97, 41);
            buttonVoltarAtosMedicos.TabIndex = 21;
            buttonVoltarAtosMedicos.Text = "Voltar";
            buttonVoltarAtosMedicos.UseVisualStyleBackColor = true;
            buttonVoltarAtosMedicos.Click += buttonVoltarAtosMedicos_Click;
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
            // buttonEliminarAtoMedico
            // 
            buttonEliminarAtoMedico.Location = new Point(551, 293);
            buttonEliminarAtoMedico.Name = "buttonEliminarAtoMedico";
            buttonEliminarAtoMedico.Size = new Size(117, 44);
            buttonEliminarAtoMedico.TabIndex = 19;
            buttonEliminarAtoMedico.Text = "Eliminar Ato Médico";
            buttonEliminarAtoMedico.UseVisualStyleBackColor = true;
            buttonEliminarAtoMedico.Click += buttonEliminarAtoMedico_Click;
            // 
            // buttonAlterarAtosMedicos
            // 
            buttonAlterarAtosMedicos.Location = new Point(396, 291);
            buttonAlterarAtosMedicos.Name = "buttonAlterarAtosMedicos";
            buttonAlterarAtosMedicos.Size = new Size(114, 46);
            buttonAlterarAtosMedicos.TabIndex = 18;
            buttonAlterarAtosMedicos.Text = "Alterar Ato Médico";
            buttonAlterarAtosMedicos.UseVisualStyleBackColor = true;
            buttonAlterarAtosMedicos.Click += buttonAlterarAtosMedicos_Click;
            // 
            // buttonConsultarAtosMedicos
            // 
            buttonConsultarAtosMedicos.Location = new Point(234, 291);
            buttonConsultarAtosMedicos.Name = "buttonConsultarAtosMedicos";
            buttonConsultarAtosMedicos.Size = new Size(132, 46);
            buttonConsultarAtosMedicos.TabIndex = 17;
            buttonConsultarAtosMedicos.Text = "Consultar Atos Médicos";
            buttonConsultarAtosMedicos.UseVisualStyleBackColor = true;
            buttonConsultarAtosMedicos.Click += buttonConsultarAtosMedicos_Click;
            // 
            // buttonAdicionarAtoMedico
            // 
            buttonAdicionarAtoMedico.Location = new Point(89, 291);
            buttonAdicionarAtoMedico.Name = "buttonAdicionarAtoMedico";
            buttonAdicionarAtoMedico.Size = new Size(112, 46);
            buttonAdicionarAtoMedico.TabIndex = 16;
            buttonAdicionarAtoMedico.Text = "Adicionar Ato Médico";
            buttonAdicionarAtoMedico.UseVisualStyleBackColor = true;
            buttonAdicionarAtoMedico.Click += buttonAdicionarAtoMedico_Click;
            // 
            // Ato_MedicosPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAtosMedicosInativos);
            Controls.Add(buttonVoltarAtosMedicos);
            Controls.Add(dataGridViewAtosMedicos);
            Controls.Add(buttonEliminarAtoMedico);
            Controls.Add(buttonAlterarAtosMedicos);
            Controls.Add(buttonConsultarAtosMedicos);
            Controls.Add(buttonAdicionarAtoMedico);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Ato_MedicosPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atos Médicos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtosMedicos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAtosMedicosInativos;
        private Button buttonVoltarAtosMedicos;
        private DataGridView dataGridViewAtosMedicos;
        private Button buttonEliminarAtoMedico;
        private Button buttonAlterarAtosMedicos;
        private Button buttonConsultarAtosMedicos;
        private Button buttonAdicionarAtoMedico;
    }
}