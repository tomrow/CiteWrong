using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CiteWrong
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        bool newSrc = true;
        private void Form2_Load(object sender, EventArgs e)
        {
            if (Bibliography.SchemeFormats.Count() > 0)
            {
                foreach (SchemeDefinition sd in Bibliography.SchemeFormats)
                {
                    if (sd.title.Substring(sd.title.Length - 1) != "$")
                    { sourceFmt.Items.Add(sd.title); }
                }
                BibliographyEntry BibSel = new BibliographyEntry();
                if (UIState.SelectedItem >= 0 && UIState.SelectedItem < Bibliography.bDatabase.Count())
                {
                    BibSel = Bibliography.bDatabase[UIState.SelectedItem];
                    newSrc = false;
                    authorName.Text = BibSel.authorName;
                    chapterName.Text = BibSel.chapterName;
                    coAuthorName.Text = BibSel.coAuthorName;
                    editionName.Text = BibSel.editionName;
                    fetchDate.Value = BibSel.fetchDate;
                    mediaFmtName.Text = BibSel.mediaFmtName;
                    notes.Text = BibSel.notes;
                    originalPublicationDate.Value = BibSel.originalPublicationDate;
                    pageEnd.Text = BibSel.pageEnd;
                    pageStart.Text = BibSel.pageStart;
                    publicationDate.Value = BibSel.publicationDate;
                    publisherName.Text = BibSel.publisherName;
                    retrievalLocation.Text = BibSel.retrievalLocation;
                    sectionName.Text = BibSel.sectionName;
                    seriesName.Text = BibSel.seriesName;
                    sourceFmt.Text = BibSel.sourceFmt;
                    volumeName.Text = BibSel.volumeName;
                    workTitle.Text = BibSel.workTitle;
                }
                
            }
            replace.Enabled = !newSrc;
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            BibliographyEntry newEntry = new BibliographyEntry();
            newEntry.authorName = authorName.Text;
            newEntry.chapterName = chapterName.Text;
            newEntry.coAuthorName = coAuthorName.Text;
            newEntry.editionName = editionName.Text;
            newEntry.fetchDate = fetchDate.Value;
            newEntry.mediaFmtName = mediaFmtName.Text;
            newEntry.notes = notes.Text;
            newEntry.originalPublicationDate = originalPublicationDate.Value;
            newEntry.pageEnd = pageEnd.Text;
            newEntry.pageStart = pageStart.Text;
            newEntry.publicationDate = publicationDate.Value;
            newEntry.publisherName = publisherName.Text;
            newEntry.retrievalLocation = retrievalLocation.Text;
            newEntry.sectionName = sectionName.Text;
            newEntry.seriesName = seriesName.Text;
            newEntry.sourceFmt = sourceFmt.Text;
            newEntry.volumeName = volumeName.Text;
            newEntry.workTitle = workTitle.Text;
            Bibliography.bDatabase.Add(newEntry);
            MessageBox.Show(newEntry.ToString());
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void replace_Click(object sender, EventArgs e)
        {
            BibliographyEntry newEntry = new BibliographyEntry();
            newEntry.authorName = authorName.Text;
            newEntry.chapterName = chapterName.Text;
            newEntry.coAuthorName = coAuthorName.Text;
            newEntry.editionName = editionName.Text;
            newEntry.fetchDate = fetchDate.Value;
            newEntry.mediaFmtName = mediaFmtName.Text;
            newEntry.notes = notes.Text;
            newEntry.originalPublicationDate = originalPublicationDate.Value;
            newEntry.pageEnd = pageEnd.Text;
            newEntry.pageStart = pageStart.Text;
            newEntry.publicationDate = publicationDate.Value;
            newEntry.publisherName = publisherName.Text;
            newEntry.retrievalLocation = retrievalLocation.Text;
            newEntry.sectionName = sectionName.Text;
            newEntry.seriesName = seriesName.Text;
            newEntry.sourceFmt = sourceFmt.Text;
            newEntry.volumeName = volumeName.Text;
            newEntry.workTitle = workTitle.Text;
            Bibliography.bDatabase[UIState.SelectedItem] = (newEntry);
            MessageBox.Show(newEntry.ToString());
            this.Close();
        }


    }
}
