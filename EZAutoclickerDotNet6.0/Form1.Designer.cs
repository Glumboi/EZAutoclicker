namespace EZAutoclickerDotNet6._0
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Start_BN = new MaterialSkin.Controls.MaterialButton();
            this.Stop_BN = new MaterialSkin.Controls.MaterialButton();
            this.Log_BN = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Speed_TB = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Version_LLBL = new System.Windows.Forms.LinkLabel();
            this.Github_LLBL = new System.Windows.Forms.LinkLabel();
            this.Middleclick_CB = new MaterialSkin.Controls.MaterialCheckbox();
            this.Rightclick_CB = new MaterialSkin.Controls.MaterialCheckbox();
            this.Mouseclick_TR = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start_BN
            // 
            this.Start_BN.AutoSize = false;
            this.Start_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Start_BN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Start_BN.Depth = 0;
            this.Start_BN.HighEmphasis = true;
            this.Start_BN.Icon = null;
            this.Start_BN.Location = new System.Drawing.Point(21, 27);
            this.Start_BN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Start_BN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Start_BN.Name = "Start_BN";
            this.Start_BN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Start_BN.Size = new System.Drawing.Size(158, 36);
            this.Start_BN.TabIndex = 0;
            this.Start_BN.Text = "Start";
            this.Start_BN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Start_BN.UseAccentColor = false;
            this.Start_BN.UseVisualStyleBackColor = true;
            this.Start_BN.Click += new System.EventHandler(this.Start_BN_Click);
            // 
            // Stop_BN
            // 
            this.Stop_BN.AutoSize = false;
            this.Stop_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Stop_BN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Stop_BN.Depth = 0;
            this.Stop_BN.HighEmphasis = true;
            this.Stop_BN.Icon = null;
            this.Stop_BN.Location = new System.Drawing.Point(21, 75);
            this.Stop_BN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Stop_BN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Stop_BN.Name = "Stop_BN";
            this.Stop_BN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Stop_BN.Size = new System.Drawing.Size(158, 36);
            this.Stop_BN.TabIndex = 1;
            this.Stop_BN.Text = "Stop";
            this.Stop_BN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Stop_BN.UseAccentColor = false;
            this.Stop_BN.UseVisualStyleBackColor = true;
            this.Stop_BN.Click += new System.EventHandler(this.Stop_BN_Click);
            // 
            // Log_BN
            // 
            this.Log_BN.AutoSize = false;
            this.Log_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Log_BN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Log_BN.Depth = 0;
            this.Log_BN.HighEmphasis = true;
            this.Log_BN.Icon = null;
            this.Log_BN.Location = new System.Drawing.Point(21, 123);
            this.Log_BN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Log_BN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Log_BN.Name = "Log_BN";
            this.Log_BN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Log_BN.Size = new System.Drawing.Size(158, 36);
            this.Log_BN.TabIndex = 2;
            this.Log_BN.Text = "Create log";
            this.Log_BN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Log_BN.UseAccentColor = false;
            this.Log_BN.UseVisualStyleBackColor = true;
            this.Log_BN.Click += new System.EventHandler(this.Log_BN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Start_BN);
            this.groupBox1.Controls.Add(this.Log_BN);
            this.groupBox1.Controls.Add(this.Stop_BN);
            this.groupBox1.Location = new System.Drawing.Point(347, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 183);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // Speed_TB
            // 
            this.Speed_TB.AnimateReadOnly = false;
            this.Speed_TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Speed_TB.Depth = 0;
            this.Speed_TB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Speed_TB.LeadingIcon = null;
            this.Speed_TB.Location = new System.Drawing.Point(9, 56);
            this.Speed_TB.MaxLength = 50;
            this.Speed_TB.MouseState = MaterialSkin.MouseState.OUT;
            this.Speed_TB.Multiline = false;
            this.Speed_TB.Name = "Speed_TB";
            this.Speed_TB.Size = new System.Drawing.Size(317, 50);
            this.Speed_TB.TabIndex = 5;
            this.Speed_TB.Text = "1000";
            this.Speed_TB.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(9, 19);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(317, 44);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Press Shift + Ctrl + F10 to start or press start\r\nPlace the speed 1000 = 1 click " +
    "every second\r\n\r\n\r\n\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Version_LLBL);
            this.groupBox2.Controls.Add(this.Github_LLBL);
            this.groupBox2.Controls.Add(this.Middleclick_CB);
            this.groupBox2.Controls.Add(this.Rightclick_CB);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Controls.Add(this.Speed_TB);
            this.groupBox2.Location = new System.Drawing.Point(6, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 183);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // Version_LLBL
            // 
            this.Version_LLBL.AutoSize = true;
            this.Version_LLBL.Location = new System.Drawing.Point(289, 137);
            this.Version_LLBL.Name = "Version_LLBL";
            this.Version_LLBL.Size = new System.Drawing.Size(32, 15);
            this.Version_LLBL.TabIndex = 10;
            this.Version_LLBL.TabStop = true;
            this.Version_LLBL.Text = "V 3.0";
            this.Version_LLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Version_LLBL_LinkClicked);
            // 
            // Github_LLBL
            // 
            this.Github_LLBL.AutoSize = true;
            this.Github_LLBL.Location = new System.Drawing.Point(258, 159);
            this.Github_LLBL.Name = "Github_LLBL";
            this.Github_LLBL.Size = new System.Drawing.Size(63, 15);
            this.Github_LLBL.TabIndex = 9;
            this.Github_LLBL.TabStop = true;
            this.Github_LLBL.Text = "My Github";
            this.Github_LLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Github_LLBL_LinkClicked);
            // 
            // Middleclick_CB
            // 
            this.Middleclick_CB.AutoSize = true;
            this.Middleclick_CB.Depth = 0;
            this.Middleclick_CB.Location = new System.Drawing.Point(3, 137);
            this.Middleclick_CB.Margin = new System.Windows.Forms.Padding(0);
            this.Middleclick_CB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Middleclick_CB.MouseState = MaterialSkin.MouseState.HOVER;
            this.Middleclick_CB.Name = "Middleclick_CB";
            this.Middleclick_CB.ReadOnly = false;
            this.Middleclick_CB.Ripple = true;
            this.Middleclick_CB.Size = new System.Drawing.Size(167, 37);
            this.Middleclick_CB.TabIndex = 8;
            this.Middleclick_CB.Text = "Enable middleclick";
            this.Middleclick_CB.UseVisualStyleBackColor = true;
            this.Middleclick_CB.CheckedChanged += new System.EventHandler(this.Middleclick_CB_CheckedChanged);
            // 
            // Rightclick_CB
            // 
            this.Rightclick_CB.AutoSize = true;
            this.Rightclick_CB.Depth = 0;
            this.Rightclick_CB.Location = new System.Drawing.Point(3, 109);
            this.Rightclick_CB.Margin = new System.Windows.Forms.Padding(0);
            this.Rightclick_CB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Rightclick_CB.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rightclick_CB.Name = "Rightclick_CB";
            this.Rightclick_CB.ReadOnly = false;
            this.Rightclick_CB.Ripple = true;
            this.Rightclick_CB.Size = new System.Drawing.Size(151, 37);
            this.Rightclick_CB.TabIndex = 7;
            this.Rightclick_CB.Text = "Enable rightclick";
            this.Rightclick_CB.UseVisualStyleBackColor = true;
            this.Rightclick_CB.CheckedChanged += new System.EventHandler(this.Rightclick_CB_CheckedChanged);
            // 
            // Mouseclick_TR
            // 
            this.Mouseclick_TR.Tick += new System.EventHandler(this.Mouseclick_TR_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 257);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(554, 257);
            this.MinimumSize = new System.Drawing.Size(554, 257);
            this.Name = "Form1";
            this.Text = "EZAutoclicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton Start_BN;
        private MaterialSkin.Controls.MaterialButton Stop_BN;
        private MaterialSkin.Controls.MaterialButton Log_BN;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox Speed_TB;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialCheckbox Middleclick_CB;
        private MaterialSkin.Controls.MaterialCheckbox Rightclick_CB;
        private System.Windows.Forms.Timer Mouseclick_TR;
        private LinkLabel Version_LLBL;
        private LinkLabel Github_LLBL;
    }
}