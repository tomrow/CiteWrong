namespace CiteWrong
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.loadFileDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.mergeAndRemoveDuplicatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NeatMergeCButton = new System.Windows.Forms.ToolStripMenuItem();
            this.NeatMergeSButton = new System.Windows.Forms.ToolStripMenuItem();
            this.justRemoveSharedSourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutCButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CutSButton = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyKeepSharedSourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeepDupCButton = new System.Windows.Forms.ToolStripMenuItem();
            this.KeepDupSButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileDropDown});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(216, 32);
            this.toolStrip1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // loadFileDropDown
            // 
            this.loadFileDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.loadFileDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mergeAndRemoveDuplicatesToolStripMenuItem,
            this.justRemoveSharedSourcesToolStripMenuItem,
            this.onlyKeepSharedSourcesToolStripMenuItem});
            this.loadFileDropDown.Image = ((System.Drawing.Image)(resources.GetObject("loadFileDropDown.Image")));
            this.loadFileDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadFileDropDown.Name = "loadFileDropDown";
            this.loadFileDropDown.Size = new System.Drawing.Size(186, 29);
            this.loadFileDropDown.Text = "Load additional bibliography and...";
            // 
            // mergeAndRemoveDuplicatesToolStripMenuItem
            // 
            this.mergeAndRemoveDuplicatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NeatMergeCButton,
            this.NeatMergeSButton});
            this.mergeAndRemoveDuplicatesToolStripMenuItem.Name = "mergeAndRemoveDuplicatesToolStripMenuItem";
            this.mergeAndRemoveDuplicatesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.mergeAndRemoveDuplicatesToolStripMenuItem.Text = "Merge and remove duplicates";
            // 
            // NeatMergeCButton
            // 
            this.NeatMergeCButton.Name = "NeatMergeCButton";
            this.NeatMergeCButton.Size = new System.Drawing.Size(166, 22);
            this.NeatMergeCButton.Text = "Citations";
            this.NeatMergeCButton.Click += new System.EventHandler(this.NeatMergeCButton_Click);
            // 
            // NeatMergeSButton
            // 
            this.NeatMergeSButton.Name = "NeatMergeSButton";
            this.NeatMergeSButton.Size = new System.Drawing.Size(166, 22);
            this.NeatMergeSButton.Text = "Reference styles";
            this.NeatMergeSButton.Click += new System.EventHandler(this.NeatMergeSButton_Click);
            // 
            // justRemoveSharedSourcesToolStripMenuItem
            // 
            this.justRemoveSharedSourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutCButton,
            this.CutSButton});
            this.justRemoveSharedSourcesToolStripMenuItem.Name = "justRemoveSharedSourcesToolStripMenuItem";
            this.justRemoveSharedSourcesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.justRemoveSharedSourcesToolStripMenuItem.Text = "Just remove shared data";
            this.justRemoveSharedSourcesToolStripMenuItem.Click += new System.EventHandler(this.justRemoveSharedSourcesToolStripMenuItem_Click);
            // 
            // CutCButton
            // 
            this.CutCButton.Name = "CutCButton";
            this.CutCButton.Size = new System.Drawing.Size(166, 22);
            this.CutCButton.Text = "Citations";
            this.CutCButton.Click += new System.EventHandler(this.CutCButton_Click);
            // 
            // CutSButton
            // 
            this.CutSButton.Name = "CutSButton";
            this.CutSButton.Size = new System.Drawing.Size(166, 22);
            this.CutSButton.Text = "Reference styles";
            this.CutSButton.Click += new System.EventHandler(this.CutSButton_Click);
            // 
            // onlyKeepSharedSourcesToolStripMenuItem
            // 
            this.onlyKeepSharedSourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KeepDupCButton,
            this.KeepDupSButton});
            this.onlyKeepSharedSourcesToolStripMenuItem.Name = "onlyKeepSharedSourcesToolStripMenuItem";
            this.onlyKeepSharedSourcesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.onlyKeepSharedSourcesToolStripMenuItem.Text = "Only keep shared sources";
            // 
            // KeepDupCButton
            // 
            this.KeepDupCButton.Name = "KeepDupCButton";
            this.KeepDupCButton.Size = new System.Drawing.Size(166, 22);
            this.KeepDupCButton.Text = "Citations";
            this.KeepDupCButton.Click += new System.EventHandler(this.KeepDupCButton_Click);
            // 
            // KeepDupSButton
            // 
            this.KeepDupSButton.Name = "KeepDupSButton";
            this.KeepDupSButton.Size = new System.Drawing.Size(166, 22);
            this.KeepDupSButton.Text = "Reference styles";
            this.KeepDupSButton.Click += new System.EventHandler(this.KeepDupSButton_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 32);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form5";
            this.Text = "Batch operation";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton loadFileDropDown;
        private System.Windows.Forms.ToolStripMenuItem mergeAndRemoveDuplicatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NeatMergeCButton;
        private System.Windows.Forms.ToolStripMenuItem justRemoveSharedSourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlyKeepSharedSourcesToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem NeatMergeSButton;
        private System.Windows.Forms.ToolStripMenuItem CutCButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CutSButton;
        private System.Windows.Forms.ToolStripMenuItem KeepDupCButton;
        private System.Windows.Forms.ToolStripMenuItem KeepDupSButton;
    }
}