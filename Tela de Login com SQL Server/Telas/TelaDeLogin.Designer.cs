namespace Tela_de_Login_com_SQL_Server
{
    partial class TelaDeLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuário = new Label();
            lblSenha = new Label();
            btnEntrar = new Button();
            btnSair = new Button();
            btnCadastro = new Button();
            txbUsuario = new TextBox();
            txbSenha = new TextBox();
            SuspendLayout();
            // 
            // lblUsuário
            // 
            lblUsuário.AutoSize = true;
            lblUsuário.Location = new Point(261, 35);
            lblUsuário.Name = "lblUsuário";
            lblUsuário.Size = new Size(47, 15);
            lblUsuário.TabIndex = 0;
            lblUsuário.Text = "Usuário";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(261, 90);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(261, 139);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(348, 139);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(261, 168);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(162, 23);
            btnCadastro.TabIndex = 4;
            btnCadastro.Text = "Cadastro";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // txbUsuario
            // 
            txbUsuario.Location = new Point(261, 53);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(162, 23);
            txbUsuario.TabIndex = 5;
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(261, 110);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(162, 23);
            txbSenha.TabIndex = 6;
            // 
            // TelaDeLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 249);
            Controls.Add(txbSenha);
            Controls.Add(txbUsuario);
            Controls.Add(btnCadastro);
            Controls.Add(btnSair);
            Controls.Add(btnEntrar);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuário);
            Name = "TelaDeLogin";
            Text = "Tela de Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuário;
        private Label lblSenha;
        private Button btnEntrar;
        private Button btnSair;
        private Button btnCadastro;
        private TextBox txbUsuario;
        private TextBox txbSenha;
    }
}