namespace HuePlanner
{
    partial class ViewEvent
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
            this.lbHeading = new System.Windows.Forms.Label();
            this.pbxdelete = new System.Windows.Forms.PictureBox();
            this.pbxclose = new System.Windows.Forms.PictureBox();
            this.lvConsumables = new System.Windows.Forms.ListView();
            this.labal2 = new System.Windows.Forms.Label();
            this.lvTodo = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvConfirmed = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.lvInvited = new System.Windows.Forms.ListView();
            this.pbInvite = new System.Windows.Forms.PictureBox();
            this.cbInvite = new System.Windows.Forms.ComboBox();
            this.cbConfirmed = new System.Windows.Forms.ComboBox();
            this.pbConfirmed = new System.Windows.Forms.PictureBox();
            this.pbTodoSubmit = new System.Windows.Forms.PictureBox();
            this.tbTodo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxdelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInvite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTodoSubmit)).BeginInit();
            this.SuspendLayout();
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.Transparent;
            this.dragPanel.Location = new System.Drawing.Point(1, 1);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(427, 25);
            this.dragPanel.TabIndex = 8;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.BackColor = System.Drawing.Color.Transparent;
            this.lbHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHeading.ForeColor = System.Drawing.Color.White;
            this.lbHeading.Location = new System.Drawing.Point(22, 40);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(132, 32);
            this.lbHeading.TabIndex = 11;
            this.lbHeading.Text = "lbHeading";
            // 
            // pbxdelete
            // 
            this.pbxdelete.BackColor = System.Drawing.Color.Transparent;
            this.pbxdelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxdelete.Image = global::HuePlanner.Properties.Resources.Delete;
            this.pbxdelete.Location = new System.Drawing.Point(23, 388);
            this.pbxdelete.Name = "pbxdelete";
            this.pbxdelete.Size = new System.Drawing.Size(104, 41);
            this.pbxdelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxdelete.TabIndex = 12;
            this.pbxdelete.TabStop = false;
            this.pbxdelete.Click += new System.EventHandler(this.pbxdelete_Click);
            // 
            // pbxclose
            // 
            this.pbxclose.BackColor = System.Drawing.Color.Transparent;
            this.pbxclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxclose.Image = global::HuePlanner.Properties.Resources.Close1;
            this.pbxclose.Location = new System.Drawing.Point(303, 388);
            this.pbxclose.Name = "pbxclose";
            this.pbxclose.Size = new System.Drawing.Size(104, 41);
            this.pbxclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxclose.TabIndex = 14;
            this.pbxclose.TabStop = false;
            this.pbxclose.Click += new System.EventHandler(this.pbxclose_Click);
            // 
            // lvConsumables
            // 
            this.lvConsumables.Location = new System.Drawing.Point(22, 130);
            this.lvConsumables.Name = "lvConsumables";
            this.lvConsumables.Size = new System.Drawing.Size(118, 75);
            this.lvConsumables.TabIndex = 15;
            this.lvConsumables.UseCompatibleStateImageBehavior = false;
            this.lvConsumables.View = System.Windows.Forms.View.List;
            // 
            // labal2
            // 
            this.labal2.AutoSize = true;
            this.labal2.BackColor = System.Drawing.Color.Transparent;
            this.labal2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labal2.ForeColor = System.Drawing.Color.White;
            this.labal2.Location = new System.Drawing.Point(19, 110);
            this.labal2.Name = "labal2";
            this.labal2.Size = new System.Drawing.Size(97, 20);
            this.labal2.TabIndex = 16;
            this.labal2.Text = "Consumables";
            // 
            // lvTodo
            // 
            this.lvTodo.Location = new System.Drawing.Point(191, 129);
            this.lvTodo.Name = "lvTodo";
            this.lvTodo.Size = new System.Drawing.Size(216, 76);
            this.lvTodo.TabIndex = 17;
            this.lvTodo.UseCompatibleStateImageBehavior = false;
            this.lvTodo.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(191, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Todos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(239, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Confirmed";
            // 
            // lvConfirmed
            // 
            this.lvConfirmed.Location = new System.Drawing.Point(239, 273);
            this.lvConfirmed.Name = "lvConfirmed";
            this.lvConfirmed.Size = new System.Drawing.Size(168, 76);
            this.lvConfirmed.TabIndex = 21;
            this.lvConfirmed.UseCompatibleStateImageBehavior = false;
            this.lvConfirmed.View = System.Windows.Forms.View.List;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Invited";
            // 
            // lvInvited
            // 
            this.lvInvited.Location = new System.Drawing.Point(22, 274);
            this.lvInvited.Name = "lvInvited";
            this.lvInvited.Size = new System.Drawing.Size(168, 75);
            this.lvInvited.TabIndex = 19;
            this.lvInvited.UseCompatibleStateImageBehavior = false;
            this.lvInvited.View = System.Windows.Forms.View.List;
            // 
            // pbInvite
            // 
            this.pbInvite.BackColor = System.Drawing.Color.Transparent;
            this.pbInvite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInvite.Image = global::HuePlanner.Properties.Resources.submit;
            this.pbInvite.Location = new System.Drawing.Point(134, 355);
            this.pbInvite.Name = "pbInvite";
            this.pbInvite.Size = new System.Drawing.Size(56, 23);
            this.pbInvite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInvite.TabIndex = 23;
            this.pbInvite.TabStop = false;
            this.pbInvite.Click += new System.EventHandler(this.pbInvite_Click);
            // 
            // cbInvite
            // 
            this.cbInvite.FormattingEnabled = true;
            this.cbInvite.Location = new System.Drawing.Point(22, 355);
            this.cbInvite.Name = "cbInvite";
            this.cbInvite.Size = new System.Drawing.Size(105, 23);
            this.cbInvite.TabIndex = 24;
            // 
            // cbConfirmed
            // 
            this.cbConfirmed.FormattingEnabled = true;
            this.cbConfirmed.Location = new System.Drawing.Point(239, 355);
            this.cbConfirmed.Name = "cbConfirmed";
            this.cbConfirmed.Size = new System.Drawing.Size(105, 23);
            this.cbConfirmed.TabIndex = 26;
            // 
            // pbConfirmed
            // 
            this.pbConfirmed.BackColor = System.Drawing.Color.Transparent;
            this.pbConfirmed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbConfirmed.Image = global::HuePlanner.Properties.Resources.submit;
            this.pbConfirmed.Location = new System.Drawing.Point(351, 355);
            this.pbConfirmed.Name = "pbConfirmed";
            this.pbConfirmed.Size = new System.Drawing.Size(56, 23);
            this.pbConfirmed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConfirmed.TabIndex = 25;
            this.pbConfirmed.TabStop = false;
            this.pbConfirmed.Click += new System.EventHandler(this.pbConfirmed_Click);
            // 
            // pbTodoSubmit
            // 
            this.pbTodoSubmit.BackColor = System.Drawing.Color.Transparent;
            this.pbTodoSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTodoSubmit.Image = global::HuePlanner.Properties.Resources.submit;
            this.pbTodoSubmit.Location = new System.Drawing.Point(351, 211);
            this.pbTodoSubmit.Name = "pbTodoSubmit";
            this.pbTodoSubmit.Size = new System.Drawing.Size(56, 23);
            this.pbTodoSubmit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTodoSubmit.TabIndex = 27;
            this.pbTodoSubmit.TabStop = false;
            this.pbTodoSubmit.Click += new System.EventHandler(this.pbTodoSubmit_Click);
            // 
            // tbTodo
            // 
            this.tbTodo.Location = new System.Drawing.Point(191, 211);
            this.tbTodo.Name = "tbTodo";
            this.tbTodo.Size = new System.Drawing.Size(153, 23);
            this.tbTodo.TabIndex = 28;
            // 
            // ViewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HuePlanner.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.tbTodo);
            this.Controls.Add(this.pbTodoSubmit);
            this.Controls.Add(this.cbConfirmed);
            this.Controls.Add(this.pbConfirmed);
            this.Controls.Add(this.cbInvite);
            this.Controls.Add(this.pbInvite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvConfirmed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvInvited);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvTodo);
            this.Controls.Add(this.labal2);
            this.Controls.Add(this.lvConsumables);
            this.Controls.Add(this.pbxclose);
            this.Controls.Add(this.pbxdelete);
            this.Controls.Add(this.lbHeading);
            this.Controls.Add(this.dragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.ViewEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxdelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInvite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTodoSubmit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel dragPanel;
        private Label lbHeading;
        private PictureBox pbxdelete;
        private PictureBox pbxclose;
        private ListView lvConsumables;
        private Label labal2;
        private ListView lvTodo;
        private Label label2;
        private Label label3;
        private ListView lvConfirmed;
        private Label label4;
        private ListView lvInvited;
        private PictureBox pbInvite;
        private ComboBox cbInvite;
        private ComboBox cbConfirmed;
        private PictureBox pbConfirmed;
        private PictureBox pbTodoSubmit;
        private TextBox tbTodo;
    }
}