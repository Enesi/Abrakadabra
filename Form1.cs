using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AbrakadabraLib;
using WpfApplication;

namespace Abrakadabra
{
    public partial class Form1 : Form
    {
        List<WordDictionary> currentPhrases;
        WordDictionary currentTextDictionary;

        List<WordDictionary> summirizedPhrases;

        WordDictionary currentDictView;
        
        public Form1()
        {
            InitializeComponent();
            currentTextDictionary = Analyzer.GlobalDictionary;
            currentDictView = Analyzer.GlobalDictionary;
            refreshDictionaryView();
        }

        private void loadTextsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string adress = openFileDialog1.FileName;
                Analyzer.FillDictionary(adress);
            }*/
            Analyzer.FillDictionary(@"D:\ДИПЛОМ\Project\Abrakadabra\TrainingTexts");
        }

        private void chooseTextsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseTextForm form = new ChooseTextForm();
            form.Owner = this;
            form.ShowDialog();
        }

        public void SetCurrentText(List<WordDictionary> cp, WordDictionary ctd)
        {
            currentPhrases = cp;
            currentTextDictionary = ctd;
            richTextBox1.Text = currentTextDictionary.Text;
            currentDictView = ctd;
            refreshDictionaryView();
        }


        private void refreshDictionaryView()
        {
            lbTerms.Items.Clear();
            lbLex.Items.Clear();
            lbBigramms.Items.Clear();
            lbThreegramms.Items.Clear();
            foreach (Term term in currentDictView.Terms)
                lbTerms.Items.Add(term.Content);
        }





        private void lbTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTerms.SelectedIndex != -1)
            {
                lbLex.Items.Clear();
                lbBigramms.Items.Clear();
                lbThreegramms.Items.Clear();
                Term term = currentDictView.Terms[lbTerms.SelectedIndex];
                foreach (Unigramm uni in term.LexicalForms)
                    lbLex.Items.Add(uni.ID + "; встретилось " + uni.Counter + " раз");
            }
        }

        private void lbLex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbLex.SelectedIndex != -1)
            {
                lbBigramms.Items.Clear();
                lbThreegramms.Items.Clear();
                Unigramm uni = currentDictView.Terms[lbTerms.SelectedIndex].LexicalForms[lbLex.SelectedIndex];
                foreach (Ngramm gramm in uni.Childs)
                    lbBigramms.Items.Add(gramm.ID + "; встретилось " + gramm.Counter + " раз");
            }
        }

        private void lbBigramms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbLex.SelectedIndex != -1)
            {
                lbThreegramms.Items.Clear();
                Ngramm gramm = currentDictView.Terms[lbTerms.SelectedIndex].LexicalForms[lbLex.SelectedIndex].Childs[lbBigramms.SelectedIndex];
                foreach (Ngramm threegramm in gramm.Childs)
                    lbThreegramms.Items.Add(threegramm.ID + "; встретилось " + threegramm.Counter + " раз");
            }
        }

        private void btnSummirize_Click(object sender, EventArgs e)
        {
            summirizedPhrases = Analyzer.Summirize(currentPhrases, Analyzer.countTFIDF(currentPhrases, currentTextDictionary), (int)numericUpDown1.Value);
            //этот конвертер фраз во внутреннем формате к стринговому тексту - не здесь должен быть
            String txt = "";
            foreach (WordDictionary phrase in summirizedPhrases)
            {
                txt += phrase.Text;
            }
            richTextBox2.Text = txt;
        }

        private void btnDrawGraphOriginal_Click(object sender, EventArgs e)
        {
            NgrammsGraph graph = currentTextDictionary.Graph; 
            MainWindow window = new MainWindow();
            window.SetGraph(graph);
            window.Show();
        }

        private void btnDrawGraphSumm_Click(object sender, EventArgs e)
        {
            NgrammsGraph graph;
            if (richTextBox2.SelectedText == "")
                graph = currentTextDictionary.DrawGraph(summirizedPhrases);
            else
            {
                TextObject textObj = Analyzer.ParseText(richTextBox2.SelectedText.ToCharArray());
                graph = textObj.Dictionary.DrawGraph();
            }
            MainWindow window = new MainWindow();
            window.SetGraph(graph);
            window.Show();
        }

        private void rbGlobalDict_CheckedChanged_1(object sender, EventArgs e)
        {
            currentDictView = Analyzer.GlobalDictionary;
            refreshDictionaryView();
        }

        private void rbTextDict_CheckedChanged_1(object sender, EventArgs e)
        {
            currentDictView = currentTextDictionary;
            refreshDictionaryView();
        }

     




    
        

    }
}
