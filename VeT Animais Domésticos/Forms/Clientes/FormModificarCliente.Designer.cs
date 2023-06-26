namespace VeT_Animais_Domésticos.Forms
{
    partial class FormAdicionarAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicionarAnimal));
            tabPageCliente = new TabPage();
            buttonAtualizar = new Button();
            labelNomeCompleto = new Label();
            textBoxAtualizarNomeCompleto = new TextBox();
            textBoxAtualizarTelemovel = new TextBox();
            textBoxAtualizarNIF = new TextBox();
            AtualizardateNascimento = new DateTimePicker();
            labelDataNascimento = new Label();
            labelTelemovel = new Label();
            labelNIF = new Label();
            tabControlRegistoClienteAnimal = new TabControl();
            tabPageCliente.SuspendLayout();
            tabControlRegistoClienteAnimal.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCliente
            // 
            tabPageCliente.BackgroundImage = (Image)resources.GetObject("tabPageCliente.BackgroundImage");
            tabPageCliente.BackgroundImageLayout = ImageLayout.Stretch;
            tabPageCliente.Controls.Add(buttonAtualizar);
            tabPageCliente.Controls.Add(labelNomeCompleto);
            tabPageCliente.Controls.Add(textBoxAtualizarNomeCompleto);
            tabPageCliente.Controls.Add(textBoxAtualizarTelemovel);
            tabPageCliente.Controls.Add(textBoxAtualizarNIF);
            tabPageCliente.Controls.Add(AtualizardateNascimento);
            tabPageCliente.Controls.Add(labelDataNascimento);
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
            buttonAtualizar.BackColor = Color.White;
            buttonAtualizar.Location = new Point(582, 205);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(96, 43);
            buttonAtualizar.TabIndex = 18;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = false;
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
            // textBoxAtualizarTelemovel
            // 
            textBoxAtualizarTelemovel.Location = new Point(184, 150);
            textBoxAtualizarTelemovel.Name = "textBoxAtualizarTelemovel";
            textBoxAtualizarTelemovel.Size = new Size(202, 23);
            textBoxAtualizarTelemovel.TabIndex = 15;
            // 
            // textBoxAtualizarNIF
            // 
            textBoxAtualizarNIF.Location = new Point(188, 77);
            textBoxAtualizarNIF.Name = "textBoxAtualizarNIF";
            textBoxAtualizarNIF.Size = new Size(200, 23);
            textBoxAtualizarNIF.TabIndex = 13;
            // 
            // AtualizardateNascimento
            // 
            AtualizardateNascimento.Location = new Point(186, 115);
            AtualizardateNascimento.Name = "AtualizardateNascimento";
            AtualizardateNascimento.Size = new Size(200, 23);
            AtualizardateNascimento.TabIndex = 14;
            // 
            // labelDataNascimento
            // 
            labelDataNascimento.AutoSize = true;
            labelDataNascimento.Location = new Point(84, 121);
            labelDataNascimento.Name = "labelDataNascimento";
            labelDataNascimento.Size = new Size(101, 15);
            labelDataNascimento.TabIndex = 10;
            labelDataNascimento.Text = "Data Nascimento:";
            // 
            // labelTelemovel
            // 
            labelTelemovel.AutoSize = true;
            labelTelemovel.Location = new Point(115, 153);
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
            // tabControlRegistoClienteAnimal
            // 
            tabControlRegistoClienteAnimal.Controls.Add(tabPageCliente);
            tabControlRegistoClienteAnimal.Location = new Point(2, 2);
            tabControlRegistoClienteAnimal.Name = "tabControlRegistoClienteAnimal";
            tabControlRegistoClienteAnimal.SelectedIndex = 0;
            tabControlRegistoClienteAnimal.Size = new Size(797, 447);
            tabControlRegistoClienteAnimal.TabIndex = 1;
            // 
            // FormAdicionarAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlRegistoClienteAnimal);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAdicionarAnimal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Cliente";
            Load += FormModificarCliente_Load;
            tabPageCliente.ResumeLayout(false);
            tabPageCliente.PerformLayout();
            tabControlRegistoClienteAnimal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPageCliente;
        private Button buttonAtualizar;
        private Label labelNomeCompleto;
        private TextBox textBoxAtualizarNomeCompleto;
        private TextBox textBoxAtualizarTelemovel;
        private TextBox textBoxAtualizarNIF;
        private DateTimePicker AtualizardateNascimento;
        private Label labelDataNascimento;
        private Label labelTelemovel;
        private Label labelNIF;
        private TabControl tabControlRegistoClienteAnimal;
    }
}