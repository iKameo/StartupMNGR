namespace StartupMNGR
{
    partial class mainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.pnl_Shortcut = new System.Windows.Forms.Panel();
            this.lbl_dropInfo = new System.Windows.Forms.Label();
            this.lb_StartupPrograms = new System.Windows.Forms.ListBox();
            this.tb_droppedData = new System.Windows.Forms.TextBox();
            this.lbl_itemCountInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_itemCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_headerInfo = new System.Windows.Forms.Label();
            this.lbl_subHeaderInfo = new System.Windows.Forms.Label();
            this.lbl_headerSeparator = new System.Windows.Forms.Label();
            this.lbl_infoSeperator = new System.Windows.Forms.Label();
            this.lbl_pathInfo = new System.Windows.Forms.Label();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_language = new System.Windows.Forms.Button();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.btn_removeItem = new System.Windows.Forms.Button();
            this.btn_openPath = new System.Windows.Forms.Button();
            this.btn_testRunItem = new System.Windows.Forms.Button();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.pnl_Shortcut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Shortcut
            // 
            this.pnl_Shortcut.AllowDrop = true;
            this.pnl_Shortcut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Shortcut.Controls.Add(this.lbl_dropInfo);
            this.pnl_Shortcut.Location = new System.Drawing.Point(331, 100);
            this.pnl_Shortcut.Name = "pnl_Shortcut";
            this.pnl_Shortcut.Size = new System.Drawing.Size(86, 86);
            this.pnl_Shortcut.TabIndex = 0;
            this.pnl_Shortcut.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnl_Shortcut_DragDrop);
            this.pnl_Shortcut.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnl_Shortcut_DragEnter);
            // 
            // lbl_dropInfo
            // 
            this.lbl_dropInfo.AutoSize = true;
            this.lbl_dropInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dropInfo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_dropInfo.Location = new System.Drawing.Point(0, 2);
            this.lbl_dropInfo.Name = "lbl_dropInfo";
            this.lbl_dropInfo.Size = new System.Drawing.Size(87, 75);
            this.lbl_dropInfo.TabIndex = 3;
            this.lbl_dropInfo.Text = "Drop\r\nshortcut\r\nhere";
            // 
            // lb_StartupPrograms
            // 
            this.lb_StartupPrograms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_StartupPrograms.FormattingEnabled = true;
            this.lb_StartupPrograms.ItemHeight = 15;
            this.lb_StartupPrograms.Location = new System.Drawing.Point(17, 100);
            this.lb_StartupPrograms.Name = "lb_StartupPrograms";
            this.lb_StartupPrograms.Size = new System.Drawing.Size(307, 274);
            this.lb_StartupPrograms.TabIndex = 1;
            // 
            // tb_droppedData
            // 
            this.tb_droppedData.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tb_droppedData.Location = new System.Drawing.Point(17, 418);
            this.tb_droppedData.Name = "tb_droppedData";
            this.tb_droppedData.Size = new System.Drawing.Size(400, 22);
            this.tb_droppedData.TabIndex = 4;
            // 
            // lbl_itemCountInfo
            // 
            this.lbl_itemCountInfo.Name = "lbl_itemCountInfo";
            this.lbl_itemCountInfo.Size = new System.Drawing.Size(100, 17);
            this.lbl_itemCountInfo.Text = "Number of items:";
            // 
            // lbl_itemCount
            // 
            this.lbl_itemCount.Name = "lbl_itemCount";
            this.lbl_itemCount.Size = new System.Drawing.Size(13, 17);
            this.lbl_itemCount.Text = "0";
            // 
            // lbl_headerInfo
            // 
            this.lbl_headerInfo.AutoSize = true;
            this.lbl_headerInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headerInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_headerInfo.Location = new System.Drawing.Point(12, 22);
            this.lbl_headerInfo.Name = "lbl_headerInfo";
            this.lbl_headerInfo.Size = new System.Drawing.Size(291, 25);
            this.lbl_headerInfo.TabIndex = 9;
            this.lbl_headerInfo.Text = "Manage all your autostart entries";
            // 
            // lbl_subHeaderInfo
            // 
            this.lbl_subHeaderInfo.AutoSize = true;
            this.lbl_subHeaderInfo.Location = new System.Drawing.Point(14, 52);
            this.lbl_subHeaderInfo.Name = "lbl_subHeaderInfo";
            this.lbl_subHeaderInfo.Size = new System.Drawing.Size(167, 13);
            this.lbl_subHeaderInfo.TabIndex = 10;
            this.lbl_subHeaderInfo.Text = "add and remove your shortcuts";
            // 
            // lbl_headerSeparator
            // 
            this.lbl_headerSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_headerSeparator.Location = new System.Drawing.Point(17, 82);
            this.lbl_headerSeparator.Name = "lbl_headerSeparator";
            this.lbl_headerSeparator.Size = new System.Drawing.Size(400, 2);
            this.lbl_headerSeparator.TabIndex = 12;
            // 
            // lbl_infoSeperator
            // 
            this.lbl_infoSeperator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_infoSeperator.Location = new System.Drawing.Point(17, 395);
            this.lbl_infoSeperator.Name = "lbl_infoSeperator";
            this.lbl_infoSeperator.Size = new System.Drawing.Size(400, 2);
            this.lbl_infoSeperator.TabIndex = 13;
            // 
            // lbl_pathInfo
            // 
            this.lbl_pathInfo.AutoSize = true;
            this.lbl_pathInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_pathInfo.Location = new System.Drawing.Point(14, 402);
            this.lbl_pathInfo.Name = "lbl_pathInfo";
            this.lbl_pathInfo.Size = new System.Drawing.Size(93, 13);
            this.lbl_pathInfo.TabIndex = 14;
            this.lbl_pathInfo.Text = "Path to shortcut:";
            // 
            // btn_help
            // 
            this.btn_help.Image = global::StartupMNGR.Properties.Resources.help;
            this.btn_help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_help.Location = new System.Drawing.Point(331, 320);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(86, 24);
            this.btn_help.TabIndex = 16;
            this.btn_help.Text = "About";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_language
            // 
            this.btn_language.Image = global::StartupMNGR.Properties.Resources.world;
            this.btn_language.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_language.Location = new System.Drawing.Point(331, 350);
            this.btn_language.Name = "btn_language";
            this.btn_language.Size = new System.Drawing.Size(86, 24);
            this.btn_language.TabIndex = 15;
            this.btn_language.Text = "Language";
            this.btn_language.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_language.UseVisualStyleBackColor = true;
            // 
            // btn_addItem
            // 
            this.btn_addItem.Image = global::StartupMNGR.Properties.Resources.add;
            this.btn_addItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addItem.Location = new System.Drawing.Point(331, 192);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(86, 24);
            this.btn_addItem.TabIndex = 5;
            this.btn_addItem.Text = "Add";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // btn_removeItem
            // 
            this.btn_removeItem.Image = global::StartupMNGR.Properties.Resources.delete;
            this.btn_removeItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_removeItem.Location = new System.Drawing.Point(331, 222);
            this.btn_removeItem.Name = "btn_removeItem";
            this.btn_removeItem.Size = new System.Drawing.Size(86, 24);
            this.btn_removeItem.TabIndex = 2;
            this.btn_removeItem.Text = "Delete";
            this.btn_removeItem.UseVisualStyleBackColor = true;
            this.btn_removeItem.Click += new System.EventHandler(this.btn_removeItem_Click);
            // 
            // btn_openPath
            // 
            this.btn_openPath.Image = global::StartupMNGR.Properties.Resources.application_form_magnify;
            this.btn_openPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_openPath.Location = new System.Drawing.Point(331, 252);
            this.btn_openPath.Name = "btn_openPath";
            this.btn_openPath.Size = new System.Drawing.Size(86, 24);
            this.btn_openPath.TabIndex = 7;
            this.btn_openPath.Text = "Open Path";
            this.btn_openPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_openPath.UseVisualStyleBackColor = true;
            this.btn_openPath.Click += new System.EventHandler(this.btn_openPath_Click);
            // 
            // btn_testRunItem
            // 
            this.btn_testRunItem.Image = global::StartupMNGR.Properties.Resources.script_go;
            this.btn_testRunItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_testRunItem.Location = new System.Drawing.Point(331, 282);
            this.btn_testRunItem.Name = "btn_testRunItem";
            this.btn_testRunItem.Size = new System.Drawing.Size(86, 24);
            this.btn_testRunItem.TabIndex = 6;
            this.btn_testRunItem.Text = "Test Run";
            this.btn_testRunItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_testRunItem.UseVisualStyleBackColor = true;
            this.btn_testRunItem.Click += new System.EventHandler(this.btn_testRunItem_Click);
            // 
            // pb_logo
            // 
            this.pb_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_logo.Image = global::StartupMNGR.Properties.Resources.Autostart_logo;
            this.pb_logo.Location = new System.Drawing.Point(353, 10);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(64, 64);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 7;
            this.pb_logo.TabStop = false;
            // 
            // mainFrm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_language);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.lbl_pathInfo);
            this.Controls.Add(this.btn_removeItem);
            this.Controls.Add(this.lbl_infoSeperator);
            this.Controls.Add(this.btn_openPath);
            this.Controls.Add(this.btn_testRunItem);
            this.Controls.Add(this.lbl_headerSeparator);
            this.Controls.Add(this.lbl_subHeaderInfo);
            this.Controls.Add(this.lbl_headerInfo);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.tb_droppedData);
            this.Controls.Add(this.lb_StartupPrograms);
            this.Controls.Add(this.pnl_Shortcut);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainFrm";
            this.Text = "StartupMNGR - BETA";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.pnl_Shortcut.ResumeLayout(false);
            this.pnl_Shortcut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Shortcut;
        private System.Windows.Forms.ListBox lb_StartupPrograms;
        private System.Windows.Forms.Label lbl_dropInfo;
        private System.Windows.Forms.Button btn_removeItem;
        private System.Windows.Forms.TextBox tb_droppedData;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.ToolStripStatusLabel lbl_itemCountInfo;
        private System.Windows.Forms.Button btn_testRunItem;
        private System.Windows.Forms.Button btn_openPath;
        private System.Windows.Forms.ToolStripStatusLabel lbl_itemCount;
        private System.Windows.Forms.Label lbl_headerInfo;
        private System.Windows.Forms.Label lbl_subHeaderInfo;
        private System.Windows.Forms.Label lbl_headerSeparator;
        private System.Windows.Forms.Label lbl_infoSeperator;
        private System.Windows.Forms.Label lbl_pathInfo;
        private System.Windows.Forms.Button btn_language;
        private System.Windows.Forms.Button btn_help;
    }
}

