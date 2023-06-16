namespace Tela_de_Login_com_SQL_Server.Telas
{
    partial class Cadastro
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
            lblUsuario = new Label();
            lblSenha = new Label();
            lblConfirmeASenha = new Label();
            txbUsuario = new TextBox();
            txbSenha = new TextBox();
            txbConfirmeASenha = new TextBox();
            btnCriarLogin = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(27, 26);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(27, 80);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha";
            // 
            // lblConfirmeASenha
            // 
            lblConfirmeASenha.AutoSize = true;
            lblConfirmeASenha.Location = new Point(27, 139);
            lblConfirmeASenha.Name = "lblConfirmeASenha";
            lblConfirmeASenha.Size = new Size(101, 15);
            lblConfirmeASenha.TabIndex = 2;
            lblConfirmeASenha.Text = "Confirme a Senha";
            // 
            // txbUsuario
            // 
            txbUsuario.Location = new Point(27, 44);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(100, 23);
            txbUsuario.TabIndex = 3;
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(27, 98);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(100, 23);
            txbSenha.TabIndex = 4;
            // 
            // txbConfirmeASenha
            // 
            txbConfirmeASenha.Location = new Point(27, 157);
            txbConfirmeASenha.Name = "txbConfirmeASenha";
            txbConfirmeASenha.PasswordChar = '*';
            txbConfirmeASenha.Size = new Size(100, 23);
            txbConfirmeASenha.TabIndex = 5;
            // 
            // btnCriarLogin
            // 
            btnCriarLogin.Location = new Point(27, 198);
            btnCriarLogin.Name = "btnCriarLogin";
            btnCriarLogin.Size = new Size(101, 23);
            btnCriarLogin.TabIndex = 6;
            btnCriarLogin.Text = "Criar Login";
            btnCriarLogin.UseVisualStyleBackColor = true;
            btnCriarLogin.Click += btnCriarLogin_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(27, 227);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(101, 23);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(163, 281);
            Controls.Add(btnVoltar);
            Controls.Add(btnCriarLogin);
            Controls.Add(txbConfirmeASenha);
            Controls.Add(txbSenha);
            Controls.Add(txbUsuario);
            Controls.Add(lblConfirmeASenha);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblSenha;
        private Label lblConfirmeASenha;
        private TextBox txbUsuario;
        private TextBox txbSenha;
        private TextBox txbConfirmeASenha;
        private Button btnCriarLogin;
        private Button btnVoltar;
    }
}