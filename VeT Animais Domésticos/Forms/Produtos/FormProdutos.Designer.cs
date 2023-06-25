namespace VeT_Animais_Domésticos.Forms.Produtos
{
    partial class FormProdutos
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
            buttonProdutosInativos = new Button();
            buttonVoltarProdutos = new Button();
            dataGridViewProdutos = new DataGridView();
            buttonEliminarColaboradores = new Button();
            buttonModificarProdutos = new Button();
            buttonConsultarProdutos = new Button();
            buttonAdicionarProduto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            SuspendLayout();
            // 
            // buttonProdutosInativos
            // 
            buttonProdutosInativos.Location = new Point(635, 384);
            buttonProdutosInativos.Name = "buttonProdutosInativos";
            buttonProdutosInativos.Size = new Size(142, 54);
            buttonProdutosInativos.TabIndex = 22;
            buttonProdutosInativos.Text = "Mostrar Produtos Inativos";
            buttonProdutosInativos.UseVisualStyleBackColor = true;
            buttonProdutosInativos.Click += buttonProdutosInativos_Click;
            // 
            // buttonVoltarProdutos
            // 
            buttonVoltarProdutos.Location = new Point(12, 397);
            buttonVoltarProdutos.Name = "buttonVoltarProdutos";
            buttonVoltarProdutos.Size = new Size(97, 41);
            buttonVoltarProdutos.TabIndex = 21;
            buttonVoltarProdutos.Text = "Voltar";
            buttonVoltarProdutos.UseVisualStyleBackColor = true;
            buttonVoltarProdutos.Click += buttonVoltarProdutos_Click;
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.AccessibleRole = AccessibleRole.ScrollBar;
            dataGridViewProdutos.AllowUserToResizeColumns = false;
            dataGridViewProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProdutos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProdutos.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.ColumnHeadersVisible = false;
            dataGridViewProdutos.Location = new Point(12, 12);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.RowTemplate.Height = 25;
            dataGridViewProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProdutos.ShowCellErrors = false;
            dataGridViewProdutos.ShowCellToolTips = false;
            dataGridViewProdutos.ShowEditingIcon = false;
            dataGridViewProdutos.ShowRowErrors = false;
            dataGridViewProdutos.Size = new Size(776, 257);
            dataGridViewProdutos.StandardTab = true;
            dataGridViewProdutos.TabIndex = 20;
            dataGridViewProdutos.Visible = false;
            // 
            // buttonEliminarColaboradores
            // 
            buttonEliminarColaboradores.Location = new Point(551, 293);
            buttonEliminarColaboradores.Name = "buttonEliminarColaboradores";
            buttonEliminarColaboradores.Size = new Size(117, 44);
            buttonEliminarColaboradores.TabIndex = 19;
            buttonEliminarColaboradores.Text = "Eliminar Produtos";
            buttonEliminarColaboradores.UseVisualStyleBackColor = true;
            buttonEliminarColaboradores.Click += buttonEliminarColaboradores_Click;
            // 
            // buttonModificarProdutos
            // 
            buttonModificarProdutos.Location = new Point(396, 291);
            buttonModificarProdutos.Name = "buttonModificarProdutos";
            buttonModificarProdutos.Size = new Size(114, 46);
            buttonModificarProdutos.TabIndex = 18;
            buttonModificarProdutos.Text = "Modificar Produtos";
            buttonModificarProdutos.UseVisualStyleBackColor = true;
            buttonModificarProdutos.Click += buttonModificarProdutos_Click_1;
            // 
            // buttonConsultarProdutos
            // 
            buttonConsultarProdutos.Location = new Point(234, 291);
            buttonConsultarProdutos.Name = "buttonConsultarProdutos";
            buttonConsultarProdutos.Size = new Size(132, 46);
            buttonConsultarProdutos.TabIndex = 17;
            buttonConsultarProdutos.Text = "Consultar Produtos";
            buttonConsultarProdutos.UseVisualStyleBackColor = true;
            buttonConsultarProdutos.Click += buttonConsultarProdutos_Click_1;
            // 
            // buttonAdicionarProduto
            // 
            buttonAdicionarProduto.Location = new Point(89, 291);
            buttonAdicionarProduto.Name = "buttonAdicionarProduto";
            buttonAdicionarProduto.Size = new Size(112, 46);
            buttonAdicionarProduto.TabIndex = 16;
            buttonAdicionarProduto.Text = "Adicionar Produto";
            buttonAdicionarProduto.UseVisualStyleBackColor = true;
            buttonAdicionarProduto.Click += buttonAdicionarProduto_Click;
            // 
            // FormProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonProdutosInativos);
            Controls.Add(buttonVoltarProdutos);
            Controls.Add(dataGridViewProdutos);
            Controls.Add(buttonEliminarColaboradores);
            Controls.Add(buttonModificarProdutos);
            Controls.Add(buttonConsultarProdutos);
            Controls.Add(buttonAdicionarProduto);
            Name = "FormProdutos";
            Text = "FormProdutos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonProdutosInativos;
        private Button buttonVoltarProdutos;
        private DataGridView dataGridViewProdutos;
        private Button buttonEliminarColaboradores;
        private Button buttonModificarProdutos;
        private Button buttonConsultarProdutos;
        private Button buttonAdicionarProduto;
    }
}