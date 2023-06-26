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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            buttonClientes = new Button();
            buttonAnimais = new Button();
            buttonColaboradores = new Button();
            buttonProdutos = new Button();
            buttonConsultas = new Button();
            buttonAtosMedicos = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonClientes
            // 
            buttonClientes.Location = new Point(211, 152);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(86, 39);
            buttonClientes.TabIndex = 0;
            buttonClientes.Text = "Clientes";
            buttonClientes.UseVisualStyleBackColor = true;
            buttonClientes.Click += buttonClientes_Click;
            // 
            // buttonAnimais
            // 
            buttonAnimais.Location = new Point(355, 152);
            buttonAnimais.Name = "buttonAnimais";
            buttonAnimais.Size = new Size(86, 39);
            buttonAnimais.TabIndex = 1;
            buttonAnimais.Text = "Animais";
            buttonAnimais.UseVisualStyleBackColor = true;
            buttonAnimais.Click += buttonAnimais_Click;
            // 
            // buttonColaboradores
            // 
            buttonColaboradores.Location = new Point(345, 261);
            buttonColaboradores.Name = "buttonColaboradores";
            buttonColaboradores.Size = new Size(106, 39);
            buttonColaboradores.TabIndex = 2;
            buttonColaboradores.Text = "Colaboradores";
            buttonColaboradores.UseVisualStyleBackColor = true;
            buttonColaboradores.Click += buttonColaboradores_Click;
            // 
            // buttonProdutos
            // 
            buttonProdutos.Location = new Point(496, 261);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Size = new Size(113, 39);
            buttonProdutos.TabIndex = 3;
            buttonProdutos.Text = "Produtos";
            buttonProdutos.UseVisualStyleBackColor = true;
            buttonProdutos.Click += buttonProdutos_Click;
            // 
            // buttonConsultas
            // 
            buttonConsultas.Location = new Point(496, 152);
            buttonConsultas.Name = "buttonConsultas";
            buttonConsultas.Size = new Size(113, 39);
            buttonConsultas.TabIndex = 4;
            buttonConsultas.Text = "Consultas";
            buttonConsultas.UseVisualStyleBackColor = true;
            buttonConsultas.Click += buttonConsultas_Click;
            // 
            // buttonAtosMedicos
            // 
            buttonAtosMedicos.Location = new Point(197, 261);
            buttonAtosMedicos.Name = "buttonAtosMedicos";
            buttonAtosMedicos.Size = new Size(113, 39);
            buttonAtosMedicos.TabIndex = 5;
            buttonAtosMedicos.Text = "Atos Médicos";
            buttonAtosMedicos.UseVisualStyleBackColor = true;
            buttonAtosMedicos.Click += buttonAtosMedicos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(222, 45);
            label1.Name = "label1";
            label1.Size = new Size(348, 35);
            label1.TabIndex = 6;
            label1.Text = "VeT Clínica Veterinária";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonAtosMedicos);
            Controls.Add(buttonConsultas);
            Controls.Add(buttonProdutos);
            Controls.Add(buttonColaboradores);
            Controls.Add(buttonAnimais);
            Controls.Add(buttonClientes);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VeT Animais Domésticos";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClientes;
        private Button buttonAnimais;
        private Button buttonColaboradores;
        private Button buttonProdutos;
        private Button buttonConsultas;
        private Button buttonAtosMedicos;
        private Label label1;
    }
}