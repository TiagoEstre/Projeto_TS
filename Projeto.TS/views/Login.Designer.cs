namespace Projeto.TS.views
{
    partial class Login
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
            this.labelLogIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRegistoWarning = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelLogInPalavraPasse = new System.Windows.Forms.Label();
            this.labelLogInUtilizador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLogIn
            // 
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogIn.ForeColor = System.Drawing.Color.White;
            this.labelLogIn.Location = new System.Drawing.Point(515, 44);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(130, 46);
            this.labelLogIn.TabIndex = 0;
            this.labelLogIn.Text = "Log In";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(372, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Se ainda não tem conta precisa de criá-la para isso basta clickar aqui";
            // 
            // labelRegistoWarning
            // 
            this.labelRegistoWarning.AutoSize = true;
            this.labelRegistoWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistoWarning.ForeColor = System.Drawing.Color.White;
            this.labelRegistoWarning.Location = new System.Drawing.Point(276, 396);
            this.labelRegistoWarning.Name = "labelRegistoWarning";
            this.labelRegistoWarning.Size = new System.Drawing.Size(231, 29);
            this.labelRegistoWarning.TabIndex = 31;
            this.labelRegistoWarning.Text = "Mensagem ALERTA";
            this.labelRegistoWarning.Visible = false;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn.ForeColor = System.Drawing.Color.White;
            this.buttonLogIn.Location = new System.Drawing.Point(922, 293);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(111, 39);
            this.buttonLogIn.TabIndex = 30;
            this.buttonLogIn.Text = "LogIn";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(473, 236);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(560, 34);
            this.textBox5.TabIndex = 28;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(473, 178);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(560, 34);
            this.textBox4.TabIndex = 27;
            // 
            // labelLogInPalavraPasse
            // 
            this.labelLogInPalavraPasse.AutoSize = true;
            this.labelLogInPalavraPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogInPalavraPasse.ForeColor = System.Drawing.Color.White;
            this.labelLogInPalavraPasse.Location = new System.Drawing.Point(276, 239);
            this.labelLogInPalavraPasse.Name = "labelLogInPalavraPasse";
            this.labelLogInPalavraPasse.Size = new System.Drawing.Size(180, 29);
            this.labelLogInPalavraPasse.TabIndex = 23;
            this.labelLogInPalavraPasse.Text = "Palavra-Passe: ";
            // 
            // labelLogInUtilizador
            // 
            this.labelLogInUtilizador.AutoSize = true;
            this.labelLogInUtilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogInUtilizador.ForeColor = System.Drawing.Color.White;
            this.labelLogInUtilizador.Location = new System.Drawing.Point(234, 180);
            this.labelLogInUtilizador.Name = "labelLogInUtilizador";
            this.labelLogInUtilizador.Size = new System.Drawing.Size(222, 29);
            this.labelLogInUtilizador.TabIndex = 22;
            this.labelLogInUtilizador.Text = "Nome de utilizador:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1215, 663);
            this.ControlBox = false;
            this.Controls.Add(this.labelRegistoWarning);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelLogInPalavraPasse);
            this.Controls.Add(this.labelLogInUtilizador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLogIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRegistoWarning;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelLogInPalavraPasse;
        private System.Windows.Forms.Label labelLogInUtilizador;
    }
}