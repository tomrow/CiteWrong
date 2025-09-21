namespace CiteWrong
{
    partial class Form2
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
            this.authorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sourceFmt = new System.Windows.Forms.ComboBox();
            this.coAuthorName = new System.Windows.Forms.TextBox();
            this.editionName = new System.Windows.Forms.TextBox();
            this.chapterName = new System.Windows.Forms.TextBox();
            this.sectionName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.workTitle = new System.Windows.Forms.TextBox();
            this.publicationDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fetchDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pageStart = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pageEnd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.publisherName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.originalPublicationDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.seriesName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.volumeName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.mediaFmtName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.retrievalLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.TextBox();
            this.replace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorName
            // 
            this.authorName.Location = new System.Drawing.Point(159, 42);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(286, 20);
            this.authorName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source type";
            // 
            // sourceFmt
            // 
            this.sourceFmt.FormattingEnabled = true;
            this.sourceFmt.Location = new System.Drawing.Point(159, 16);
            this.sourceFmt.MaxDropDownItems = 50;
            this.sourceFmt.Name = "sourceFmt";
            this.sourceFmt.Size = new System.Drawing.Size(121, 21);
            this.sourceFmt.TabIndex = 2;
            // 
            // coAuthorName
            // 
            this.coAuthorName.Location = new System.Drawing.Point(159, 68);
            this.coAuthorName.Name = "coAuthorName";
            this.coAuthorName.Size = new System.Drawing.Size(286, 20);
            this.coAuthorName.TabIndex = 3;
            // 
            // editionName
            // 
            this.editionName.Location = new System.Drawing.Point(159, 291);
            this.editionName.Name = "editionName";
            this.editionName.Size = new System.Drawing.Size(286, 20);
            this.editionName.TabIndex = 5;
            // 
            // chapterName
            // 
            this.chapterName.Location = new System.Drawing.Point(159, 317);
            this.chapterName.Name = "chapterName";
            this.chapterName.Size = new System.Drawing.Size(286, 20);
            this.chapterName.TabIndex = 6;
            // 
            // sectionName
            // 
            this.sectionName.Location = new System.Drawing.Point(159, 343);
            this.sectionName.Name = "sectionName";
            this.sectionName.Size = new System.Drawing.Size(286, 20);
            this.sectionName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Author Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Publication/transmission date";
            // 
            // workTitle
            // 
            this.workTitle.Location = new System.Drawing.Point(159, 187);
            this.workTitle.Name = "workTitle";
            this.workTitle.Size = new System.Drawing.Size(286, 20);
            this.workTitle.TabIndex = 4;
            // 
            // publicationDate
            // 
            this.publicationDate.CustomFormat = "dd MMMM yyyy HH:mm";
            this.publicationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.publicationDate.Location = new System.Drawing.Point(159, 122);
            this.publicationDate.Name = "publicationDate";
            this.publicationDate.Size = new System.Drawing.Size(286, 20);
            this.publicationDate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Name of Work";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Edition/Version";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Chapter";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Section";
            // 
            // fetchDate
            // 
            this.fetchDate.CustomFormat = "dd MMMM yyyy HH:mm";
            this.fetchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fetchDate.Location = new System.Drawing.Point(159, 395);
            this.fetchDate.Name = "fetchDate";
            this.fetchDate.Size = new System.Drawing.Size(286, 20);
            this.fetchDate.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Accessed on";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Page range";
            // 
            // pageStart
            // 
            this.pageStart.Location = new System.Drawing.Point(159, 369);
            this.pageStart.Name = "pageStart";
            this.pageStart.Size = new System.Drawing.Size(128, 20);
            this.pageStart.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 372);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "to";
            // 
            // pageEnd
            // 
            this.pageEnd.Location = new System.Drawing.Point(315, 369);
            this.pageEnd.Name = "pageEnd";
            this.pageEnd.Size = new System.Drawing.Size(130, 20);
            this.pageEnd.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Publisher/Channel/Org";
            // 
            // publisherName
            // 
            this.publisherName.Location = new System.Drawing.Point(159, 94);
            this.publisherName.Name = "publisherName";
            this.publisherName.Size = new System.Drawing.Size(286, 20);
            this.publisherName.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(165, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(236, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "If necessary, use above as last date of exhibition";
            this.label13.Visible = false;
            // 
            // originalPublicationDate
            // 
            this.originalPublicationDate.CustomFormat = "dd MMMM yyyy HH:mm";
            this.originalPublicationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.originalPublicationDate.Location = new System.Drawing.Point(159, 161);
            this.originalPublicationDate.Name = "originalPublicationDate";
            this.originalPublicationDate.Size = new System.Drawing.Size(286, 20);
            this.originalPublicationDate.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Original publication/Xmit date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(76, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Series/Season";
            // 
            // seriesName
            // 
            this.seriesName.Location = new System.Drawing.Point(159, 239);
            this.seriesName.Name = "seriesName";
            this.seriesName.Size = new System.Drawing.Size(286, 20);
            this.seriesName.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 268);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Volume/Episode number";
            // 
            // volumeName
            // 
            this.volumeName.Location = new System.Drawing.Point(159, 265);
            this.volumeName.Name = "volumeName";
            this.volumeName.Size = new System.Drawing.Size(286, 20);
            this.volumeName.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(85, 216);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Media format";
            // 
            // mediaFmtName
            // 
            this.mediaFmtName.Location = new System.Drawing.Point(159, 213);
            this.mediaFmtName.Name = "mediaFmtName";
            this.mediaFmtName.Size = new System.Drawing.Size(286, 20);
            this.mediaFmtName.TabIndex = 33;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(467, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.addButton.Location = new System.Drawing.Point(467, 41);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 35;
            this.addButton.Text = "Add new";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(91, 424);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Available at";
            // 
            // retrievalLocation
            // 
            this.retrievalLocation.Location = new System.Drawing.Point(159, 421);
            this.retrievalLocation.Name = "retrievalLocation";
            this.retrievalLocation.Size = new System.Drawing.Size(286, 20);
            this.retrievalLocation.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "CoAuthor Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(118, 451);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Notes";
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(159, 448);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(383, 20);
            this.notes.TabIndex = 38;
            // 
            // replace
            // 
            this.replace.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.replace.Enabled = false;
            this.replace.Location = new System.Drawing.Point(467, 70);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(75, 23);
            this.replace.TabIndex = 40;
            this.replace.Text = "Replace";
            this.replace.UseVisualStyleBackColor = true;
            this.replace.Click += new System.EventHandler(this.replace_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(558, 474);
            this.Controls.Add(this.replace);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.retrievalLocation);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.mediaFmtName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.volumeName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.seriesName);
            this.Controls.Add(this.originalPublicationDate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.publisherName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pageEnd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pageStart);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fetchDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.publicationDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sectionName);
            this.Controls.Add(this.chapterName);
            this.Controls.Add(this.editionName);
            this.Controls.Add(this.workTitle);
            this.Controls.Add(this.coAuthorName);
            this.Controls.Add(this.sourceFmt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add Source";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox authorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sourceFmt;
        private System.Windows.Forms.TextBox coAuthorName;
        private System.Windows.Forms.TextBox editionName;
        private System.Windows.Forms.TextBox chapterName;
        private System.Windows.Forms.TextBox sectionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox workTitle;
        private System.Windows.Forms.DateTimePicker publicationDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker fetchDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pageStart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox pageEnd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox publisherName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker originalPublicationDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox seriesName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox volumeName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox mediaFmtName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox retrievalLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.Button replace;
    }
}