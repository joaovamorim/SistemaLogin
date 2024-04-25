namespace SistemaLogin
{
    partial class FormLogin
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
            label1 = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            btnCancelar = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(88, 30);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.Location = new Point(12, 52);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(369, 50);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtSenha.Location = new Point(12, 146);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(369, 50);
            txtSenha.TabIndex = 3;
            txtSenha.PasswordChar = '*';
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(75, 30);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(12, 219);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(169, 50);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(212, 219);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(169, 50);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 297);
            ControlBox = false;
            Controls.Add(btnLogin);
            Controls.Add(btnCancelar);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label label2;
        private Button btnCancelar;
        private Button btnLogin;
    }
}