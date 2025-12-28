using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CiteWrong
{
    public partial class Form5 : Form
    {
        XmlSerializer xs = new XmlSerializer(typeof(BibSave));
        public enum target { cite, style }
        target tgt;
        BibSave addBib;
        public delegate DualInt DoTaskWithLoadedFile(target tgt);
        DoTaskWithLoadedFile callback;
        
        DualInt OnlyKeepShared(target tgt)
        {
            DualInt retval = new DualInt();
            retval.x = 0; retval.y = 0;
            switch (tgt)
            {
                case target.cite:
                    List<BibliographyEntry> newDat;
                    newDat = addBib.bDatabase;    //////////Can't modify a list while it is being iterated on, so I must create a copy to edit first
                    for (int i = 0; i < addBib.bDatabase.Count; i++)
                    {   // first, check for and remove nondupes
                        BibliographyEntry b = addBib.bDatabase[i];
                        bool found = false;
                        foreach (BibliographyEntry m in Bibliography.bDatabase)
                        { if (m.Equals(b)) { found = true; } }
                        if (!found)
                        { newDat.Remove(b); retval.y++; }
                    }
                    //NOW we can add them
                    Bibliography.bDatabase = newDat; 
                    break;
                case target.style:
                    List<SchemeDefinition> newsch;
                    newsch = addBib.SchemeFormats;
                    for (int i = 0; i < addBib.SchemeFormats.Count; i++)
                    {   // first, check for and remove nondupes 
                        SchemeDefinition b = addBib.SchemeFormats[i];
                        bool found = false;
                        foreach (SchemeDefinition m in Bibliography.SchemeFormats)
                        { if (m.Equals(b)) { found = true; } }
                        if (!found)
                        { newsch.Remove(b); retval.y++; }
                    }
                    //NOW we can add them
                    foreach (SchemeDefinition b in addBib.SchemeFormats)
                    { Bibliography.SchemeFormats = newsch; }
                    break;
                default:
                    
                    retval.x = -1;
                    retval.y = -1;
                    break;
            }
            callback = DoNothing;
            return retval;

        }
        DualInt NeatMerge(target tgt) ///merge the two files but don't keep dupes
        {
            DualInt retval = new DualInt();
            retval.x = 0; retval.y = 0;
            switch (tgt)
            {
                case target.cite:
                    List<BibliographyEntry> newDat = addBib.bDatabase;
                    for (int i=0; i<addBib.bDatabase.Count; i++)
                    {   // first, check for and remove dupes before adding them to main
                        BibliographyEntry b = addBib.bDatabase[i];
                        bool found=false;
                        foreach (BibliographyEntry m in Bibliography.bDatabase)
                        { if (m.Equals(b)) { found = true; } }
                        if (found)
                        { newDat.Remove(b); }
                    }
                    //NOW we can add them
                    foreach (BibliographyEntry b in newDat)
                    { Bibliography.bDatabase.Add(b); retval.x++; }
                    break;
                case target.style:
                    List<SchemeDefinition> newsch = addBib.SchemeFormats;
                    for(int i=0; i<addBib.SchemeFormats.Count; i++) 
                    {   // first, check for and remove dupes before adding them to main
                        SchemeDefinition b = addBib.SchemeFormats[i];
                        bool found=false;
                        foreach (SchemeDefinition m in Bibliography.SchemeFormats)
                        { if (m.Equals(b)) { found = true; } }
                        if (found)
                        { newsch.Remove(b); }
                    }
                    //NOW we can add them
                    foreach (SchemeDefinition b in newsch)
                    { Bibliography.SchemeFormats.Add(b); retval.x++; }
                    break;
                default:
                    retval.x = -1;
                    retval.y = -1;
                    break;
            }
            callback = DoNothing;
            return retval;

        }
        DualInt Cut(target tgt)
        {
            DualInt retval = new DualInt();
            retval.x = 0; retval.y = 0;
            switch (tgt)
            {
                case target.cite:
                    List<BibliographyEntry> newDat;
                    newDat = Bibliography.bDatabase;
                    for (int i = 0; i < addBib.bDatabase.Count; i++)
                    {   // first, check for and remove dupes before adding them to main
                        BibliographyEntry b = addBib.bDatabase[i];
                        foreach (BibliographyEntry m in Bibliography.bDatabase)
                        { if (m.Equals(b)) { newDat.Remove(m); retval.y++; } }
                    }
                    Bibliography.bDatabase = newDat;
                    break;
                case target.style:
                    List<SchemeDefinition> newsch;
                    newsch = Bibliography.SchemeFormats;
                    for (int i = 0; i < addBib.SchemeFormats.Count; i++)
                    {   // first, check for and remove dupes before adding them to main
                        SchemeDefinition b = addBib.SchemeFormats[i];
                        foreach (SchemeDefinition m in Bibliography.SchemeFormats)
                        { if (m.Equals(b)) { newsch.Remove(m); retval.y++; } }
                    }
                    Bibliography.SchemeFormats = newsch;
                    break;
                default:
                    retval.x = -1;
                    retval.y = -1;
                    break;
            }
            callback = DoNothing;
            return retval;
        }



        DualInt DoNothing(target tgt){throw new NotImplementedException();}
        public Form5()
        {
            InitializeComponent();
        }
        private void PopulateAddBib()
        {
 
        }
        private void justRemoveSharedSourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            System.IO.Stream openTarget = openFileDialog1.OpenFile();
            addBib = (BibSave)xs.Deserialize(openTarget);
            openTarget.Close();
            this.Text = openFileDialog1.FileName;
            DualInt retval = callback(tgt);
            MessageBox.Show(retval.x.ToString() + " items added, " + retval.y.ToString() + " items removed.", "Batch operation result");
        }
        private void NeatMergeCButton_Click(object sender, EventArgs e)
        {
            tgt = target.cite;
            callback = NeatMerge;
            openFileDialog1.ShowDialog();
        }
        private void NeatMergeSButton_Click(object sender, EventArgs e)
        {
            tgt = target.style;
            callback = NeatMerge;
            openFileDialog1.ShowDialog();
        }
        private void CutCButton_Click(object sender, EventArgs e)
        {
            tgt = target.cite;
            callback = Cut;
            openFileDialog1.ShowDialog();
        }
        private void CutSButton_Click(object sender, EventArgs e)
        {
            tgt = target.style;
            callback = Cut;
            openFileDialog1.ShowDialog();
        }
        private void KeepDupCButton_Click(object sender, EventArgs e)
        {
            tgt = target.cite;
            callback = OnlyKeepShared;
            openFileDialog1.ShowDialog();
        }
        private void KeepDupSButton_Click(object sender, EventArgs e)
        {
            tgt = target.style;
            callback = OnlyKeepShared;
            openFileDialog1.ShowDialog();
        }
    }
}
