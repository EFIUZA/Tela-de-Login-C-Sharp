namespace Tela_de_Login_com_SQL_Server.Telas
{
    partial class TelaPrincipal
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
            lblLoginRealizado = new Label();
            SuspendLayout();
            // 
            // lblLoginRealizado
            // 
            lblLoginRealizado.AutoSize = true;
            lblLoginRealizado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginRealizado.Location = new Point(355, 181);
            lblLoginRealizado.Name = "lblLoginRealizado";
            lblLoginRealizado.Size = new Size(116, 21);
            lblLoginRealizado.TabIndex = 0;
            lblLoginRealizado.Text = "Login realizado";
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLoginRealizado);
            Name = "TelaPrincipal";
            Text = "TelaPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoginRealizado;
    }
}