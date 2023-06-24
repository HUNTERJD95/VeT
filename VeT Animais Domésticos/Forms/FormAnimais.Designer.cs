namespace VeT_Animais_Domésticos.Forms
{
    partial class FormAnimais
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
            buttonAdicionarAnimal = new Button();
            buttonConsultarAnimal = new Button();
            buttonVoltarAnimais = new Button();
            SuspendLayout();
            // 
            // buttonAdicionarAnimal
            // 
            buttonAdicionarAnimal.Location = new Point(172, 262);
            buttonAdicionarAnimal.Name = "buttonAdicionarAnimal";
            buttonAdicionarAnimal.Size = new Size(112, 46);
            buttonAdicionarAnimal.TabIndex = 1;
            buttonAdicionarAnimal.Text = "Adicionar Animal";
            buttonAdicionarAnimal.UseVisualStyleBackColor = true;
            buttonAdicionarAnimal.Click += buttonAdicionarAnimal_Click;
            // 
            // buttonConsultarAnimal
            // 
            buttonConsultarAnimal.Location = new Point(351, 262);
            buttonConsultarAnimal.Name = "buttonConsultarAnimal";
            buttonConsultarAnimal.Size = new Size(112, 46);
            buttonConsultarAnimal.TabIndex = 2;
            buttonConsultarAnimal.Text = "Consultar Animal";
            buttonConsultarAnimal.UseVisualStyleBackColor = true;
            buttonConsultarAnimal.Click += buttonConsultarAnimal_Click;
            // 
            // buttonVoltarAnimais
            // 
            buttonVoltarAnimais.Location = new Point(45, 398);
            buttonVoltarAnimais.Name = "buttonVoltarAnimais";
            buttonVoltarAnimais.Size = new Size(83, 31);
            buttonVoltarAnimais.TabIndex = 5;
            buttonVoltarAnimais.Text = "Voltar";
            buttonVoltarAnimais.UseVisualStyleBackColor = true;
            buttonVoltarAnimais.Click += buttonVoltarAnimais_Click;
            // 
            // FormAnimais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonVoltarAnimais);
            Controls.Add(buttonConsultarAnimal);
            Controls.Add(buttonAdicionarAnimal);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormAnimais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Animais";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionarAnimal;
        private Button buttonConsultarAnimal;
        private Button buttonVoltarAnimais;
    }
}