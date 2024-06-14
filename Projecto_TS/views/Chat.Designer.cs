namespace Projecto_TS.views
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.PanelStatusClient = new Guna.UI2.WinForms.Guna2Panel();
            this.PictureBoxArrowBack = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.CircleProgressBarStatus2 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.CircleProgressBarStatus = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.PictureBoxPhoto = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PanelInfChat = new Guna.UI2.WinForms.Guna2Panel();
            this.textBoxNameClient = new System.Windows.Forms.TextBox();
            this.PictureBoxClient = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.PictureBoxSend = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.textBoxMessageChat = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.listBoxChat = new System.Windows.Forms.ListBox();
            this.PanelStatusClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArrowBack)).BeginInit();
            this.CircleProgressBarStatus2.SuspendLayout();
            this.CircleProgressBarStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhoto)).BeginInit();
            this.PanelInfChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClient)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSend)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelStatusClient
            // 
            this.PanelStatusClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.PanelStatusClient.Controls.Add(this.PictureBoxArrowBack);
            this.PanelStatusClient.Controls.Add(this.textBoxUsername);
            this.PanelStatusClient.Controls.Add(this.CircleProgressBarStatus2);
            this.PanelStatusClient.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelStatusClient.Location = new System.Drawing.Point(609, 0);
            this.PanelStatusClient.Name = "PanelStatusClient";
            this.PanelStatusClient.Size = new System.Drawing.Size(292, 745);
            this.PanelStatusClient.TabIndex = 3;
            this.PanelStatusClient.Visible = false;
            // 
            // PictureBoxArrowBack
            // 
            this.PictureBoxArrowBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxArrowBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxArrowBack.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxArrowBack.Image")));
            this.PictureBoxArrowBack.ImageRotate = 0F;
            this.PictureBoxArrowBack.Location = new System.Drawing.Point(6, 4);
            this.PictureBoxArrowBack.Name = "PictureBoxArrowBack";
            this.PictureBoxArrowBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBoxArrowBack.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxArrowBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxArrowBack.TabIndex = 4;
            this.PictureBoxArrowBack.TabStop = false;
            this.PictureBoxArrowBack.Click += new System.EventHandler(this.PictureBoxArrowBack_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxUsername.Location = new System.Drawing.Point(0, 217);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(291, 23);
            this.textBoxUsername.TabIndex = 37;
            this.textBoxUsername.Text = "Nome";
            this.textBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CircleProgressBarStatus2
            // 
            this.CircleProgressBarStatus2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CircleProgressBarStatus2.Controls.Add(this.CircleProgressBarStatus);
            this.CircleProgressBarStatus2.FillColor = System.Drawing.Color.Transparent;
            this.CircleProgressBarStatus2.FillThickness = 3;
            this.CircleProgressBarStatus2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CircleProgressBarStatus2.ForeColor = System.Drawing.Color.White;
            this.CircleProgressBarStatus2.Location = new System.Drawing.Point(65, 37);
            this.CircleProgressBarStatus2.Minimum = 0;
            this.CircleProgressBarStatus2.Name = "CircleProgressBarStatus2";
            this.CircleProgressBarStatus2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.CircleProgressBarStatus2.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.CircleProgressBarStatus2.ProgressThickness = 3;
            this.CircleProgressBarStatus2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CircleProgressBarStatus2.Size = new System.Drawing.Size(160, 160);
            this.CircleProgressBarStatus2.TabIndex = 36;
            this.CircleProgressBarStatus2.Text = "guna2CircleProgressBar1";
            this.CircleProgressBarStatus2.Value = 40;
            // 
            // CircleProgressBarStatus
            // 
            this.CircleProgressBarStatus.BackColor = System.Drawing.Color.Transparent;
            this.CircleProgressBarStatus.Controls.Add(this.PictureBoxPhoto);
            this.CircleProgressBarStatus.FillColor = System.Drawing.Color.Transparent;
            this.CircleProgressBarStatus.FillThickness = 3;
            this.CircleProgressBarStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CircleProgressBarStatus.ForeColor = System.Drawing.Color.Transparent;
            this.CircleProgressBarStatus.Location = new System.Drawing.Point(5, 5);
            this.CircleProgressBarStatus.Minimum = 0;
            this.CircleProgressBarStatus.Name = "CircleProgressBarStatus";
            this.CircleProgressBarStatus.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.CircleProgressBarStatus.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.CircleProgressBarStatus.ProgressThickness = 3;
            this.CircleProgressBarStatus.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CircleProgressBarStatus.Size = new System.Drawing.Size(150, 150);
            this.CircleProgressBarStatus.TabIndex = 34;
            this.CircleProgressBarStatus.Text = "guna2CircleProgressBar1";
            this.CircleProgressBarStatus.Value = 33;
            // 
            // PictureBoxPhoto
            // 
            this.PictureBoxPhoto.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxPhoto.BorderRadius = 75;
            this.PictureBoxPhoto.FillColor = System.Drawing.Color.Transparent;
            this.PictureBoxPhoto.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxPhoto.Image")));
            this.PictureBoxPhoto.ImageRotate = 0F;
            this.PictureBoxPhoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxPhoto.InitialImage")));
            this.PictureBoxPhoto.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxPhoto.Name = "PictureBoxPhoto";
            this.PictureBoxPhoto.Size = new System.Drawing.Size(150, 150);
            this.PictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxPhoto.TabIndex = 0;
            this.PictureBoxPhoto.TabStop = false;
            // 
            // PanelInfChat
            // 
            this.PanelInfChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.PanelInfChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelInfChat.Controls.Add(this.textBoxNameClient);
            this.PanelInfChat.Controls.Add(this.PictureBoxClient);
            this.PanelInfChat.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelInfChat.Location = new System.Drawing.Point(0, 0);
            this.PanelInfChat.Name = "PanelInfChat";
            this.PanelInfChat.Size = new System.Drawing.Size(609, 47);
            this.PanelInfChat.TabIndex = 5;
            // 
            // textBoxNameClient
            // 
            this.textBoxNameClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.textBoxNameClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNameClient.Location = new System.Drawing.Point(257, 15);
            this.textBoxNameClient.Name = "textBoxNameClient";
            this.textBoxNameClient.Size = new System.Drawing.Size(291, 19);
            this.textBoxNameClient.TabIndex = 38;
            this.textBoxNameClient.Text = "NOME CLIENTE";
            this.textBoxNameClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxNameClient.Click += new System.EventHandler(this.textBoxNameClient_Click);
            this.textBoxNameClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameClient_KeyPress);
            this.textBoxNameClient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxNameClient_MouseDown);
            this.textBoxNameClient.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxNameClient_MouseMove);
            this.textBoxNameClient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBoxNameClient_MouseUp);
            // 
            // PictureBoxClient
            // 
            this.PictureBoxClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxClient.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxClient.Image")));
            this.PictureBoxClient.ImageRotate = 0F;
            this.PictureBoxClient.Location = new System.Drawing.Point(558, 4);
            this.PictureBoxClient.Name = "PictureBoxClient";
            this.PictureBoxClient.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBoxClient.Size = new System.Drawing.Size(40, 40);
            this.PictureBoxClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxClient.TabIndex = 2;
            this.PictureBoxClient.TabStop = false;
            this.PictureBoxClient.Click += new System.EventHandler(this.PictureBoxClient_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.guna2Panel2.Controls.Add(this.PictureBoxSend);
            this.guna2Panel2.Controls.Add(this.textBoxMessageChat);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 690);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(609, 55);
            this.guna2Panel2.TabIndex = 7;
            // 
            // PictureBoxSend
            // 
            this.PictureBoxSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxSend.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxSend.Image")));
            this.PictureBoxSend.ImageRotate = 0F;
            this.PictureBoxSend.Location = new System.Drawing.Point(555, 11);
            this.PictureBoxSend.Name = "PictureBoxSend";
            this.PictureBoxSend.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBoxSend.Size = new System.Drawing.Size(35, 35);
            this.PictureBoxSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxSend.TabIndex = 44;
            this.PictureBoxSend.TabStop = false;
            this.PictureBoxSend.Click += new System.EventHandler(this.PictureBoxSend_Click);
            // 
            // textBoxMessageChat
            // 
            this.textBoxMessageChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMessageChat.AutoRoundedCorners = true;
            this.textBoxMessageChat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.textBoxMessageChat.BorderRadius = 14;
            this.textBoxMessageChat.BorderThickness = 2;
            this.textBoxMessageChat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMessageChat.DefaultText = "Escreva sua mensagem";
            this.textBoxMessageChat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxMessageChat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxMessageChat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMessageChat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMessageChat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.textBoxMessageChat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMessageChat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxMessageChat.ForeColor = System.Drawing.Color.White;
            this.textBoxMessageChat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMessageChat.Location = new System.Drawing.Point(20, 13);
            this.textBoxMessageChat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMessageChat.Name = "textBoxMessageChat";
            this.textBoxMessageChat.PasswordChar = '\0';
            this.textBoxMessageChat.PlaceholderText = "";
            this.textBoxMessageChat.SelectedText = "";
            this.textBoxMessageChat.Size = new System.Drawing.Size(527, 31);
            this.textBoxMessageChat.TabIndex = 43;
            this.textBoxMessageChat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMessageChat.Enter += new System.EventHandler(this.textBoxMessageChat_Enter);
            this.textBoxMessageChat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMessageChat_KeyDown);
            this.textBoxMessageChat.Leave += new System.EventHandler(this.textBoxMessageChat_Leave);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.guna2Panel1.Controls.Add(this.listBoxChat);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 47);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(609, 643);
            this.guna2Panel1.TabIndex = 8;
            // 
            // listBoxChat
            // 
            this.listBoxChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxChat.FormattingEnabled = true;
            this.listBoxChat.ItemHeight = 29;
            this.listBoxChat.Location = new System.Drawing.Point(11, 17);
            this.listBoxChat.Name = "listBoxChat";
            this.listBoxChat.Size = new System.Drawing.Size(586, 613);
            this.listBoxChat.TabIndex = 40;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 745);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.PanelInfChat);
            this.Controls.Add(this.PanelStatusClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chat";
            this.Text = "Chat";
            this.PanelStatusClient.ResumeLayout(false);
            this.PanelStatusClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArrowBack)).EndInit();
            this.CircleProgressBarStatus2.ResumeLayout(false);
            this.CircleProgressBarStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhoto)).EndInit();
            this.PanelInfChat.ResumeLayout(false);
            this.PanelInfChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClient)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSend)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel PanelStatusClient;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureBoxArrowBack;
        private System.Windows.Forms.TextBox textBoxUsername;
        private Guna.UI2.WinForms.Guna2CircleProgressBar CircleProgressBarStatus2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar CircleProgressBarStatus;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxPhoto;
        private Guna.UI2.WinForms.Guna2Panel PanelInfChat;
        private System.Windows.Forms.TextBox textBoxNameClient;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureBoxClient;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureBoxSend;
        private Guna.UI2.WinForms.Guna2TextBox textBoxMessageChat;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.ListBox listBoxChat;
    }
}