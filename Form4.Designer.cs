namespace CiteWrong
{
    partial class Form4
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.sourceTypes = new System.Windows.Forms.ListBox();
            this.addTypeBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTypeBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(606, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // sourceTypes
            // 
            this.sourceTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceTypes.FormattingEnabled = true;
            this.sourceTypes.Location = new System.Drawing.Point(0, 25);
            this.sourceTypes.Name = "sourceTypes";
            this.sourceTypes.Size = new System.Drawing.Size(606, 347);
            this.sourceTypes.TabIndex = 1;
            this.sourceTypes.DoubleClick += new System.EventHandler(this.sourceTypes_DoubleClick);
            // 
            // addTypeBtn
            // 
            this.addTypeBtn.Image = global::CiteWrong.Properties.Resources.add;
            this.addTypeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTypeBtn.Name = "addTypeBtn";
            this.addTypeBtn.Size = new System.Drawing.Size(504, 22);
            this.addTypeBtn.Text = "Click here to add a new source type, or double-click the ListBox to edit or remov" +
    "e an existing entry.";
            this.addTypeBtn.Click += new System.EventHandler(this.addTypeBtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 372);
            this.Controls.Add(this.sourceTypes);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form4";
            this.Text = "Source types";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListBox sourceTypes;
        private System.Windows.Forms.ToolStripButton addTypeBtn;
    }
}