namespace VeT_Animais_Domésticos.Forms
{
    partial class AdicionarAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarAnimal));
            buttonVoltarRegistoAnimal = new Button();
            buttonRegistarAnimal = new Button();
            textBoxFiliacaoPai = new TextBox();
            textBoxFiliacaoMae = new TextBox();
            textBoxPesoAnimal = new TextBox();
            textBoxSexoAnimal = new TextBox();
            textBoxRacaAnimal = new TextBox();
            textBoxTipoAnimal = new TextBox();
            textBoxDataNascimentoAnimal = new TextBox();
            textBoxDono = new TextBox();
            labelFiliacaoPai = new Label();
            labelFiliacaoMae = new Label();
            labelPesoAnimal = new Label();
            labelSexoAnimal = new Label();
            labelRaçaAnimal = new Label();
            labelTipoAnimal = new Label();
            labelDataNascimentoAnimal = new Label();
            labelDonoNIF = new Label();
            SuspendLayout();
            // 
            // buttonVoltarRegistoAnimal
            // 
            buttonVoltarRegistoAnimal.Location = new Point(22, 376);
            buttonVoltarRegistoAnimal.Name = "buttonVoltarRegistoAnimal";
            buttonVoltarRegistoAnimal.Size = new Size(101, 43);
            buttonVoltarRegistoAnimal.TabIndex = 36;
            buttonVoltarRegistoAnimal.Text = "Voltar";
            buttonVoltarRegistoAnimal.UseVisualStyleBackColor = true;
            buttonVoltarRegistoAnimal.Click += buttonVoltarRegistoAnimal_Click;
            // 
            // buttonRegistarAnimal
            // 
            buttonRegistarAnimal.Location = new Point(677, 376);
            buttonRegistarAnimal.Name = "buttonRegistarAnimal";
            buttonRegistarAnimal.Size = new Size(101, 43);
            buttonRegistarAnimal.TabIndex = 35;
            buttonRegistarAnimal.Text = "Registar";
            buttonRegistarAnimal.UseVisualStyleBackColor = true;
            buttonRegistarAnimal.Click += buttonRegistarAnimal_Click;
            // 
            // textBoxFiliacaoPai
            // 
            textBoxFiliacaoPai.Location = new Point(263, 302);
            textBoxFiliacaoPai.Name = "textBoxFiliacaoPai";
            textBoxFiliacaoPai.Size = new Size(436, 23);
            textBoxFiliacaoPai.TabIndex = 34;
            // 
            // textBoxFiliacaoMae
            // 
            textBoxFiliacaoMae.Location = new Point(263, 262);
            textBoxFiliacaoMae.Name = "textBoxFiliacaoMae";
            textBoxFiliacaoMae.Size = new Size(436, 23);
            textBoxFiliacaoMae.TabIndex = 33;
            // 
            // textBoxPesoAnimal
            // 
            textBoxPesoAnimal.Location = new Point(263, 226);
            textBoxPesoAnimal.Name = "textBoxPesoAnimal";
            textBoxPesoAnimal.Size = new Size(436, 23);
            textBoxPesoAnimal.TabIndex = 32;
            // 
            // textBoxSexoAnimal
            // 
            textBoxSexoAnimal.Location = new Point(263, 191);
            textBoxSexoAnimal.Name = "textBoxSexoAnimal";
            textBoxSexoAnimal.Size = new Size(436, 23);
            textBoxSexoAnimal.TabIndex = 31;
            // 
            // textBoxRacaAnimal
            // 
            textBoxRacaAnimal.Location = new Point(263, 159);
            textBoxRacaAnimal.Name = "textBoxRacaAnimal";
            textBoxRacaAnimal.Size = new Size(436, 23);
            textBoxRacaAnimal.TabIndex = 30;
            // 
            // textBoxTipoAnimal
            // 
            textBoxTipoAnimal.Location = new Point(263, 124);
            textBoxTipoAnimal.Name = "textBoxTipoAnimal";
            textBoxTipoAnimal.Size = new Size(436, 23);
            textBoxTipoAnimal.TabIndex = 29;
            // 
            // textBoxDataNascimentoAnimal
            // 
            textBoxDataNascimentoAnimal.Location = new Point(263, 92);
            textBoxDataNascimentoAnimal.Name = "textBoxDataNascimentoAnimal";
            textBoxDataNascimentoAnimal.Size = new Size(436, 23);
            textBoxDataNascimentoAnimal.TabIndex = 28;
            // 
            // textBoxDono
            // 
            textBoxDono.Location = new Point(263, 60);
            textBoxDono.Name = "textBoxDono";
            textBoxDono.Size = new Size(436, 23);
            textBoxDono.TabIndex = 27;
            // 
            // labelFiliacaoPai
            // 
            labelFiliacaoPai.AutoSize = true;
            labelFiliacaoPai.BackColor = Color.Transparent;
            labelFiliacaoPai.Location = new Point(183, 310);
            labelFiliacaoPai.Name = "labelFiliacaoPai";
            labelFiliacaoPai.Size = new Size(74, 15);
            labelFiliacaoPai.TabIndex = 26;
            labelFiliacaoPai.Text = "Filiação(Pai):";
            // 
            // labelFiliacaoMae
            // 
            labelFiliacaoMae.AutoSize = true;
            labelFiliacaoMae.BackColor = Color.Transparent;
            labelFiliacaoMae.Location = new Point(176, 265);
            labelFiliacaoMae.Name = "labelFiliacaoMae";
            labelFiliacaoMae.Size = new Size(81, 15);
            labelFiliacaoMae.TabIndex = 25;
            labelFiliacaoMae.Text = "Filiação(Mãe):";
            // 
            // labelPesoAnimal
            // 
            labelPesoAnimal.AutoSize = true;
            labelPesoAnimal.BackColor = Color.Transparent;
            labelPesoAnimal.Location = new Point(218, 229);
            labelPesoAnimal.Name = "labelPesoAnimal";
            labelPesoAnimal.Size = new Size(35, 15);
            labelPesoAnimal.TabIndex = 24;
            labelPesoAnimal.Text = "Peso:";
            // 
            // labelSexoAnimal
            // 
            labelSexoAnimal.AutoSize = true;
            labelSexoAnimal.BackColor = Color.Transparent;
            labelSexoAnimal.Location = new Point(218, 199);
            labelSexoAnimal.Name = "labelSexoAnimal";
            labelSexoAnimal.Size = new Size(35, 15);
            labelSexoAnimal.TabIndex = 23;
            labelSexoAnimal.Text = "Sexo:";
            // 
            // labelRaçaAnimal
            // 
            labelRaçaAnimal.AutoSize = true;
            labelRaçaAnimal.BackColor = Color.Transparent;
            labelRaçaAnimal.Location = new Point(218, 162);
            labelRaçaAnimal.Name = "labelRaçaAnimal";
            labelRaçaAnimal.Size = new Size(35, 15);
            labelRaçaAnimal.TabIndex = 22;
            labelRaçaAnimal.Text = "Raça:";
            // 
            // labelTipoAnimal
            // 
            labelTipoAnimal.AutoSize = true;
            labelTipoAnimal.BackColor = Color.Transparent;
            labelTipoAnimal.Location = new Point(167, 127);
            labelTipoAnimal.Name = "labelTipoAnimal";
            labelTipoAnimal.Size = new Size(90, 15);
            labelTipoAnimal.TabIndex = 21;
            labelTipoAnimal.Text = "Tipo de Animal:";
            // 
            // labelDataNascimentoAnimal
            // 
            labelDataNascimentoAnimal.AutoSize = true;
            labelDataNascimentoAnimal.BackColor = Color.Transparent;
            labelDataNascimentoAnimal.Location = new Point(140, 95);
            labelDataNascimentoAnimal.Name = "labelDataNascimentoAnimal";
            labelDataNascimentoAnimal.Size = new Size(117, 15);
            labelDataNascimentoAnimal.TabIndex = 20;
            labelDataNascimentoAnimal.Text = "Data de Nascimento:";
            // 
            // labelDonoNIF
            // 
            labelDonoNIF.AutoSize = true;
            labelDonoNIF.BackColor = Color.Transparent;
            labelDonoNIF.Location = new Point(180, 63);
            labelDonoNIF.Name = "labelDonoNIF";
            labelDonoNIF.Size = new Size(77, 15);
            labelDonoNIF.TabIndex = 19;
            labelDonoNIF.Text = "NIF do Dono:";
            // 
            // AdicionarAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonVoltarRegistoAnimal);
            Controls.Add(buttonRegistarAnimal);
            Controls.Add(textBoxFiliacaoPai);
            Controls.Add(textBoxFiliacaoMae);
            Controls.Add(textBoxPesoAnimal);
            Controls.Add(textBoxSexoAnimal);
            Controls.Add(textBoxRacaAnimal);
            Controls.Add(textBoxTipoAnimal);
            Controls.Add(textBoxDataNascimentoAnimal);
            Controls.Add(textBoxDono);
            Controls.Add(labelFiliacaoPai);
            Controls.Add(labelFiliacaoMae);
            Controls.Add(labelPesoAnimal);
            Controls.Add(labelSexoAnimal);
            Controls.Add(labelRaçaAnimal);
            Controls.Add(labelTipoAnimal);
            Controls.Add(labelDataNascimentoAnimal);
            Controls.Add(labelDonoNIF);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdicionarAnimal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Animal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVoltarRegistoAnimal;
        private Button buttonRegistarAnimal;
        private TextBox textBoxFiliacaoPai;
        private TextBox textBoxFiliacaoMae;
        private TextBox textBoxPesoAnimal;
        private TextBox textBoxSexoAnimal;
        private TextBox textBoxRacaAnimal;
        private TextBox textBoxTipoAnimal;
        private TextBox textBoxDataNascimentoAnimal;
        private TextBox textBoxDono;
        private Label labelFiliacaoPai;
        private Label labelFiliacaoMae;
        private Label labelPesoAnimal;
        private Label labelSexoAnimal;
        private Label labelRaçaAnimal;
        private Label labelTipoAnimal;
        private Label labelDataNascimentoAnimal;
        private Label labelDonoNIF;
    }
}