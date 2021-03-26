namespace StartupMNGR
{
    partial class helpFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(helpFrm));
            this.lbl_headerSeparator = new System.Windows.Forms.Label();
            this.lbl_headerInfo = new System.Windows.Forms.Label();
            this.lbl_versionInfo = new System.Windows.Forms.Label();
            this.lbl_builtInfo = new System.Windows.Forms.Label();
            this.lbl_copyrightInfo = new System.Windows.Forms.Label();
            this.rtb_legalInfo = new System.Windows.Forms.RichTextBox();
            this.lbl_homepage = new System.Windows.Forms.LinkLabel();
            this.lbl_version = new System.Windows.Forms.Label();
            this.lbl_built = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_headerSeparator
            // 
            this.lbl_headerSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_headerSeparator.Location = new System.Drawing.Point(17, 82);
            this.lbl_headerSeparator.Name = "lbl_headerSeparator";
            this.lbl_headerSeparator.Size = new System.Drawing.Size(400, 2);
            this.lbl_headerSeparator.TabIndex = 16;
            // 
            // lbl_headerInfo
            // 
            this.lbl_headerInfo.AutoSize = true;
            this.lbl_headerInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headerInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_headerInfo.Location = new System.Drawing.Point(12, 22);
            this.lbl_headerInfo.Name = "lbl_headerInfo";
            this.lbl_headerInfo.Size = new System.Drawing.Size(183, 25);
            this.lbl_headerInfo.TabIndex = 14;
            this.lbl_headerInfo.Text = "About StartupMNGR";
            // 
            // lbl_versionInfo
            // 
            this.lbl_versionInfo.AutoSize = true;
            this.lbl_versionInfo.Location = new System.Drawing.Point(14, 93);
            this.lbl_versionInfo.Name = "lbl_versionInfo";
            this.lbl_versionInfo.Size = new System.Drawing.Size(48, 15);
            this.lbl_versionInfo.TabIndex = 17;
            this.lbl_versionInfo.Text = "Version:";
            // 
            // lbl_builtInfo
            // 
            this.lbl_builtInfo.AutoSize = true;
            this.lbl_builtInfo.Location = new System.Drawing.Point(14, 118);
            this.lbl_builtInfo.Name = "lbl_builtInfo";
            this.lbl_builtInfo.Size = new System.Drawing.Size(34, 15);
            this.lbl_builtInfo.TabIndex = 18;
            this.lbl_builtInfo.Text = "Built:";
            // 
            // lbl_copyrightInfo
            // 
            this.lbl_copyrightInfo.AutoSize = true;
            this.lbl_copyrightInfo.Location = new System.Drawing.Point(14, 143);
            this.lbl_copyrightInfo.Name = "lbl_copyrightInfo";
            this.lbl_copyrightInfo.Size = new System.Drawing.Size(40, 15);
            this.lbl_copyrightInfo.TabIndex = 19;
            this.lbl_copyrightInfo.Text = "Made:";
            // 
            // rtb_legalInfo
            // 
            this.rtb_legalInfo.Location = new System.Drawing.Point(17, 170);
            this.rtb_legalInfo.Name = "rtb_legalInfo";
            this.rtb_legalInfo.ReadOnly = true;
            this.rtb_legalInfo.Size = new System.Drawing.Size(400, 161);
            this.rtb_legalInfo.TabIndex = 20;
            this.rtb_legalInfo.Text = resources.GetString("rtb_legalInfo.Text");
            // 
            // lbl_homepage
            // 
            this.lbl_homepage.AutoSize = true;
            this.lbl_homepage.Location = new System.Drawing.Point(14, 52);
            this.lbl_homepage.Name = "lbl_homepage";
            this.lbl_homepage.Size = new System.Drawing.Size(105, 15);
            this.lbl_homepage.TabIndex = 21;
            this.lbl_homepage.TabStop = true;
            this.lbl_homepage.Text = "https://ikameo.xyz";
            this.lbl_homepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_homepage_LinkClicked);
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(68, 93);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(13, 15);
            this.lbl_version.TabIndex = 22;
            this.lbl_version.Text = "0";
            // 
            // lbl_built
            // 
            this.lbl_built.AutoSize = true;
            this.lbl_built.Location = new System.Drawing.Point(54, 118);
            this.lbl_built.Name = "lbl_built";
            this.lbl_built.Size = new System.Drawing.Size(61, 15);
            this.lbl_built.TabIndex = 23;
            this.lbl_built.Text = "00.00.0000";
            // 
            // pb_logo
            // 
            this.pb_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_logo.Image = global::StartupMNGR.Properties.Resources.Autostart_logo;
            this.pb_logo.Location = new System.Drawing.Point(353, 10);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(64, 64);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 13;
            this.pb_logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "iKameo, 2019";
            // 
            // helpFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_built);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.lbl_homepage);
            this.Controls.Add(this.rtb_legalInfo);
            this.Controls.Add(this.lbl_copyrightInfo);
            this.Controls.Add(this.lbl_builtInfo);
            this.Controls.Add(this.lbl_versionInfo);
            this.Controls.Add(this.lbl_headerSeparator);
            this.Controls.Add(this.lbl_headerInfo);
            this.Controls.Add(this.pb_logo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "helpFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StartupMNGR - Help";
            this.Load += new System.EventHandler(this.helpFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_headerSeparator;
        private System.Windows.Forms.Label lbl_headerInfo;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label lbl_versionInfo;
        private System.Windows.Forms.Label lbl_builtInfo;
        private System.Windows.Forms.Label lbl_copyrightInfo;
        private System.Windows.Forms.RichTextBox rtb_legalInfo;
        private System.Windows.Forms.LinkLabel lbl_homepage;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label lbl_built;
        private System.Windows.Forms.Label label1;
    }
}