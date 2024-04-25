namespace SistemaLogin
{
    partial class Form1
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
            label_BoasVindas = new Label();
            SuspendLayout();
            // 
            // label_BoasVindas
            // 
            label_BoasVindas.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label_BoasVindas.Location = new Point(58, 125);
            label_BoasVindas.Name = "label_BoasVindas";
            label_BoasVindas.Size = new Size(684, 158);
            label_BoasVindas.TabIndex = 0;
            label_BoasVindas.Text = "Tela Inicial";
            label_BoasVindas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_BoasVindas);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label_BoasVindas;
    }
}
