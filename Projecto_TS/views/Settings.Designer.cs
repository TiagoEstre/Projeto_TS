namespace Projecto_TS.views
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonOn = new System.Windows.Forms.RadioButton();
            this.ButtonOff = new System.Windows.Forms.RadioButton();
            this.ButtonOccupied = new System.Windows.Forms.RadioButton();
            this.labelEstados = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.CircleProgressBarStatus = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.CircleProgressBarStatus2 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.pictureBoxPhoto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonLogout = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonNightMode = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.labelChangeAdress = new System.Windows.Forms.Label();
            this.labelChangePhone = new System.Windows.Forms.Label();
            this.labelChangePassword = new System.Windows.Forms.Label();
            this.labelChangeName = new System.Windows.Forms.Label();
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.guna2Panel1.SuspendLayout();
            this.CircleProgressBarStatus.SuspendLayout();
            this.CircleProgressBarStatus2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(453, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(390, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Palavra-passe: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(421, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Telemovel: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(441, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Morada: ";
            // 
            // ButtonOn
            // 
            this.ButtonOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOn.AutoSize = true;
            this.ButtonOn.ForeColor = System.Drawing.Color.Lime;
            this.ButtonOn.Location = new System.Drawing.Point(610, 82);
            this.ButtonOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonOn.Name = "ButtonOn";
            this.ButtonOn.Size = new System.Drawing.Size(66, 20);
            this.ButtonOn.TabIndex = 21;
            this.ButtonOn.TabStop = true;
            this.ButtonOn.Text = "Online";
            this.ButtonOn.UseVisualStyleBackColor = true;
            this.ButtonOn.CheckedChanged += new System.EventHandler(this.ButtonOn_CheckedChanged);
            // 
            // ButtonOff
            // 
            this.ButtonOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOff.AutoSize = true;
            this.ButtonOff.ForeColor = System.Drawing.Color.Red;
            this.ButtonOff.Location = new System.Drawing.Point(948, 82);
            this.ButtonOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonOff.Name = "ButtonOff";
            this.ButtonOff.Size = new System.Drawing.Size(65, 20);
            this.ButtonOff.TabIndex = 22;
            this.ButtonOff.TabStop = true;
            this.ButtonOff.Text = "Offline";
            this.ButtonOff.UseVisualStyleBackColor = true;
            this.ButtonOff.CheckedChanged += new System.EventHandler(this.ButtonOff_CheckedChanged);
            // 
            // ButtonOccupied
            // 
            this.ButtonOccupied.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOccupied.AutoSize = true;
            this.ButtonOccupied.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonOccupied.Location = new System.Drawing.Point(770, 82);
            this.ButtonOccupied.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonOccupied.Name = "ButtonOccupied";
            this.ButtonOccupied.Size = new System.Drawing.Size(84, 20);
            this.ButtonOccupied.TabIndex = 23;
            this.ButtonOccupied.TabStop = true;
            this.ButtonOccupied.Text = "Ocupado";
            this.ButtonOccupied.UseVisualStyleBackColor = true;
            this.ButtonOccupied.CheckedChanged += new System.EventHandler(this.ButtonOccupied_CheckedChanged);
            // 
            // labelEstados
            // 
            this.labelEstados.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEstados.AutoSize = true;
            this.labelEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstados.ForeColor = System.Drawing.Color.White;
            this.labelEstados.Location = new System.Drawing.Point(445, 82);
            this.labelEstados.Name = "labelEstados";
            this.labelEstados.Size = new System.Drawing.Size(71, 20);
            this.labelEstados.TabIndex = 24;
            this.labelEstados.Text = "Estado: ";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.guna2Panel1.Controls.Add(this.CircleProgressBarStatus);
            this.guna2Panel1.Controls.Add(this.textBoxUsername);
            this.guna2Panel1.Controls.Add(this.buttonLogout);
            this.guna2Panel1.Controls.Add(this.ButtonNightMode);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(294, 745);
            this.guna2Panel1.TabIndex = 25;
            // 
            // CircleProgressBarStatus
            // 
            this.CircleProgressBarStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CircleProgressBarStatus.Controls.Add(this.CircleProgressBarStatus2);
            this.CircleProgressBarStatus.FillColor = System.Drawing.Color.Transparent;
            this.CircleProgressBarStatus.FillThickness = 3;
            this.CircleProgressBarStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CircleProgressBarStatus.ForeColor = System.Drawing.Color.White;
            this.CircleProgressBarStatus.Location = new System.Drawing.Point(68, 28);
            this.CircleProgressBarStatus.Minimum = 0;
            this.CircleProgressBarStatus.Name = "CircleProgressBarStatus";
            this.CircleProgressBarStatus.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.CircleProgressBarStatus.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.CircleProgressBarStatus.ProgressThickness = 3;
            this.CircleProgressBarStatus.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CircleProgressBarStatus.Size = new System.Drawing.Size(160, 160);
            this.CircleProgressBarStatus.TabIndex = 37;
            this.CircleProgressBarStatus.Text = "guna2CircleProgressBar1";
            this.CircleProgressBarStatus.Value = 40;
            // 
            // CircleProgressBarStatus2
            // 
            this.CircleProgressBarStatus2.BackColor = System.Drawing.Color.Transparent;
            this.CircleProgressBarStatus2.Controls.Add(this.pictureBoxPhoto);
            this.CircleProgressBarStatus2.FillColor = System.Drawing.Color.Transparent;
            this.CircleProgressBarStatus2.FillThickness = 3;
            this.CircleProgressBarStatus2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CircleProgressBarStatus2.ForeColor = System.Drawing.Color.Transparent;
            this.CircleProgressBarStatus2.Location = new System.Drawing.Point(5, 5);
            this.CircleProgressBarStatus2.Minimum = 0;
            this.CircleProgressBarStatus2.Name = "CircleProgressBarStatus2";
            this.CircleProgressBarStatus2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.CircleProgressBarStatus2.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.CircleProgressBarStatus2.ProgressThickness = 3;
            this.CircleProgressBarStatus2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CircleProgressBarStatus2.Size = new System.Drawing.Size(150, 150);
            this.CircleProgressBarStatus2.TabIndex = 34;
            this.CircleProgressBarStatus2.Text = "guna2CircleProgressBar1";
            this.CircleProgressBarStatus2.Value = 33;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhoto.Image")));
            this.pictureBoxPhoto.ImageRotate = 0F;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(18, 14);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxPhoto.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 38;
            this.pictureBoxPhoto.TabStop = false;
            this.pictureBoxPhoto.Click += new System.EventHandler(this.PictureBoxPhoto_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxUsername.Location = new System.Drawing.Point(3, 199);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(291, 23);
            this.textBoxUsername.TabIndex = 35;
            this.textBoxUsername.Text = "Nome";
            this.textBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUsername.Click += new System.EventHandler(this.textBoxUsername_Click);
            this.textBoxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsername_KeyPress);
            this.textBoxUsername.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxUsername_MouseDown);
            this.textBoxUsername.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxUsername_MouseMove);
            this.textBoxUsername.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBoxUsername_MouseUp);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(0, 665);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(294, 45);
            this.buttonLogout.TabIndex = 28;
            this.buttonLogout.Text = "LOG OUT";
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // ButtonNightMode
            // 
            this.ButtonNightMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNightMode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonNightMode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonNightMode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonNightMode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonNightMode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.ButtonNightMode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonNightMode.ForeColor = System.Drawing.Color.White;
            this.ButtonNightMode.Location = new System.Drawing.Point(0, 396);
            this.ButtonNightMode.Name = "ButtonNightMode";
            this.ButtonNightMode.Size = new System.Drawing.Size(294, 45);
            this.ButtonNightMode.TabIndex = 27;
            this.ButtonNightMode.Text = "NIGHT MODE : ON";
            this.ButtonNightMode.Click += new System.EventHandler(this.ButtonNightMode_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(0, 317);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(294, 45);
            this.guna2Button1.TabIndex = 26;
            this.guna2Button1.Text = "GERAL";
            // 
            // labelChangeAdress
            // 
            this.labelChangeAdress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelChangeAdress.AutoSize = true;
            this.labelChangeAdress.ForeColor = System.Drawing.Color.Silver;
            this.labelChangeAdress.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelChangeAdress.Location = new System.Drawing.Point(1040, 422);
            this.labelChangeAdress.Name = "labelChangeAdress";
            this.labelChangeAdress.Size = new System.Drawing.Size(46, 16);
            this.labelChangeAdress.TabIndex = 33;
            this.labelChangeAdress.Text = "Alterar";
            this.labelChangeAdress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelChangeAdress.UseMnemonic = false;
            this.labelChangeAdress.Click += new System.EventHandler(this.labelChangeAddress_Click);
            // 
            // labelChangePhone
            // 
            this.labelChangePhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelChangePhone.AutoSize = true;
            this.labelChangePhone.ForeColor = System.Drawing.Color.Silver;
            this.labelChangePhone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelChangePhone.Location = new System.Drawing.Point(1040, 346);
            this.labelChangePhone.Name = "labelChangePhone";
            this.labelChangePhone.Size = new System.Drawing.Size(46, 16);
            this.labelChangePhone.TabIndex = 32;
            this.labelChangePhone.Text = "Alterar";
            this.labelChangePhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelChangePhone.UseMnemonic = false;
            this.labelChangePhone.Click += new System.EventHandler(this.labelChangePhone_Click);
            // 
            // labelChangePassword
            // 
            this.labelChangePassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelChangePassword.AutoSize = true;
            this.labelChangePassword.ForeColor = System.Drawing.Color.Silver;
            this.labelChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelChangePassword.Location = new System.Drawing.Point(1040, 266);
            this.labelChangePassword.Name = "labelChangePassword";
            this.labelChangePassword.Size = new System.Drawing.Size(46, 16);
            this.labelChangePassword.TabIndex = 31;
            this.labelChangePassword.Text = "Alterar";
            this.labelChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelChangePassword.UseMnemonic = false;
            this.labelChangePassword.Click += new System.EventHandler(this.labelChangePassword_Click);
            // 
            // labelChangeName
            // 
            this.labelChangeName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelChangeName.AutoSize = true;
            this.labelChangeName.ForeColor = System.Drawing.Color.Silver;
            this.labelChangeName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelChangeName.Location = new System.Drawing.Point(1040, 184);
            this.labelChangeName.Name = "labelChangeName";
            this.labelChangeName.Size = new System.Drawing.Size(46, 16);
            this.labelChangeName.TabIndex = 30;
            this.labelChangeName.Text = "Alterar";
            this.labelChangeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelChangeName.UseMnemonic = false;
            this.labelChangeName.Click += new System.EventHandler(this.labelChangeName_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.AutoRoundedCorners = true;
            this.textBoxName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.textBoxName.BorderRadius = 14;
            this.textBoxName.BorderThickness = 2;
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.DefaultText = "Nome";
            this.textBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.textBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxName.ForeColor = System.Drawing.Color.White;
            this.textBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.Location = new System.Drawing.Point(558, 177);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PlaceholderText = "";
            this.textBoxName.SelectedText = "";
            this.textBoxName.Size = new System.Drawing.Size(455, 31);
            this.textBoxName.TabIndex = 34;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.TextBoxName_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.AutoRoundedCorners = true;
            this.textBoxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.textBoxPassword.BorderRadius = 14;
            this.textBoxPassword.BorderThickness = 2;
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.DefaultText = "Nome";
            this.textBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.textBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.Location = new System.Drawing.Point(558, 259);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.PlaceholderText = "";
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.Size = new System.Drawing.Size(455, 31);
            this.textBoxPassword.TabIndex = 35;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.Enter += new System.EventHandler(this.TextBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.TextBoxPassword_Leave);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhone.AutoRoundedCorners = true;
            this.textBoxPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.textBoxPhone.BorderRadius = 14;
            this.textBoxPhone.BorderThickness = 2;
            this.textBoxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPhone.DefaultText = "Telemovel";
            this.textBoxPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPhone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.textBoxPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxPhone.ForeColor = System.Drawing.Color.White;
            this.textBoxPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPhone.Location = new System.Drawing.Point(558, 339);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.PasswordChar = '\0';
            this.textBoxPhone.PlaceholderText = "";
            this.textBoxPhone.SelectedText = "";
            this.textBoxPhone.Size = new System.Drawing.Size(455, 31);
            this.textBoxPhone.TabIndex = 35;
            this.textBoxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPhone.Enter += new System.EventHandler(this.TextBoxPhone_Enter);
            this.textBoxPhone.Leave += new System.EventHandler(this.TextBoxPhone_Leave);
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAddress.AutoRoundedCorners = true;
            this.TextBoxAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.TextBoxAddress.BorderRadius = 14;
            this.TextBoxAddress.BorderThickness = 2;
            this.TextBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAddress.DefaultText = "Morada";
            this.TextBoxAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxAddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.TextBoxAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxAddress.ForeColor = System.Drawing.Color.White;
            this.TextBoxAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxAddress.Location = new System.Drawing.Point(558, 415);
            this.TextBoxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.PasswordChar = '\0';
            this.TextBoxAddress.PlaceholderText = "";
            this.TextBoxAddress.SelectedText = "";
            this.TextBoxAddress.Size = new System.Drawing.Size(455, 31);
            this.TextBoxAddress.TabIndex = 35;
            this.TextBoxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBoxAddress.Enter += new System.EventHandler(this.TextBoxAddress_Enter);
            this.TextBoxAddress.Leave += new System.EventHandler(this.TextBoxAddress_Leave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|(*.pgn)|*.png";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1195, 745);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelChangeAdress);
            this.Controls.Add(this.labelChangePhone);
            this.Controls.Add(this.labelChangePassword);
            this.Controls.Add(this.labelChangeName);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.labelEstados);
            this.Controls.Add(this.ButtonOccupied);
            this.Controls.Add(this.ButtonOff);
            this.Controls.Add(this.ButtonOn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Definitions";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.CircleProgressBarStatus.ResumeLayout(false);
            this.CircleProgressBarStatus2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton ButtonOn;
        private System.Windows.Forms.RadioButton ButtonOff;
        private System.Windows.Forms.RadioButton ButtonOccupied;
        private System.Windows.Forms.Label labelEstados;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button buttonLogout;
        private Guna.UI2.WinForms.Guna2Button ButtonNightMode;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label labelChangeAdress;
        private System.Windows.Forms.Label labelChangePhone;
        private System.Windows.Forms.Label labelChangePassword;
        private System.Windows.Forms.Label labelChangeName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPassword;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPhone;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxAddress;
        private System.Windows.Forms.TextBox textBoxUsername;
        private Guna.UI2.WinForms.Guna2CircleProgressBar CircleProgressBarStatus;
        private Guna.UI2.WinForms.Guna2CircleProgressBar CircleProgressBarStatus2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}