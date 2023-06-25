namespace VeT_Animais_Domésticos.Forms
{
    partial class FormConsultarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarClientes));
            buttonAdicionarCliente = new Button();
            buttonConsultarClientes = new Button();
            buttonModificarClientes = new Button();
            buttonEliminarCliente = new Button();
            dataGridViewClientes = new DataGridView();
            buttonVoltarConsultar = new Button();
            pictureBoxClientes = new PictureBox();
            buttonClientesInativos = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClientes).BeginInit();
            SuspendLayout();
            // 
            // buttonAdicionarCliente
            // 
            buttonAdicionarCliente.Location = new Point(89, 291);
            buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            buttonAdicionarCliente.Size = new Size(112, 46);
            buttonAdicionarCliente.TabIndex = 0;
            buttonAdicionarCliente.Text = "Adicionar Cliente";
            buttonAdicionarCliente.UseVisualStyleBackColor = true;
            buttonAdicionarCliente.Click += buttonAdicionarCliente_Click;
            // 
            // buttonConsultarClientes
            // 
            buttonConsultarClientes.Location = new Point(234, 291);
            buttonConsultarClientes.Name = "buttonConsultarClientes";
            buttonConsultarClientes.Size = new Size(132, 46);
            buttonConsultarClientes.TabIndex = 1;
            buttonConsultarClientes.Text = "Consultar Clientes";
            buttonConsultarClientes.UseVisualStyleBackColor = true;
            buttonConsultarClientes.Click += buttonConsultarClientes_Click;
            // 
            // buttonModificarClientes
            // 
            buttonModificarClientes.Location = new Point(396, 291);
            buttonModificarClientes.Name = "buttonModificarClientes";
            buttonModificarClientes.Size = new Size(114, 46);
            buttonModificarClientes.TabIndex = 2;
            buttonModificarClientes.Text = "Modificar Cliente";
            buttonModificarClientes.UseVisualStyleBackColor = true;
            buttonModificarClientes.Click += buttonModificarClientes_Click;
            // 
            // buttonEliminarCliente
            // 
            buttonEliminarCliente.Location = new Point(551, 293);
            buttonEliminarCliente.Name = "buttonEliminarCliente";
            buttonEliminarCliente.Size = new Size(117, 44);
            buttonEliminarCliente.TabIndex = 3;
            buttonEliminarCliente.Text = "Eliminar Cliente";
            buttonEliminarCliente.UseVisualStyleBackColor = true;
            buttonEliminarCliente.Click += buttonEliminarCliente_Click;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AccessibleRole = AccessibleRole.ScrollBar;
            dataGridViewClientes.AllowUserToResizeColumns = false;
            dataGridViewClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewClientes.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.ColumnHeadersVisible = false;
            dataGridViewClientes.Location = new Point(12, 12);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowTemplate.Height = 25;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.ShowCellErrors = false;
            dataGridViewClientes.ShowCellToolTips = false;
            dataGridViewClientes.ShowEditingIcon = false;
            dataGridViewClientes.ShowRowErrors = false;
            dataGridViewClientes.Size = new Size(776, 257);
            dataGridViewClientes.StandardTab = true;
            dataGridViewClientes.TabIndex = 4;
            dataGridViewClientes.Visible = false;
            dataGridViewClientes.CellContentClick += dataGridViewClientes_CellContentClick;
            // 
            // buttonVoltarConsultar
            // 
            buttonVoltarConsultar.Location = new Point(12, 397);
            buttonVoltarConsultar.Name = "buttonVoltarConsultar";
            buttonVoltarConsultar.Size = new Size(97, 41);
            buttonVoltarConsultar.TabIndex = 5;
            buttonVoltarConsultar.Text = "Voltar";
            buttonVoltarConsultar.UseVisualStyleBackColor = true;
            buttonVoltarConsultar.Click += buttonVoltarConsultar_Click;
            // 
            // pictureBoxClientes
            // 
            pictureBoxClientes.Image = (Image)resources.GetObject("pictureBoxClientes.Image");
            pictureBoxClientes.Location = new Point(141, 12);
            pictureBoxClientes.Name = "pictureBoxClientes";
            pictureBoxClientes.Size = new Size(511, 257);
            pictureBoxClientes.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxClientes.TabIndex = 6;
            pictureBoxClientes.TabStop = false;
            // 
            // buttonClientesInativos
            // 
            buttonClientesInativos.Location = new Point(655, 397);
            buttonClientesInativos.Name = "buttonClientesInativos";
            buttonClientesInativos.Size = new Size(122, 41);
            buttonClientesInativos.TabIndex = 7;
            buttonClientesInativos.Text = "Mostrar Clientes Inativos";
            buttonClientesInativos.UseVisualStyleBackColor = true;
            buttonClientesInativos.Click += buttonClientesInativos_Click;
            // 
            // FormConsultarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClientesInativos);
            Controls.Add(pictureBoxClientes);
            Controls.Add(buttonVoltarConsultar);
            Controls.Add(dataGridViewClientes);
            Controls.Add(buttonEliminarCliente);
            Controls.Add(buttonModificarClientes);
            Controls.Add(buttonConsultarClientes);
            Controls.Add(buttonAdicionarCliente);
            Name = "FormConsultarClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += FormConsultarClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionarCliente;
        private Button buttonConsultarClientes;
        private Button buttonModificarClientes;
        private Button buttonEliminarCliente;
        private DataGridView dataGridViewClientes;
        private Button buttonVoltarConsultar;
        private PictureBox pictureBoxClientes;
        private Button buttonClientesInativos;
    }
}