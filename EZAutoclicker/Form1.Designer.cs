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
            this.timer_mouseclick = new System.Windows.Forms.Timer(this.components);
            this.linkLabel_github = new System.Windows.Forms.LinkLabel();
            this.Update = new System.Windows.Forms.Timer(this.components);
            this.linkLabel_version = new System.Windows.Forms.LinkLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_speed = new System.Windows.Forms.MaskedTextBox();
            this.button_start = new MaterialSkin.Controls.MaterialButton();
            this.button_stop = new MaterialSkin.Controls.MaterialButton();
            this.checkBox_rightclick = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkBox_middleclick = new MaterialSkin.Controls.MaterialCheckbox();
            this.button_logs = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_mouseclick
            // 
            this.timer_mouseclick.Enabled = true;
            this.timer_mouseclick.Interval = 1000;
            this.timer_mouseclick.Tick += new System.EventHandler(this.timer_mouseclick_Tick);
            // 
            // linkLabel_github
            // 
            this.linkLabel_github.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_github.AutoSize = true;
            this.linkLabel_github.Location = new System.Drawing.Point(399, 255);
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
            this.linkLabel_version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_version.AutoSize = true;
            this.linkLabel_version.Location = new System.Drawing.Point(431, 231);
            this.linkLabel_version.Name = "linkLabel_version";
            this.linkLabel_version.Size = new System.Drawing.Size(32, 13);
            this.linkLabel_version.TabIndex = 7;
            this.linkLabel_version.TabStop = true;
            this.linkLabel_version.Text = "V 2.5";
            this.linkLabel_version.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_version_LinkClicked);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(12, 19);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(314, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Press shift + strg + F10 to start or press start";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(12, 38);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(206, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Place the speed 1000 = 1 sec";
            // 
            // textBox_speed
            // 
            this.textBox_speed.Location = new System.Drawing.Point(15, 62);
            this.textBox_speed.Name = "textBox_speed";
            this.textBox_speed.Size = new System.Drawing.Size(145, 20);
            this.textBox_speed.TabIndex = 12;
            this.textBox_speed.Text = "1000";
            // 
            // button_start
            // 
            this.button_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_start.AutoSize = false;
            this.button_start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_start.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button_start.Depth = 0;
            this.button_start.HighEmphasis = true;
            this.button_start.Icon = null;
            this.button_start.Location = new System.Drawing.Point(9, 22);
            this.button_start.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_start.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_start.Name = "button_start";
            this.button_start.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button_start.Size = new System.Drawing.Size(110, 49);
            this.button_start.TabIndex = 13;
            this.button_start.Text = "Start";
            this.button_start.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button_start.UseAccentColor = false;
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_stop.AutoSize = false;
            this.button_stop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_stop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button_stop.Depth = 0;
            this.button_stop.HighEmphasis = true;
            this.button_stop.Icon = null;
            this.button_stop.Location = new System.Drawing.Point(9, 85);
            this.button_stop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_stop.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_stop.Name = "button_stop";
            this.button_stop.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button_stop.Size = new System.Drawing.Size(110, 50);
            this.button_stop.TabIndex = 14;
            this.button_stop.Text = "Stop";
            this.button_stop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button_stop.UseAccentColor = false;
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // checkBox_rightclick
            // 
            this.checkBox_rightclick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_rightclick.AutoSize = true;
            this.checkBox_rightclick.Depth = 0;
            this.checkBox_rightclick.Location = new System.Drawing.Point(9, 85);
            this.checkBox_rightclick.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_rightclick.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox_rightclick.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox_rightclick.Name = "checkBox_rightclick";
            this.checkBox_rightclick.ReadOnly = false;
            this.checkBox_rightclick.Ripple = true;
            this.checkBox_rightclick.Size = new System.Drawing.Size(151, 37);
            this.checkBox_rightclick.TabIndex = 15;
            this.checkBox_rightclick.Text = "Enable rightclick";
            this.checkBox_rightclick.UseVisualStyleBackColor = true;
            this.checkBox_rightclick.CheckedChanged += new System.EventHandler(this.checkBox_rightclick_CheckedChanged);
            // 
            // checkBox_middleclick
            // 
            this.checkBox_middleclick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_middleclick.AutoSize = true;
            this.checkBox_middleclick.Depth = 0;
            this.checkBox_middleclick.Location = new System.Drawing.Point(9, 113);
            this.checkBox_middleclick.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_middleclick.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox_middleclick.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox_middleclick.Name = "checkBox_middleclick";
            this.checkBox_middleclick.ReadOnly = false;
            this.checkBox_middleclick.Ripple = true;
            this.checkBox_middleclick.Size = new System.Drawing.Size(167, 37);
            this.checkBox_middleclick.TabIndex = 16;
            this.checkBox_middleclick.Text = "Enable middleclick";
            this.checkBox_middleclick.UseVisualStyleBackColor = true;
            this.checkBox_middleclick.CheckedChanged += new System.EventHandler(this.checkBox_middleclick_CheckedChanged);
            // 
            // button_logs
            // 
            this.button_logs.AutoSize = false;
            this.button_logs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_logs.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button_logs.Depth = 0;
            this.button_logs.HighEmphasis = true;
            this.button_logs.Icon = null;
            this.button_logs.Location = new System.Drawing.Point(9, 156);
            this.button_logs.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_logs.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_logs.Name = "button_logs";
            this.button_logs.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button_logs.Size = new System.Drawing.Size(167, 34);
            this.button_logs.TabIndex = 17;
            this.button_logs.Text = "Create info log";
            this.button_logs.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button_logs.UseAccentColor = false;
            this.button_logs.UseVisualStyleBackColor = true;
            this.button_logs.Click += new System.EventHandler(this.button_logs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button_start);
            this.groupBox1.Controls.Add(this.button_stop);
            this.groupBox1.Location = new System.Drawing.Point(346, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 150);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.checkBox_middleclick);
            this.groupBox2.Controls.Add(this.button_logs);
            this.groupBox2.Controls.Add(this.checkBox_rightclick);
            this.groupBox2.Controls.Add(this.textBox_speed);
            this.groupBox2.Location = new System.Drawing.Point(6, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 199);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EZAutoclicker.Properties.Resources.icon_on2;
            this.pictureBox1.Location = new System.Drawing.Point(243, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // EZAutoclicker
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(479, 283);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel_github);
            this.Controls.Add(this.linkLabel_version);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_mouseclick;
        private System.Windows.Forms.LinkLabel linkLabel_github;
        private System.Windows.Forms.Timer Update;
        private System.Windows.Forms.LinkLabel linkLabel_version;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.MaskedTextBox textBox_speed;
        private MaterialSkin.Controls.MaterialButton button_start;
        private MaterialSkin.Controls.MaterialButton button_stop;
        private MaterialSkin.Controls.MaterialCheckbox checkBox_rightclick;
        private MaterialSkin.Controls.MaterialCheckbox checkBox_middleclick;
        private MaterialSkin.Controls.MaterialButton button_logs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

