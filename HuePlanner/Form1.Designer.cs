namespace HuePlanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbSubmit = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMin = new System.Windows.Forms.PictureBox();
            this.lvlEmail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.dragPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMin)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsername.Location = new System.Drawing.Point(33, 189);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(297, 39);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsername_OnEnter);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(33, 261);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(297, 39);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsername_OnEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HuePlanner.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(104, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pbSubmit
            // 
            this.pbSubmit.BackColor = System.Drawing.Color.Transparent;
            this.pbSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSubmit.Image = global::HuePlanner.Properties.Resources.submit;
            this.pbSubmit.Location = new System.Drawing.Point(104, 361);
            this.pbSubmit.Name = "pbSubmit";
            this.pbSubmit.Size = new System.Drawing.Size(167, 58);
            this.pbSubmit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSubmit.TabIndex = 4;
            this.pbSubmit.TabStop = false;
            this.pbSubmit.Click += new System.EventHandler(this.pbSubmit_Click);
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.BackgroundImage = global::HuePlanner.Properties.Resources.Close;
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Location = new System.Drawing.Point(317, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(46, 25);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 5;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbMin
            // 
            this.pbMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMin.Image = global::HuePlanner.Properties.Resources.minimize;
            this.pbMin.Location = new System.Drawing.Point(273, 0);
            this.pbMin.Name = "pbMin";
            this.pbMin.Size = new System.Drawing.Size(45, 25);
            this.pbMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMin.TabIndex = 7;
            this.pbMin.TabStop = false;
            this.pbMin.Click += new System.EventHandler(this.pbMin_Click);
            // 
            // lvlEmail
            // 
            this.lvlEmail.AutoSize = true;
            this.lvlEmail.BackColor = System.Drawing.Color.Transparent;
            this.lvlEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvlEmail.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lvlEmail.Location = new System.Drawing.Point(33, 167);
            this.lvlEmail.Name = "lvlEmail";
            this.lvlEmail.Size = new System.Drawing.Size(48, 19);
            this.lvlEmail.TabIndex = 8;
            this.lvlEmail.Text = "Email";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPass.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPass.Location = new System.Drawing.Point(33, 239);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(76, 19);
            this.lblPass.TabIndex = 9;
            this.lblPass.Text = "Password";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegister.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegister.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblRegister.Location = new System.Drawing.Point(72, 303);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(234, 19);
            this.lblRegister.TabIndex = 10;
            this.lblRegister.Text = "No account yet? Register here..!";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            this.lblRegister.MouseLeave += new System.EventHandler(this.lblRegister_MouseLeave);
            this.lblRegister.MouseHover += new System.EventHandler(this.lblRegister_MouseHover);
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.Transparent;
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(277, 25);
            this.dragPanel.TabIndex = 11;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(363, 465);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lvlEmail);
            this.Controls.Add(this.pbMin);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.pbSubmit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnSubmit;
        private PictureBox pictureBox1;
        private PictureBox pbSubmit;
        private PictureBox pbClose;
        private PictureBox pbMin;
        private Label lvlEmail;
        private Label lblPass;
        private Label lblRegister;
        private Panel dragPanel;
    }
}