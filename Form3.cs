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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        bool newSrc = true;
        private void addButton_Click(object sender, EventArgs e)
        {
            SchemeDefinition schemeNew = new SchemeDefinition();
            schemeNew.title = titleBox.Text;
            schemeNew.syntax = syntaxBox.Text;
            Bibliography.SchemeFormats.Add(schemeNew);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string test = "{Hello}";
            MessageBox.Show(test);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (Bibliography.SchemeFormats.Count() > 0)
            {
                if (UIState.SelectedItem >= 0 && UIState.SelectedItem < Bibliography.SchemeFormats.Count())
                {
                    titleBox.Text = Bibliography.SchemeFormats[UIState.SelectedItem].title;
                    syntaxBox.Text = Bibliography.SchemeFormats[UIState.SelectedItem].syntax;
                    newSrc = false;
                }

            }
            replace.Enabled = !newSrc;
        }

        private void replace_Click(object sender, EventArgs e)
        {
            SchemeDefinition schemeNew = new SchemeDefinition();
            schemeNew.title = titleBox.Text;
            schemeNew.syntax = syntaxBox.Text;
            Bibliography.SchemeFormats[UIState.SelectedItem] = (schemeNew);
            this.Close();
        }
    }
}
