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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
        private void RefreshListView()
        {
            sourceTypes.Items.Clear();
            for (int i = 0; i < Bibliography.SchemeFormats.Count; i++)
            { sourceTypes.Items.Add(Bibliography.SchemeFormats[i].title); }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            RefreshListView();
        }
        private void OpenSourceEditor()
        {
            Form3 wizard = new Form3();
            wizard.ShowDialog();
            RefreshListView();
        }

        private void addTypeBtn_Click(object sender, EventArgs e)
        {
            UIState.SelectedItem = -1;
            OpenSourceEditor();
        }

        private void sourceTypes_DoubleClick(object sender, EventArgs e)
        {
            UIState.SelectedItem = sourceTypes.SelectedIndex;
            OpenSourceEditor();
        }
    }
}
