using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AbrakadabraLib;

namespace Abrakadabra
{
    public partial class ChooseTextForm : Form
    {
        public ChooseTextForm()
        {
            InitializeComponent();
            foreach (List<WordDictionary> text in Analyzer.Texts)
            {
                lbTexts.Items.Add(text[0].Text);
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(lbTexts.SelectedIndex!=-1)
                (this.Owner as Form1).SetCurrentText(Analyzer.Texts[lbTexts.SelectedIndex],Analyzer.TextDictionarys[lbTexts.SelectedIndex]);
            this.Close();
        }
    }
}
