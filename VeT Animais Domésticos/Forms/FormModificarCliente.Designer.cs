namespace VeT_Animais_Domésticos.Forms
{
    partial class FormModificarCliente
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
            buttonAtualizar = new Button();
            labelNomeCompleto = new Label();
            textBoxAtualizarNomeCompleto = new TextBox();
            AtualizardateNascimento = new DateTimePicker();
            textBoxAtualizarTelemovel = new TextBox();
            labelDataNascimento = new Label();
            textBoxAtualizarNIF = new TextBox();
            labelTelemovel = new Label();
            labelNIF = new Label();
            tabPageAnimal = new TabPage();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            labelFiliacaoPai = new Label();
            labelFiliacaoMae = new Label();
            labelPesoAnimal = new Label();
            labelSexoAnimal = new Label();
            labelRaçaAnimal = new Label();
            labelTipoAnimal = new Label();
            labelDataNascimentoAnimal = new Label();
            labelDono = new Label();
            tabControlRegistoClienteAnimal.SuspendLayout();
            tabPageCliente.SuspendLayout();
            tabPageAnimal.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegistoClienteAnimal
            // 
            tabControlRegistoClienteAnimal.Controls.Add(tabPageCliente);
            tabControlRegistoClienteAnimal.Controls.Add(tabPageAnimal);
            tabControlRegistoClienteAnimal.Location = new Point(2, 2);
            tabControlRegistoClienteAnimal.Name = "tabControlRegistoClienteAnimal";
            tabControlRegistoClienteAnimal.SelectedIndex = 0;
            tabControlRegistoClienteAnimal.Size = new Size(797, 447);
            tabControlRegistoClienteAnimal.TabIndex = 1;
            // 
            // tabPageCliente
            // 
            tabPageCliente.Controls.Add(buttonAtualizar);
            tabPageCliente.Controls.Add(labelNomeCompleto);
            tabPageCliente.Controls.Add(textBoxAtualizarNomeCompleto);
            tabPageCliente.Controls.Add(AtualizardateNascimento);
            tabPageCliente.Controls.Add(textBoxAtualizarTelemovel);
            tabPageCliente.Controls.Add(labelDataNascimento);
            tabPageCliente.Controls.Add(textBoxAtualizarNIF);
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
            // buttonAtualizar
            // 
            buttonAtualizar.Location = new Point(582, 205);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(96, 43);
            buttonAtualizar.TabIndex = 18;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = true;
            buttonAtualizar.Click += buttonAtualizar_Click;
            // 
            // labelNomeCompleto
            // 
            labelNomeCompleto.AutoSize = true;
            labelNomeCompleto.Location = new Point(84, 38);
            labelNomeCompleto.Name = "labelNomeCompleto";
            labelNomeCompleto.Size = new Size(99, 15);
            labelNomeCompleto.TabIndex = 8;
            labelNomeCompleto.Text = "Nome Completo:";
            // 
            // textBoxAtualizarNomeCompleto
            // 
            textBoxAtualizarNomeCompleto.Location = new Point(186, 32);
            textBoxAtualizarNomeCompleto.Name = "textBoxAtualizarNomeCompleto";
            textBoxAtualizarNomeCompleto.Size = new Size(453, 23);
            textBoxAtualizarNomeCompleto.TabIndex = 9;
            textBoxAtualizarNomeCompleto.TextChanged += textBoxAtualizarNomeCompleto_TextChanged;
            // 
            // AtualizardateNascimento
            // 
            AtualizardateNascimento.Location = new Point(188, 129);
            AtualizardateNascimento.Name = "AtualizardateNascimento";
            AtualizardateNascimento.Size = new Size(200, 23);
            AtualizardateNascimento.TabIndex = 14;
            // 
            // textBoxAtualizarTelemovel
            // 
            textBoxAtualizarTelemovel.Location = new Point(186, 185);
            textBoxAtualizarTelemovel.Name = "textBoxAtualizarTelemovel";
            textBoxAtualizarTelemovel.Size = new Size(202, 23);
            textBoxAtualizarTelemovel.TabIndex = 15;
            // 
            // labelDataNascimento
            // 
            labelDataNascimento.AutoSize = true;
            labelDataNascimento.Location = new Point(84, 132);
            labelDataNascimento.Name = "labelDataNascimento";
            labelDataNascimento.Size = new Size(101, 15);
            labelDataNascimento.TabIndex = 10;
            labelDataNascimento.Text = "Data Nascimento:";
            // 
            // textBoxAtualizarNIF
            // 
            textBoxAtualizarNIF.Location = new Point(188, 77);
            textBoxAtualizarNIF.Name = "textBoxAtualizarNIF";
            textBoxAtualizarNIF.Size = new Size(200, 23);
            textBoxAtualizarNIF.TabIndex = 13;
            // 
            // labelTelemovel
            // 
            labelTelemovel.AutoSize = true;
            labelTelemovel.Location = new Point(120, 191);
            labelTelemovel.Name = "labelTelemovel";
            labelTelemovel.Size = new Size(63, 15);
            labelTelemovel.TabIndex = 12;
            labelTelemovel.Text = "Telemóvel:";
            // 
            // labelNIF
            // 
            labelNIF.AutoSize = true;
            labelNIF.Location = new Point(157, 83);
            labelNIF.Name = "labelNIF";
            labelNIF.Size = new Size(28, 15);
            labelNIF.TabIndex = 11;
            labelNIF.Text = "NIF:";
            // 
            // tabPageAnimal
            // 
            tabPageAnimal.Controls.Add(textBox8);
            tabPageAnimal.Controls.Add(textBox7);
            tabPageAnimal.Controls.Add(textBox6);
            tabPageAnimal.Controls.Add(textBox5);
            tabPageAnimal.Controls.Add(textBox4);
            tabPageAnimal.Controls.Add(textBox3);
            tabPageAnimal.Controls.Add(textBox2);
            tabPageAnimal.Controls.Add(textBox1);
            tabPageAnimal.Controls.Add(labelFiliacaoPai);
            tabPageAnimal.Controls.Add(labelFiliacaoMae);
            tabPageAnimal.Controls.Add(labelPesoAnimal);
            tabPageAnimal.Controls.Add(labelSexoAnimal);
            tabPageAnimal.Controls.Add(labelRaçaAnimal);
            tabPageAnimal.Controls.Add(labelTipoAnimal);
            tabPageAnimal.Controls.Add(labelDataNascimentoAnimal);
            tabPageAnimal.Controls.Add(labelDono);
            tabPageAnimal.Location = new Point(4, 24);
            tabPageAnimal.Name = "tabPageAnimal";
            tabPageAnimal.Padding = new Padding(3);
            tabPageAnimal.Size = new Size(789, 419);
            tabPageAnimal.TabIndex = 1;
            tabPageAnimal.Text = "Animal";
            tabPageAnimal.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(140, 266);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(436, 23);
            textBox8.TabIndex = 15;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(140, 226);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(436, 23);
            textBox7.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(140, 190);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(436, 23);
            textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(140, 155);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(436, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(140, 123);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(436, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(140, 88);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(436, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(436, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(436, 23);
            textBox1.TabIndex = 8;
            // 
            // labelFiliacaoPai
            // 
            labelFiliacaoPai.AutoSize = true;
            labelFiliacaoPai.Location = new Point(63, 277);
            labelFiliacaoPai.Name = "labelFiliacaoPai";
            labelFiliacaoPai.Size = new Size(74, 15);
            labelFiliacaoPai.TabIndex = 7;
            labelFiliacaoPai.Text = "Filiação(Pai):";
            // 
            // labelFiliacaoMae
            // 
            labelFiliacaoMae.AutoSize = true;
            labelFiliacaoMae.Location = new Point(56, 232);
            labelFiliacaoMae.Name = "labelFiliacaoMae";
            labelFiliacaoMae.Size = new Size(81, 15);
            labelFiliacaoMae.TabIndex = 6;
            labelFiliacaoMae.Text = "Filiação(Mãe):";
            // 
            // labelPesoAnimal
            // 
            labelPesoAnimal.AutoSize = true;
            labelPesoAnimal.Location = new Point(98, 196);
            labelPesoAnimal.Name = "labelPesoAnimal";
            labelPesoAnimal.Size = new Size(35, 15);
            labelPesoAnimal.TabIndex = 5;
            labelPesoAnimal.Text = "Peso:";
            // 
            // labelSexoAnimal
            // 
            labelSexoAnimal.AutoSize = true;
            labelSexoAnimal.Location = new Point(98, 166);
            labelSexoAnimal.Name = "labelSexoAnimal";
            labelSexoAnimal.Size = new Size(35, 15);
            labelSexoAnimal.TabIndex = 4;
            labelSexoAnimal.Text = "Sexo:";
            // 
            // labelRaçaAnimal
            // 
            labelRaçaAnimal.AutoSize = true;
            labelRaçaAnimal.Location = new Point(98, 129);
            labelRaçaAnimal.Name = "labelRaçaAnimal";
            labelRaçaAnimal.Size = new Size(35, 15);
            labelRaçaAnimal.TabIndex = 3;
            labelRaçaAnimal.Text = "Raça:";
            // 
            // labelTipoAnimal
            // 
            labelTipoAnimal.AutoSize = true;
            labelTipoAnimal.Location = new Point(47, 94);
            labelTipoAnimal.Name = "labelTipoAnimal";
            labelTipoAnimal.Size = new Size(90, 15);
            labelTipoAnimal.TabIndex = 2;
            labelTipoAnimal.Text = "Tipo de Animal:";
            // 
            // labelDataNascimentoAnimal
            // 
            labelDataNascimentoAnimal.AutoSize = true;
            labelDataNascimentoAnimal.Location = new Point(20, 62);
            labelDataNascimentoAnimal.Name = "labelDataNascimentoAnimal";
            labelDataNascimentoAnimal.Size = new Size(117, 15);
            labelDataNascimentoAnimal.TabIndex = 1;
            labelDataNascimentoAnimal.Text = "Data de Nascimento:";
            // 
            // labelDono
            // 
            labelDono.AutoSize = true;
            labelDono.Location = new Point(98, 30);
            labelDono.Name = "labelDono";
            labelDono.Size = new Size(39, 15);
            labelDono.TabIndex = 0;
            labelDono.Text = "Dono:";
            // 
            // FormModificarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlRegistoClienteAnimal);
            Name = "FormModificarCliente";
            Text = "FormModificarCliente";
            Load += FormModificarCliente_Load;
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
        private Button buttonAtualizar;
        private Label labelNomeCompleto;
        private TextBox textBoxAtualizarNomeCompleto;
        private DateTimePicker AtualizardateNascimento;
        private TextBox textBoxAtualizarTelemovel;
        private Label labelDataNascimento;
        private TextBox textBoxAtualizarNIF;
        private Label labelTelemovel;
        private Label labelNIF;
        private TabPage tabPageAnimal;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label labelFiliacaoPai;
        private Label labelFiliacaoMae;
        private Label labelPesoAnimal;
        private Label labelSexoAnimal;
        private Label labelRaçaAnimal;
        private Label labelTipoAnimal;
        private Label labelDataNascimentoAnimal;
        private Label labelDono;
    }
}