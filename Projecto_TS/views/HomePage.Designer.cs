namespace Projecto_TS.views
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panelConsola = new System.Windows.Forms.Panel();
            this.PictureBoxFullScreen = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureBoxMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureBoxClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PanelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.PictureBoxClient = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.PictureBoxSettings = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureBoxChat = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelMessage = new Guna.UI2.WinForms.Guna2Panel();
            this.panelConsola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFullScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClose)).BeginInit();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxChat)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsola
            // 
            this.panelConsola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.panelConsola.Controls.Add(this.PictureBoxFullScreen);
            this.panelConsola.Controls.Add(this.PictureBoxMinimize);
            this.panelConsola.Controls.Add(this.PictureBoxClose);
            this.panelConsola.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConsola.Location = new System.Drawing.Point(0, 0);
            this.panelConsola.Name = "panelConsola";
            this.panelConsola.Size = new System.Drawing.Size(1259, 30);
            this.panelConsola.TabIndex = 6;
            this.panelConsola.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelConsola_MouseDown);
            // 
            // PictureBoxFullScreen
            // 
            this.PictureBoxFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxFullScreen.Image")));
            this.PictureBoxFullScreen.ImageRotate = 0F;
            this.PictureBoxFullScreen.Location = new System.Drawing.Point(1198, 6);
            this.PictureBoxFullScreen.Name = "PictureBoxFullScreen";
            this.PictureBoxFullScreen.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxFullScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxFullScreen.TabIndex = 2;
            this.PictureBoxFullScreen.TabStop = false;
            this.PictureBoxFullScreen.Click += new System.EventHandler(this.PictureBoxFullScreen_Click);
            // 
            // PictureBoxMinimize
            // 
            this.PictureBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxMinimize.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxMinimize.Image")));
            this.PictureBoxMinimize.ImageRotate = 0F;
            this.PictureBoxMinimize.Location = new System.Drawing.Point(1168, 6);
            this.PictureBoxMinimize.Name = "PictureBoxMinimize";
            this.PictureBoxMinimize.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxMinimize.TabIndex = 1;
            this.PictureBoxMinimize.TabStop = false;
            this.PictureBoxMinimize.Click += new System.EventHandler(this.PictureBoxMinimize_Click);
            // 
            // PictureBoxClose
            // 
            this.PictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxClose.Image")));
            this.PictureBoxClose.ImageRotate = 0F;
            this.PictureBoxClose.Location = new System.Drawing.Point(1228, 6);
            this.PictureBoxClose.Name = "PictureBoxClose";
            this.PictureBoxClose.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxClose.TabIndex = 0;
            this.PictureBoxClose.TabStop = false;
            this.PictureBoxClose.Click += new System.EventHandler(this.PictureBoxClose_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(50)))));
            this.PanelMenu.Controls.Add(this.PictureBoxClient);
            this.PanelMenu.Controls.Add(this.PictureBoxSettings);
            this.PanelMenu.Controls.Add(this.PictureBoxChat);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 30);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(64, 745);
            this.PanelMenu.TabIndex = 7;
            // 
            // PictureBoxClient
            // 
            this.PictureBoxClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxClient.Enabled = false;
            this.PictureBoxClient.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxClient.Image")));
            this.PictureBoxClient.ImageRotate = 0F;
            this.PictureBoxClient.Location = new System.Drawing.Point(7, 12);
            this.PictureBoxClient.Name = "PictureBoxClient";
            this.PictureBoxClient.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBoxClient.Size = new System.Drawing.Size(50, 50);
            this.PictureBoxClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxClient.TabIndex = 11;
            this.PictureBoxClient.TabStop = false;
            // 
            // PictureBoxSettings
            // 
            this.PictureBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxSettings.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxSettings.Image")));
            this.PictureBoxSettings.ImageRotate = 0F;
            this.PictureBoxSettings.Location = new System.Drawing.Point(12, 693);
            this.PictureBoxSettings.Name = "PictureBoxSettings";
            this.PictureBoxSettings.Size = new System.Drawing.Size(40, 40);
            this.PictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxSettings.TabIndex = 10;
            this.PictureBoxSettings.TabStop = false;
            this.PictureBoxSettings.Click += new System.EventHandler(this.PictureBoxSettings_Click);
            // 
            // PictureBoxChat
            // 
            this.PictureBoxChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxChat.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxChat.Image")));
            this.PictureBoxChat.ImageRotate = 0F;
            this.PictureBoxChat.Location = new System.Drawing.Point(12, 347);
            this.PictureBoxChat.Name = "PictureBoxChat";
            this.PictureBoxChat.Size = new System.Drawing.Size(40, 40);
            this.PictureBoxChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxChat.TabIndex = 9;
            this.PictureBoxChat.TabStop = false;
            this.PictureBoxChat.Click += new System.EventHandler(this.PictureBoxMessage_Click);
            // 
            // panelMessage
            // 
            this.panelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessage.Location = new System.Drawing.Point(64, 30);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(1195, 745);
            this.panelMessage.TabIndex = 8;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1259, 775);
            this.Controls.Add(this.panelMessage);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.panelConsola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.panelConsola.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFullScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClose)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxChat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelConsola;
        private Guna.UI2.WinForms.Guna2Panel PanelMenu;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxSettings;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxChat;
        private Guna.UI2.WinForms.Guna2Panel panelMessage;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxFullScreen;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxClose;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureBoxClient;
    }
}