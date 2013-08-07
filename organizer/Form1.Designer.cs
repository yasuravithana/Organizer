namespace organizer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.often = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.when = new System.Windows.Forms.ComboBox();
            this.before = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.days = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Minimize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(23, 64);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(238, 36);
            this.description.TabIndex = 1;
            // 
            // often
            // 
            this.often.FormattingEnabled = true;
            this.often.Items.AddRange(new object[] {
            "Once a month"});
            this.often.Location = new System.Drawing.Point(23, 119);
            this.often.Name = "often";
            this.often.Size = new System.Drawing.Size(121, 21);
            this.often.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "How Often";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(186, 212);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(23, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(238, 20);
            this.title.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Title";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "When";
            // 
            // when
            // 
            this.when.FormattingEnabled = true;
            this.when.Location = new System.Drawing.Point(23, 162);
            this.when.Name = "when";
            this.when.Size = new System.Drawing.Size(87, 21);
            this.when.TabIndex = 2;
            // 
            // before
            // 
            this.before.FormattingEnabled = true;
            this.before.Location = new System.Drawing.Point(125, 188);
            this.before.Name = "before";
            this.before.Size = new System.Drawing.Size(87, 21);
            this.before.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Days Before";
            // 
            // days
            // 
            this.days.Location = new System.Drawing.Point(23, 189);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(25, 20);
            this.days.TabIndex = 1;
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.SystemColors.Control;
            this.next.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(10, 215);
            this.next.Multiline = true;
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(166, 44);
            this.next.TabIndex = 5;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // Minimize
            // 
            this.Minimize.Location = new System.Drawing.Point(186, 237);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(75, 23);
            this.Minimize.TabIndex = 4;
            this.Minimize.Text = "Minimize";
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.next);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.before);
            this.Controls.Add(this.when);
            this.Controls.Add(this.often);
            this.Controls.Add(this.days);
            this.Controls.Add(this.title);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox description;
        public System.Windows.Forms.ComboBox often;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.TextBox title;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox when;
        public System.Windows.Forms.ComboBox before;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox days;
        private System.Windows.Forms.TextBox next;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.Button Minimize;

    }
}

