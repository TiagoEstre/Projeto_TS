namespace Projecto_TS.views
{
    partial class Definition
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
            this.buttonTemas = new System.Windows.Forms.Button();
            this.buttonNotificacoes = new System.Windows.Forms.Button();
            this.buttonContas = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTemas
            // 
            this.buttonTemas.Location = new System.Drawing.Point(48, 174);
            this.buttonTemas.Name = "buttonTemas";
            this.buttonTemas.Size = new System.Drawing.Size(105, 45);
            this.buttonTemas.TabIndex = 0;
            this.buttonTemas.Text = "Temas";
            this.buttonTemas.UseVisualStyleBackColor = true;
            // 
            // buttonNotificacoes
            // 
            this.buttonNotificacoes.Location = new System.Drawing.Point(48, 239);
            this.buttonNotificacoes.Name = "buttonNotificacoes";
            this.buttonNotificacoes.Size = new System.Drawing.Size(105, 41);
            this.buttonNotificacoes.TabIndex = 1;
            this.buttonNotificacoes.Text = "Notificações";
            this.buttonNotificacoes.UseVisualStyleBackColor = true;
            // 
            // buttonContas
            // 
            this.buttonContas.Location = new System.Drawing.Point(48, 306);
            this.buttonContas.Name = "buttonContas";
            this.buttonContas.Size = new System.Drawing.Size(105, 38);
            this.buttonContas.TabIndex = 2;
            this.buttonContas.Text = "Contas";
            this.buttonContas.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(48, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "Voltar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(503, 315);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(219, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 343);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonVoltar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonContas);
            this.Controls.Add(this.buttonNotificacoes);
            this.Controls.Add(this.buttonTemas);
            this.Name = "buttonVoltar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Definitions";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTemas;
        private System.Windows.Forms.Button buttonNotificacoes;
        private System.Windows.Forms.Button buttonContas;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}