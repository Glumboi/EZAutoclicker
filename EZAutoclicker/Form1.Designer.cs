namespace EZAutoclicker
{
    partial class EZAutoclicker
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EZAutoclicker));
            this.button_start = new System.Windows.Forms.Button();
            this.timer_mouseclick = new System.Windows.Forms.Timer(this.components);
            this.textBox_speed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_stop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_rightclick = new System.Windows.Forms.CheckBox();
            this.linkLabel_github = new System.Windows.Forms.LinkLabel();
            this.Update = new System.Windows.Forms.Timer(this.components);
            this.linkLabel_version = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_logs = new System.Windows.Forms.Button();
            this.checkBox_middleclick = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Transparent;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(6, 75);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(112, 57);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // timer_mouseclick
            // 
            this.timer_mouseclick.Enabled = true;
            this.timer_mouseclick.Interval = 1000;
            this.timer_mouseclick.Tick += new System.EventHandler(this.timer_mouseclick_Tick);
            // 
            // textBox_speed
            // 
            this.textBox_speed.Location = new System.Drawing.Point(9, 45);
            this.textBox_speed.Multiline = true;
            this.textBox_speed.Name = "textBox_speed";
            this.textBox_speed.Size = new System.Drawing.Size(137, 19);
            this.textBox_speed.TabIndex = 1;
            this.textBox_speed.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Place the speed 1000 = 1 sec";
            // 
            // button_stop
            // 
            this.button_stop.BackColor = System.Drawing.Color.Transparent;
            this.button_stop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stop.Location = new System.Drawing.Point(6, 16);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(112, 54);
            this.button_stop.TabIndex = 3;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Press shift + strg + F10 to start or press start";
            // 
            // checkBox_rightclick
            // 
            this.checkBox_rightclick.AutoSize = true;
            this.checkBox_rightclick.Location = new System.Drawing.Point(9, 97);
            this.checkBox_rightclick.Name = "checkBox_rightclick";
            this.checkBox_rightclick.Size = new System.Drawing.Size(104, 17);
            this.checkBox_rightclick.TabIndex = 5;
            this.checkBox_rightclick.Text = "Enable rightclick";
            this.checkBox_rightclick.UseVisualStyleBackColor = true;
            this.checkBox_rightclick.CheckedChanged += new System.EventHandler(this.checkBox_rightclick_CheckedChanged);
            // 
            // linkLabel_github
            // 
            this.linkLabel_github.AutoSize = true;
            this.linkLabel_github.Location = new System.Drawing.Point(166, 114);
            this.linkLabel_github.Name = "linkLabel_github";
            this.linkLabel_github.Size = new System.Drawing.Size(55, 13);
            this.linkLabel_github.TabIndex = 6;
            this.linkLabel_github.TabStop = true;
            this.linkLabel_github.Text = "My Github";
            this.linkLabel_github.Click += new System.EventHandler(this.linkLabel_github_Click);
            // 
            // Update
            // 
            this.Update.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // linkLabel_version
            // 
            this.linkLabel_version.AutoSize = true;
            this.linkLabel_version.Location = new System.Drawing.Point(189, 101);
            this.linkLabel_version.Name = "linkLabel_version";
            this.linkLabel_version.Size = new System.Drawing.Size(32, 13);
            this.linkLabel_version.TabIndex = 7;
            this.linkLabel_version.TabStop = true;
            this.linkLabel_version.Text = "V 2.3";
            this.linkLabel_version.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_version_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_stop);
            this.groupBox1.Controls.Add(this.button_start);
            this.groupBox1.Location = new System.Drawing.Point(250, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_logs);
            this.groupBox2.Controls.Add(this.checkBox_middleclick);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.linkLabel_github);
            this.groupBox2.Controls.Add(this.checkBox_rightclick);
            this.groupBox2.Controls.Add(this.linkLabel_version);
            this.groupBox2.Controls.Add(this.textBox_speed);
            this.groupBox2.Location = new System.Drawing.Point(12, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 138);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // button_logs
            // 
            this.button_logs.Location = new System.Drawing.Point(9, 70);
            this.button_logs.Name = "button_logs";
            this.button_logs.Size = new System.Drawing.Size(124, 21);
            this.button_logs.TabIndex = 9;
            this.button_logs.Text = "Create info  log";
            this.button_logs.UseVisualStyleBackColor = true;
            this.button_logs.Click += new System.EventHandler(this.button_logs_Click);
            // 
            // checkBox_middleclick
            // 
            this.checkBox_middleclick.AutoSize = true;
            this.checkBox_middleclick.Location = new System.Drawing.Point(9, 113);
            this.checkBox_middleclick.Name = "checkBox_middleclick";
            this.checkBox_middleclick.Size = new System.Drawing.Size(114, 17);
            this.checkBox_middleclick.TabIndex = 8;
            this.checkBox_middleclick.Text = "Enable middleclick";
            this.checkBox_middleclick.UseVisualStyleBackColor = true;
            this.checkBox_middleclick.CheckedChanged += new System.EventHandler(this.checkBox_middleclick_CheckedChanged);
            // 
            // EZAutoclicker
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(386, 153);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EZAutoclicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EZAutoclicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EZAutoclicker_FormClosing);
            this.Load += new System.EventHandler(this.EZAutoclicker_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer_mouseclick;
        private System.Windows.Forms.TextBox textBox_speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_rightclick;
        private System.Windows.Forms.LinkLabel linkLabel_github;
        private System.Windows.Forms.Timer Update;
        private System.Windows.Forms.LinkLabel linkLabel_version;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_middleclick;
        private System.Windows.Forms.Button button_logs;
    }
}

