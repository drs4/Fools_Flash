namespace FoolsFlash
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.notyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrChk = new System.Windows.Forms.Timer(this.components);
            this.thrdCopy = new System.ComponentModel.BackgroundWorker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkBaloon = new System.Windows.Forms.CheckBox();
            this.chkActivate = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnBrows = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chkAvoid = new System.Windows.Forms.CheckBox();
            this.thrd2flash = new System.ComponentModel.BackgroundWorker();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notyIcon
            // 
            this.notyIcon.ContextMenuStrip = this.mainMenu;
            this.notyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notyIcon.Icon")));
            this.notyIcon.Text = "Fools Flash";
            this.notyIcon.Visible = true;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.autoRunToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(125, 70);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.aboutToolStripMenuItem.Text = "Settings";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // autoRunToolStripMenuItem
            // 
            this.autoRunToolStripMenuItem.Checked = true;
            this.autoRunToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoRunToolStripMenuItem.Name = "autoRunToolStripMenuItem";
            this.autoRunToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.autoRunToolStripMenuItem.Text = "Auto Run";
            this.autoRunToolStripMenuItem.Click += new System.EventHandler(this.autoRunToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tmrChk
            // 
            this.tmrChk.Enabled = true;
            this.tmrChk.Interval = 20000;
            this.tmrChk.Tick += new System.EventHandler(this.tmrChk_Tick);
            // 
            // thrdCopy
            // 
            this.thrdCopy.DoWork += new System.ComponentModel.DoWorkEventHandler(this.thrdCopy_DoWork);
            this.thrdCopy.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.thrdCopy_WorkCompleted);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(26, 212);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(185, 212);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkBaloon
            // 
            this.chkBaloon.AutoSize = true;
            this.chkBaloon.Location = new System.Drawing.Point(26, 31);
            this.chkBaloon.Name = "chkBaloon";
            this.chkBaloon.Size = new System.Drawing.Size(167, 17);
            this.chkBaloon.TabIndex = 3;
            this.chkBaloon.Text = "Use Balloon to indicate states";
            this.chkBaloon.UseVisualStyleBackColor = true;
            this.chkBaloon.CheckedChanged += new System.EventHandler(this.chkBaloon_CheckedChanged);
            // 
            // chkActivate
            // 
            this.chkActivate.AutoSize = true;
            this.chkActivate.Location = new System.Drawing.Point(26, 54);
            this.chkActivate.Name = "chkActivate";
            this.chkActivate.Size = new System.Drawing.Size(197, 17);
            this.chkActivate.TabIndex = 4;
            this.chkActivate.Text = "Activate/Deactivate the check clock";
            this.chkActivate.UseVisualStyleBackColor = true;
            this.chkActivate.CheckedChanged += new System.EventHandler(this.chkActivate_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Where to Save Data:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(26, 113);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(234, 20);
            this.txtLocation.TabIndex = 6;
            // 
            // btnBrows
            // 
            this.btnBrows.Location = new System.Drawing.Point(105, 139);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(75, 23);
            this.btnBrows.TabIndex = 7;
            this.btnBrows.Text = "&Browse";
            this.btnBrows.UseVisualStyleBackColor = true;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select where to save data. Notice that it will work for one time and one time onl" +
    "y";
            // 
            // chkAvoid
            // 
            this.chkAvoid.AutoSize = true;
            this.chkAvoid.Location = new System.Drawing.Point(26, 77);
            this.chkAvoid.Name = "chkAvoid";
            this.chkAvoid.Size = new System.Drawing.Size(194, 17);
            this.chkAvoid.TabIndex = 8;
            this.chkAvoid.Text = "Avoid viruses but keep applications";
            this.chkAvoid.UseVisualStyleBackColor = true;
            this.chkAvoid.CheckedChanged += new System.EventHandler(this.chkAvoid_CheckedChanged);
            // 
            // thrd2flash
            // 
            this.thrd2flash.DoWork += new System.ComponentModel.DoWorkEventHandler(this.thrd2flash_DoWork);
            this.thrd2flash.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.thrd2flash_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.chkAvoid);
            this.Controls.Add(this.btnBrows);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkActivate);
            this.Controls.Add(this.chkBaloon);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "Fools Flash";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mainMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notyIcon;
        private System.Windows.Forms.ContextMenuStrip mainMenu;
        private System.Windows.Forms.Timer tmrChk;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoRunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker thrdCopy;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chkBaloon;
        private System.Windows.Forms.CheckBox chkActivate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox chkAvoid;
        private System.ComponentModel.BackgroundWorker thrd2flash;
    }
}

