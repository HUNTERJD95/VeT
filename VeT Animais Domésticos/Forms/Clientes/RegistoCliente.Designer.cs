namespace VeT_Animais_Domésticos.Forms
{
    partial class RegistoCliente
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
            tabControlRegistoClienteAnimal = new TabControl();
            tabPageCliente = new TabPage();
            buttonVoltarRegistoCliente = new Button();
            buttonRegistar = new Button();
            labelNomeCompleto = new Label();
            textBoxNomeCompleto = new TextBox();
            dateNascimento = new DateTimePicker();
            textBoxTelemovel = new TextBox();
            labelDataNascimento = new Label();
            textBoxNIF = new TextBox();
            labelTelemovel = new Label();
            labelNIF = new Label();
            tabPageAnimal = new TabPage();
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
            tabControlRegistoClienteAnimal.SuspendLayout();
            tabPageCliente.SuspendLayout();
            tabPageAnimal.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegistoClienteAnimal
            // 
            tabControlRegistoClienteAnimal.Controls.Add(tabPageCliente);
            tabControlRegistoClienteAnimal.Controls.Add(tabPageAnimal);
            tabControlRegistoClienteAnimal.Location = new Point(0, 3);
            tabControlRegistoClienteAnimal.Name = "tabControlRegistoClienteAnimal";
            tabControlRegistoClienteAnimal.SelectedIndex = 0;
            tabControlRegistoClienteAnimal.Size = new Size(797, 447);
            tabControlRegistoClienteAnimal.TabIndex = 0;
            // 
            // tabPageCliente
            // 
            tabPageCliente.Controls.Add(buttonVoltarRegistoCliente);
            tabPageCliente.Controls.Add(buttonRegistar);
            tabPageCliente.Controls.Add(labelNomeCompleto);
            tabPageCliente.Controls.Add(textBoxNomeCompleto);
            tabPageCliente.Controls.Add(dateNascimento);
            tabPageCliente.Controls.Add(textBoxTelemovel);
            tabPageCliente.Controls.Add(labelDataNascimento);
            tabPageCliente.Controls.Add(textBoxNIF);
            tabPageCliente.Controls.Add(labelTelemovel);
            tabPageCliente.Controls.Add(labelNIF);
            tabPageCliente.Location = new Point(4, 24);
            tabPageCliente.Name = "tabPageCliente";
            tabPageCliente.Padding = new Padding(3);
            tabPageCliente.Size = new Size(789, 419);
            tabPageCliente.TabIndex = 0;
            tabPageCliente.Text = "Cliente";
            tabPageCliente.UseVisualStyleBackColor = true;
            // 
            // buttonVoltarRegistoCliente
            // 
            buttonVoltarRegistoCliente.Location = new Point(8, 370);
            buttonVoltarRegistoCliente.Name = "buttonVoltarRegistoCliente";
            buttonVoltarRegistoCliente.Size = new Size(123, 43);
            buttonVoltarRegistoCliente.TabIndex = 17;
            buttonVoltarRegistoCliente.Text = "Voltar";
            buttonVoltarRegistoCliente.UseVisualStyleBackColor = true;
            buttonVoltarRegistoCliente.Click += buttonVoltarRegistoCliente_Click;
            // 
            // buttonRegistar
            // 
            buttonRegistar.Location = new Point(682, 368);
            buttonRegistar.Name = "buttonRegistar";
            buttonRegistar.Size = new Size(101, 43);
            buttonRegistar.TabIndex = 16;
            buttonRegistar.Text = "Registar";
            buttonRegistar.UseVisualStyleBackColor = true;
            buttonRegistar.Click += buttonRegistar_Click;
            // 
            // labelNomeCompleto
            // 
            labelNomeCompleto.AutoSize = true;
            labelNomeCompleto.Location = new Point(58, 66);
            labelNomeCompleto.Name = "labelNomeCompleto";
            labelNomeCompleto.Size = new Size(99, 15);
            labelNomeCompleto.TabIndex = 8;
            labelNomeCompleto.Text = "Nome Completo:";
            // 
            // textBoxNomeCompleto
            // 
            textBoxNomeCompleto.Location = new Point(163, 63);
            textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            textBoxNomeCompleto.Size = new Size(453, 23);
            textBoxNomeCompleto.TabIndex = 9;
            // 
            // dateNascimento
            // 
            dateNascimento.Location = new Point(165, 160);
            dateNascimento.Name = "dateNascimento";
            dateNascimento.Size = new Size(200, 23);
            dateNascimento.TabIndex = 14;
            // 
            // textBoxTelemovel
            // 
            textBoxTelemovel.Location = new Point(163, 216);
            textBoxTelemovel.Name = "textBoxTelemovel";
            textBoxTelemovel.Size = new Size(202, 23);
            textBoxTelemovel.TabIndex = 15;
            // 
            // labelDataNascimento
            // 
            labelDataNascimento.AutoSize = true;
            labelDataNascimento.Location = new Point(58, 160);
            labelDataNascimento.Name = "labelDataNascimento";
            labelDataNascimento.Size = new Size(101, 15);
            labelDataNascimento.TabIndex = 10;
            labelDataNascimento.Text = "Data Nascimento:";
            // 
            // textBoxNIF
            // 
            textBoxNIF.Location = new Point(165, 108);
            textBoxNIF.Name = "textBoxNIF";
            textBoxNIF.Size = new Size(200, 23);
            textBoxNIF.TabIndex = 13;
            // 
            // labelTelemovel
            // 
            labelTelemovel.AutoSize = true;
            labelTelemovel.Location = new Point(94, 219);
            labelTelemovel.Name = "labelTelemovel";
            labelTelemovel.Size = new Size(63, 15);
            labelTelemovel.TabIndex = 12;
            labelTelemovel.Text = "Telemóvel:";
            // 
            // labelNIF
            // 
            labelNIF.AutoSize = true;
            labelNIF.Location = new Point(131, 111);
            labelNIF.Name = "labelNIF";
            labelNIF.Size = new Size(28, 15);
            labelNIF.TabIndex = 11;
            labelNIF.Text = "NIF:";
            // 
            // tabPageAnimal
            // 
            tabPageAnimal.Controls.Add(buttonVoltarRegistoAnimal);
            tabPageAnimal.Controls.Add(buttonRegistarAnimal);
            tabPageAnimal.Controls.Add(textBoxFiliacaoPai);
            tabPageAnimal.Controls.Add(textBoxFiliacaoMae);
            tabPageAnimal.Controls.Add(textBoxPesoAnimal);
            tabPageAnimal.Controls.Add(textBoxSexoAnimal);
            tabPageAnimal.Controls.Add(textBoxRacaAnimal);
            tabPageAnimal.Controls.Add(textBoxTipoAnimal);
            tabPageAnimal.Controls.Add(textBoxDataNascimentoAnimal);
            tabPageAnimal.Controls.Add(textBoxDono);
            tabPageAnimal.Controls.Add(labelFiliacaoPai);
            tabPageAnimal.Controls.Add(labelFiliacaoMae);
            tabPageAnimal.Controls.Add(labelPesoAnimal);
            tabPageAnimal.Controls.Add(labelSexoAnimal);
            tabPageAnimal.Controls.Add(labelRaçaAnimal);
            tabPageAnimal.Controls.Add(labelTipoAnimal);
            tabPageAnimal.Controls.Add(labelDataNascimentoAnimal);
            tabPageAnimal.Controls.Add(labelDonoNIF);
            tabPageAnimal.Location = new Point(4, 24);
            tabPageAnimal.Name = "tabPageAnimal";
            tabPageAnimal.Padding = new Padding(3);
            tabPageAnimal.Size = new Size(789, 419);
            tabPageAnimal.TabIndex = 1;
            tabPageAnimal.Text = "Animal";
            tabPageAnimal.UseVisualStyleBackColor = true;
            // 
            // buttonVoltarRegistoAnimal
            // 
            buttonVoltarRegistoAnimal.Location = new Point(17, 368);
            buttonVoltarRegistoAnimal.Name = "buttonVoltarRegistoAnimal";
            buttonVoltarRegistoAnimal.Size = new Size(101, 43);
            buttonVoltarRegistoAnimal.TabIndex = 18;
            buttonVoltarRegistoAnimal.Text = "Voltar";
            buttonVoltarRegistoAnimal.UseVisualStyleBackColor = true;
            buttonVoltarRegistoAnimal.Click += buttonVoltarRegistoAnimal_Click;
            // 
            // buttonRegistarAnimal
            // 
            buttonRegistarAnimal.Location = new Point(672, 368);
            buttonRegistarAnimal.Name = "buttonRegistarAnimal";
            buttonRegistarAnimal.Size = new Size(101, 43);
            buttonRegistarAnimal.TabIndex = 17;
            buttonRegistarAnimal.Text = "Registar";
            buttonRegistarAnimal.UseVisualStyleBackColor = true;
            buttonRegistarAnimal.Click += buttonRegistarAnimal_Click;
            // 
            // textBoxFiliacaoPai
            // 
            textBoxFiliacaoPai.Location = new Point(140, 266);
            textBoxFiliacaoPai.Name = "textBoxFiliacaoPai";
            textBoxFiliacaoPai.Size = new Size(436, 23);
            textBoxFiliacaoPai.TabIndex = 15;
            textBoxFiliacaoPai.TextChanged += textBoxFiliacaoPai_TextChanged;
            // 
            // textBoxFiliacaoMae
            // 
            textBoxFiliacaoMae.Location = new Point(140, 226);
            textBoxFiliacaoMae.Name = "textBoxFiliacaoMae";
            textBoxFiliacaoMae.Size = new Size(436, 23);
            textBoxFiliacaoMae.TabIndex = 14;
            textBoxFiliacaoMae.TextChanged += textBoxFiliacaoMae_TextChanged;
            // 
            // textBoxPesoAnimal
            // 
            textBoxPesoAnimal.Location = new Point(140, 190);
            textBoxPesoAnimal.Name = "textBoxPesoAnimal";
            textBoxPesoAnimal.Size = new Size(436, 23);
            textBoxPesoAnimal.TabIndex = 13;
            textBoxPesoAnimal.TextChanged += textBoxPesoAnimal_TextChanged;
            // 
            // textBoxSexoAnimal
            // 
            textBoxSexoAnimal.Location = new Point(140, 155);
            textBoxSexoAnimal.Name = "textBoxSexoAnimal";
            textBoxSexoAnimal.Size = new Size(436, 23);
            textBoxSexoAnimal.TabIndex = 12;
            textBoxSexoAnimal.TextChanged += textBoxSexoAnimal_TextChanged;
            // 
            // textBoxRacaAnimal
            // 
            textBoxRacaAnimal.Location = new Point(140, 123);
            textBoxRacaAnimal.Name = "textBoxRacaAnimal";
            textBoxRacaAnimal.Size = new Size(436, 23);
            textBoxRacaAnimal.TabIndex = 11;
            textBoxRacaAnimal.TextChanged += textBoxRacaAnimal_TextChanged;
            // 
            // textBoxTipoAnimal
            // 
            textBoxTipoAnimal.Location = new Point(140, 88);
            textBoxTipoAnimal.Name = "textBoxTipoAnimal";
            textBoxTipoAnimal.Size = new Size(436, 23);
            textBoxTipoAnimal.TabIndex = 10;
            textBoxTipoAnimal.TextChanged += textBoxTipoAnimal_TextChanged;
            // 
            // textBoxDataNascimentoAnimal
            // 
            textBoxDataNascimentoAnimal.Location = new Point(140, 56);
            textBoxDataNascimentoAnimal.Name = "textBoxDataNascimentoAnimal";
            textBoxDataNascimentoAnimal.Size = new Size(436, 23);
            textBoxDataNascimentoAnimal.TabIndex = 9;
            textBoxDataNascimentoAnimal.TextChanged += textBoxDataNascimentoAnimal_TextChanged;
            // 
            // textBoxDono
            // 
            textBoxDono.Location = new Point(140, 24);
            textBoxDono.Name = "textBoxDono";
            textBoxDono.Size = new Size(436, 23);
            textBoxDono.TabIndex = 8;
            textBoxDono.TextChanged += textBox1_TextChanged;
            // 
            // labelFiliacaoPai
            // 
            labelFiliacaoPai.AutoSize = true;
            labelFiliacaoPai.Location = new Point(60, 274);
            labelFiliacaoPai.Name = "labelFiliacaoPai";
            labelFiliacaoPai.Size = new Size(74, 15);
            labelFiliacaoPai.TabIndex = 7;
            labelFiliacaoPai.Text = "Filiação(Pai):";
            labelFiliacaoPai.Click += labelFiliacaoPai_Click;
            // 
            // labelFiliacaoMae
            // 
            labelFiliacaoMae.AutoSize = true;
            labelFiliacaoMae.Location = new Point(53, 229);
            labelFiliacaoMae.Name = "labelFiliacaoMae";
            labelFiliacaoMae.Size = new Size(81, 15);
            labelFiliacaoMae.TabIndex = 6;
            labelFiliacaoMae.Text = "Filiação(Mãe):";
            labelFiliacaoMae.Click += labelFiliacaoMae_Click;
            // 
            // labelPesoAnimal
            // 
            labelPesoAnimal.AutoSize = true;
            labelPesoAnimal.Location = new Point(95, 193);
            labelPesoAnimal.Name = "labelPesoAnimal";
            labelPesoAnimal.Size = new Size(35, 15);
            labelPesoAnimal.TabIndex = 5;
            labelPesoAnimal.Text = "Peso:";
            labelPesoAnimal.Click += labelPesoAnimal_Click;
            // 
            // labelSexoAnimal
            // 
            labelSexoAnimal.AutoSize = true;
            labelSexoAnimal.Location = new Point(95, 163);
            labelSexoAnimal.Name = "labelSexoAnimal";
            labelSexoAnimal.Size = new Size(35, 15);
            labelSexoAnimal.TabIndex = 4;
            labelSexoAnimal.Text = "Sexo:";
            labelSexoAnimal.Click += labelSexoAnimal_Click;
            // 
            // labelRaçaAnimal
            // 
            labelRaçaAnimal.AutoSize = true;
            labelRaçaAnimal.Location = new Point(95, 126);
            labelRaçaAnimal.Name = "labelRaçaAnimal";
            labelRaçaAnimal.Size = new Size(35, 15);
            labelRaçaAnimal.TabIndex = 3;
            labelRaçaAnimal.Text = "Raça:";
            labelRaçaAnimal.Click += labelRaçaAnimal_Click;
            // 
            // labelTipoAnimal
            // 
            labelTipoAnimal.AutoSize = true;
            labelTipoAnimal.Location = new Point(44, 91);
            labelTipoAnimal.Name = "labelTipoAnimal";
            labelTipoAnimal.Size = new Size(90, 15);
            labelTipoAnimal.TabIndex = 2;
            labelTipoAnimal.Text = "Tipo de Animal:";
            labelTipoAnimal.Click += labelTipoAnimal_Click;
            // 
            // labelDataNascimentoAnimal
            // 
            labelDataNascimentoAnimal.AutoSize = true;
            labelDataNascimentoAnimal.Location = new Point(17, 59);
            labelDataNascimentoAnimal.Name = "labelDataNascimentoAnimal";
            labelDataNascimentoAnimal.Size = new Size(117, 15);
            labelDataNascimentoAnimal.TabIndex = 1;
            labelDataNascimentoAnimal.Text = "Data de Nascimento:";
            labelDataNascimentoAnimal.Click += labelDataNascimentoAnimal_Click;
            // 
            // labelDonoNIF
            // 
            labelDonoNIF.AutoSize = true;
            labelDonoNIF.Location = new Point(57, 27);
            labelDonoNIF.Name = "labelDonoNIF";
            labelDonoNIF.Size = new Size(77, 15);
            labelDonoNIF.TabIndex = 0;
            labelDonoNIF.Text = "NIF do Dono:";
            labelDonoNIF.Click += labelDonoNIF_Click;
            // 
            // RegistoCliente
            // 
            AcceptButton = buttonRegistar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlRegistoClienteAnimal);
            Name = "RegistoCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ficha Cliente";
            Load += RegistoCliente_Load;
            tabControlRegistoClienteAnimal.ResumeLayout(false);
            tabPageCliente.ResumeLayout(false);
            tabPageCliente.PerformLayout();
            tabPageAnimal.ResumeLayout(false);
            tabPageAnimal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlRegistoClienteAnimal;
        private TabPage tabPageCliente;
        private Button buttonRegistar;
        private Label labelNomeCompleto;
        private TextBox textBoxNomeCompleto;
        private DateTimePicker dateNascimento;
        private TextBox textBoxTelemovel;
        private Label labelDataNascimento;
        private TextBox textBoxNIF;
        private Label labelTelemovel;
        private Label labelNIF;
        private TabPage tabPageAnimal;
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
        private Button buttonVoltarRegistoCliente;
        private Button buttonVoltarRegistoAnimal;
        private Button buttonRegistarAnimal;
    }
}