namespace VeT_Animais_Domésticos.Forms
{
    partial class FormPrincipal
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
            buttonClientes = new Button();
            buttonAnimais = new Button();
            buttonColaboradores = new Button();
            buttonProdutos = new Button();
            buttonConsultas = new Button();
            SuspendLayout();
            // 
            // buttonClientes
            // 
            buttonClientes.Location = new Point(87, 342);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(86, 39);
            buttonClientes.TabIndex = 0;
            buttonClientes.Text = "Clientes";
            buttonClientes.UseVisualStyleBackColor = true;
            buttonClientes.Click += buttonClientes_Click;
            // 
            // buttonAnimais
            // 
            buttonAnimais.Location = new Point(220, 342);
            buttonAnimais.Name = "buttonAnimais";
            buttonAnimais.Size = new Size(86, 39);
            buttonAnimais.TabIndex = 1;
            buttonAnimais.Text = "Animais";
            buttonAnimais.UseVisualStyleBackColor = true;
            buttonAnimais.Click += buttonAnimais_Click;
            // 
            // buttonColaboradores
            // 
            buttonColaboradores.Location = new Point(339, 342);
            buttonColaboradores.Name = "buttonColaboradores";
            buttonColaboradores.Size = new Size(113, 39);
            buttonColaboradores.TabIndex = 2;
            buttonColaboradores.Text = "Colaboradores";
            buttonColaboradores.UseVisualStyleBackColor = true;
            buttonColaboradores.Click += buttonColaboradores_Click;
            // 
            // buttonProdutos
            // 
            buttonProdutos.Location = new Point(480, 342);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Size = new Size(113, 39);
            buttonProdutos.TabIndex = 3;
            buttonProdutos.Text = "Produtos";
            buttonProdutos.UseVisualStyleBackColor = true;
            buttonProdutos.Click += buttonProdutos_Click;
            // 
            // buttonConsultas
            // 
            buttonConsultas.Location = new Point(618, 342);
            buttonConsultas.Name = "buttonConsultas";
            buttonConsultas.Size = new Size(113, 39);
            buttonConsultas.TabIndex = 4;
            buttonConsultas.Text = "Consultas";
            buttonConsultas.UseVisualStyleBackColor = true;
            buttonConsultas.Click += buttonConsultas_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonConsultas);
            Controls.Add(buttonProdutos);
            Controls.Add(buttonColaboradores);
            Controls.Add(buttonAnimais);
            Controls.Add(buttonClientes);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VeT Animais Domésticos";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonClientes;
        private Button buttonAnimais;
        private Button buttonColaboradores;
        private Button buttonProdutos;
        private Button buttonConsultas;
    }
}