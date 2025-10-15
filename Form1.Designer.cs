namespace CiteWrong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.schemeName = new System.Windows.Forms.ToolStripLabel();
            this.citeList = new System.Windows.Forms.ListBox();
            this.schemeImportFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BiblioFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDatabaseDialog = new System.Windows.Forms.SaveFileDialog();
            this.exportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.importScheme = new System.Windows.Forms.ToolStripButton();
            this.editSchemeBtn = new System.Windows.Forms.ToolStripButton();
            this.sortByDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.authorNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliographyEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.copyToolStripButton,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.sortByDropDown,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton1,
            this.importScheme,
            this.editSchemeBtn,
            this.schemeName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(826, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // schemeName
            // 
            this.schemeName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.schemeName.Name = "schemeName";
            this.schemeName.Size = new System.Drawing.Size(175, 13);
            this.schemeName.Text = "A scheme file has not been loaded.";
            this.schemeName.Click += new System.EventHandler(this.schemeName_Click);
            // 
            // citeList
            // 
            this.citeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.citeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citeList.FormattingEnabled = true;
            this.citeList.Location = new System.Drawing.Point(0, 25);
            this.citeList.Name = "citeList";
            this.citeList.Size = new System.Drawing.Size(826, 241);
            this.citeList.TabIndex = 1;
            this.citeList.SelectedIndexChanged += new System.EventHandler(this.citeList_SelectedIndexChanged);
            this.citeList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.citeList_MouseDoubleClick);
            // 
            // schemeImportFileDialog
            // 
            this.schemeImportFileDialog.DefaultExt = "wrong";
            this.schemeImportFileDialog.Filter = "Bibliography scheme|*.wrong|All files|*.*";
            this.schemeImportFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.schemeImportFileDialog_FileOk);
            // 
            // BiblioFileDialog
            // 
            this.BiblioFileDialog.DefaultExt = "bibx";
            this.BiblioFileDialog.Filter = "Bibliography database|*.bibx|All files|*.*";
            this.BiblioFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.BiblioFileDialog_FileOk);
            // 
            // saveDatabaseDialog
            // 
            this.saveDatabaseDialog.CreatePrompt = true;
            this.saveDatabaseDialog.DefaultExt = "bibx";
            this.saveDatabaseDialog.Filter = "Bibliography database|*.bibx|All files|*.*";
            this.saveDatabaseDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveDatabaseDialog_FileOk);
            // 
            // exportFileDialog
            // 
            this.exportFileDialog.CreatePrompt = true;
            this.exportFileDialog.DefaultExt = "htm";
            this.exportFileDialog.Filter = "HTML file|*.htm|All files|*.*";
            this.exportFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.exportFileDialog_FileOk);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = global::CiteWrong.Properties.Resources.copycite;
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(129, 22);
            this.copyToolStripButton.Text = "&Copy In-text Citation";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::CiteWrong.Properties.Resources.link;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(95, 22);
            this.toolStripButton4.Text = "Copy Location";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::CiteWrong.Properties.Resources.add;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(82, 22);
            this.toolStripButton2.Text = "Add Source";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripButton3.Image = global::CiteWrong.Properties.Resources.delete;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(94, 22);
            this.toolStripButton3.Text = "Delete Source";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::CiteWrong.Properties.Resources.export;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(59, 22);
            this.toolStripButton1.Text = "Export";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // importScheme
            // 
            this.importScheme.Image = global::CiteWrong.Properties.Resources.scheme;
            this.importScheme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importScheme.Name = "importScheme";
            this.importScheme.Size = new System.Drawing.Size(99, 22);
            this.importScheme.Text = "Import Scheme";
            this.importScheme.Click += new System.EventHandler(this.importScheme_Click);
            // 
            // editSchemeBtn
            // 
            this.editSchemeBtn.Image = global::CiteWrong.Properties.Resources.editscheme;
            this.editSchemeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editSchemeBtn.Name = "editSchemeBtn";
            this.editSchemeBtn.Size = new System.Drawing.Size(85, 22);
            this.editSchemeBtn.Text = "Edit Scheme";
            this.editSchemeBtn.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // sortByDropDown
            // 
            this.sortByDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorNameToolStripMenuItem,
            this.workNameToolStripMenuItem,
            this.accessLocationToolStripMenuItem,
            this.bibliographyEntryToolStripMenuItem});
            this.sortByDropDown.Image = ((System.Drawing.Image)(resources.GetObject("sortByDropDown.Image")));
            this.sortByDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortByDropDown.Name = "sortByDropDown";
            this.sortByDropDown.Size = new System.Drawing.Size(83, 22);
            this.sortByDropDown.Text = "Sort by...";
            this.sortByDropDown.ToolTipText = "Sort the bibliography database by a specific category";
            // 
            // authorNameToolStripMenuItem
            // 
            this.authorNameToolStripMenuItem.Name = "authorNameToolStripMenuItem";
            this.authorNameToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.authorNameToolStripMenuItem.Text = "Author Name";
            this.authorNameToolStripMenuItem.Click += new System.EventHandler(this.authorNameToolStripMenuItem_Click);
            // 
            // workNameToolStripMenuItem
            // 
            this.workNameToolStripMenuItem.Name = "workNameToolStripMenuItem";
            this.workNameToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.workNameToolStripMenuItem.Text = "Work Name";
            this.workNameToolStripMenuItem.Click += new System.EventHandler(this.workNameToolStripMenuItem_Click);
            // 
            // accessLocationToolStripMenuItem
            // 
            this.accessLocationToolStripMenuItem.Name = "accessLocationToolStripMenuItem";
            this.accessLocationToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.accessLocationToolStripMenuItem.Text = "Access location";
            this.accessLocationToolStripMenuItem.Click += new System.EventHandler(this.accessLocationToolStripMenuItem_Click);
            // 
            // bibliographyEntryToolStripMenuItem
            // 
            this.bibliographyEntryToolStripMenuItem.Name = "bibliographyEntryToolStripMenuItem";
            this.bibliographyEntryToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.bibliographyEntryToolStripMenuItem.Text = "Bibliography entry";
            this.bibliographyEntryToolStripMenuItem.Click += new System.EventHandler(this.bibliographyEntryToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 266);
            this.Controls.Add(this.citeList);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CiteWrong";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ListBox citeList;
        private System.Windows.Forms.ToolStripButton importScheme;
        private System.Windows.Forms.OpenFileDialog schemeImportFileDialog;
        private System.Windows.Forms.OpenFileDialog BiblioFileDialog;
        private System.Windows.Forms.ToolStripLabel schemeName;
        private System.Windows.Forms.SaveFileDialog saveDatabaseDialog;
        private System.Windows.Forms.SaveFileDialog exportFileDialog;
        private System.Windows.Forms.ToolStripButton editSchemeBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripDropDownButton sortByDropDown;
        private System.Windows.Forms.ToolStripMenuItem authorNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bibliographyEntryToolStripMenuItem;
    }
}

