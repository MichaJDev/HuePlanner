namespace HuePlanner
{
    partial class CreateEvent
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
            this.dragPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBudget = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.conName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.packageComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvConsumables = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.startDatePick = new System.Windows.Forms.DateTimePicker();
            this.endDatePick = new System.Windows.Forms.DateTimePicker();
            this.labelStart = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.submitCons = new System.Windows.Forms.PictureBox();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.submitCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.Transparent;
            this.dragPanel.Location = new System.Drawing.Point(1, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(426, 25);
            this.dragPanel.TabIndex = 4;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::HuePlanner.Properties.Resources.submit;
            this.pictureBox1.Location = new System.Drawing.Point(321, 403);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(32, 67);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(248, 23);
            this.tbName.TabIndex = 9;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(32, 115);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(360, 70);
            this.tbDescription.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(28, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description";
            // 
            // tbBudget
            // 
            this.tbBudget.Location = new System.Drawing.Point(321, 67);
            this.tbBudget.Name = "tbBudget";
            this.tbBudget.Size = new System.Drawing.Size(71, 23);
            this.tbBudget.TabIndex = 13;
            this.tbBudget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBudget_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(317, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Budget";
            // 
            // conName
            // 
            this.conName.Location = new System.Drawing.Point(32, 270);
            this.conName.Name = "conName";
            this.conName.Size = new System.Drawing.Size(105, 23);
            this.conName.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(28, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Consumable";
            // 
            // packageComboBox
            // 
            this.packageComboBox.FormattingEnabled = true;
            this.packageComboBox.Items.AddRange(new object[] {
            "",
            "Carton",
            "Allumium",
            "Steel",
            "Plastic"});
            this.packageComboBox.Location = new System.Drawing.Point(32, 318);
            this.packageComboBox.Name = "packageComboBox";
            this.packageComboBox.Size = new System.Drawing.Size(105, 23);
            this.packageComboBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(28, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "PackageType";
            // 
            // lvConsumables
            // 
            this.lvConsumables.Location = new System.Drawing.Point(171, 270);
            this.lvConsumables.Name = "lvConsumables";
            this.lvConsumables.Size = new System.Drawing.Size(221, 71);
            this.lvConsumables.TabIndex = 19;
            this.lvConsumables.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(168, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Consumables";
            // 
            // startDatePick
            // 
            this.startDatePick.Location = new System.Drawing.Point(32, 220);
            this.startDatePick.Name = "startDatePick";
            this.startDatePick.Size = new System.Drawing.Size(151, 23);
            this.startDatePick.TabIndex = 23;
            // 
            // endDatePick
            // 
            this.endDatePick.Location = new System.Drawing.Point(241, 220);
            this.endDatePick.Name = "endDatePick";
            this.endDatePick.Size = new System.Drawing.Size(151, 23);
            this.endDatePick.TabIndex = 24;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.BackColor = System.Drawing.Color.Transparent;
            this.labelStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStart.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelStart.Location = new System.Drawing.Point(28, 198);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(86, 21);
            this.labelStart.TabIndex = 25;
            this.labelStart.Text = "Start Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(238, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "End Date";
            // 
            // submitCons
            // 
            this.submitCons.BackColor = System.Drawing.Color.Transparent;
            this.submitCons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitCons.Image = global::HuePlanner.Properties.Resources.submit;
            this.submitCons.Location = new System.Drawing.Point(32, 356);
            this.submitCons.Name = "submitCons";
            this.submitCons.Size = new System.Drawing.Size(71, 29);
            this.submitCons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.submitCons.TabIndex = 27;
            this.submitCons.TabStop = false;
            this.submitCons.Click += new System.EventHandler(this.submitCons_Click);
            // 
            // pbxClose
            // 
            this.pbxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxClose.Image = global::HuePlanner.Properties.Resources.Close1;
            this.pbxClose.Location = new System.Drawing.Point(32, 403);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(71, 29);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClose.TabIndex = 28;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            // 
            // CreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HuePlanner.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(427, 461);
            this.Controls.Add(this.pbxClose);
            this.Controls.Add(this.submitCons);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.endDatePick);
            this.Controls.Add(this.startDatePick);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lvConsumables);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.packageComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.conName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBudget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.submitCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel dragPanel;
        private PictureBox pictureBox1;
        private TextBox tbName;
        private TextBox tbDescription;
        private Label label1;
        private Label label2;
        private TextBox tbBudget;
        private Label label3;
        private TextBox conName;
        private Label label4;
        private ComboBox packageComboBox;
        private Label label5;
        private ListView lvConsumables;
        private Label label7;
        private DateTimePicker startDatePick;
        private DateTimePicker endDatePick;
        private Label labelStart;
        private Label label9;
        private PictureBox submitCons;
        private PictureBox pbxClose;
    }
}