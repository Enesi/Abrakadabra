namespace Abrakadabra
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
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTextsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseTextsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSummirize = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDrawGraphOriginal = new System.Windows.Forms.Button();
            this.btnDrawGraphSumm = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbThreegramms = new System.Windows.Forms.ListBox();
            this.lbBigramms = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLex = new System.Windows.Forms.ListBox();
            this.lbTerms = new System.Windows.Forms.ListBox();
            this.rbGlobalDict = new System.Windows.Forms.RadioButton();
            this.rbTextDict = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(24, 36);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(911, 322);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTextsToolStripMenuItem,
            this.chooseTextsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // loadTextsToolStripMenuItem
            // 
            this.loadTextsToolStripMenuItem.Name = "loadTextsToolStripMenuItem";
            this.loadTextsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.loadTextsToolStripMenuItem.Text = "Загрузить тексты";
            this.loadTextsToolStripMenuItem.Click += new System.EventHandler(this.loadTextsToolStripMenuItem_Click);
            // 
            // chooseTextsToolStripMenuItem
            // 
            this.chooseTextsToolStripMenuItem.Name = "chooseTextsToolStripMenuItem";
            this.chooseTextsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.chooseTextsToolStripMenuItem.Text = "Выбрать текст";
            this.chooseTextsToolStripMenuItem.Click += new System.EventHandler(this.chooseTextsToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 67);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(399, 248);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(510, 67);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(399, 248);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Исходный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сжатый текст";
            // 
            // btnSummirize
            // 
            this.btnSummirize.Location = new System.Drawing.Point(429, 172);
            this.btnSummirize.Name = "btnSummirize";
            this.btnSummirize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSummirize.Size = new System.Drawing.Size(75, 107);
            this.btnSummirize.TabIndex = 6;
            this.btnSummirize.Text = "===>";
            this.btnSummirize.UseVisualStyleBackColor = true;
            this.btnSummirize.Click += new System.EventHandler(this.btnSummirize_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(429, 136);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Число \r\nпредложений:";
            // 
            // btnDrawGraphOriginal
            // 
            this.btnDrawGraphOriginal.Location = new System.Drawing.Point(24, 322);
            this.btnDrawGraphOriginal.Name = "btnDrawGraphOriginal";
            this.btnDrawGraphOriginal.Size = new System.Drawing.Size(399, 23);
            this.btnDrawGraphOriginal.TabIndex = 9;
            this.btnDrawGraphOriginal.Text = "Нарисовать граф";
            this.btnDrawGraphOriginal.UseVisualStyleBackColor = true;
            this.btnDrawGraphOriginal.Click += new System.EventHandler(this.btnDrawGraphOriginal_Click);
            // 
            // btnDrawGraphSumm
            // 
            this.btnDrawGraphSumm.Location = new System.Drawing.Point(513, 322);
            this.btnDrawGraphSumm.Name = "btnDrawGraphSumm";
            this.btnDrawGraphSumm.Size = new System.Drawing.Size(396, 23);
            this.btnDrawGraphSumm.TabIndex = 10;
            this.btnDrawGraphSumm.Text = "Нарисовать граф";
            this.btnDrawGraphSumm.UseVisualStyleBackColor = true;
            this.btnDrawGraphSumm.Click += new System.EventHandler(this.btnDrawGraphSumm_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(701, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Триграммы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Биграммы";
            // 
            // lbThreegramms
            // 
            this.lbThreegramms.FormattingEnabled = true;
            this.lbThreegramms.Location = new System.Drawing.Point(704, 443);
            this.lbThreegramms.Name = "lbThreegramms";
            this.lbThreegramms.Size = new System.Drawing.Size(188, 251);
            this.lbThreegramms.TabIndex = 16;
            // 
            // lbBigramms
            // 
            this.lbBigramms.FormattingEnabled = true;
            this.lbBigramms.Location = new System.Drawing.Point(476, 443);
            this.lbBigramms.Name = "lbBigramms";
            this.lbBigramms.Size = new System.Drawing.Size(188, 251);
            this.lbBigramms.TabIndex = 15;
            this.lbBigramms.SelectedIndexChanged += new System.EventHandler(this.lbBigramms_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Словоформы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Термин";
            // 
            // lbLex
            // 
            this.lbLex.FormattingEnabled = true;
            this.lbLex.Location = new System.Drawing.Point(251, 443);
            this.lbLex.Name = "lbLex";
            this.lbLex.Size = new System.Drawing.Size(188, 251);
            this.lbLex.TabIndex = 12;
            this.lbLex.SelectedIndexChanged += new System.EventHandler(this.lbLex_SelectedIndexChanged);
            // 
            // lbTerms
            // 
            this.lbTerms.FormattingEnabled = true;
            this.lbTerms.Location = new System.Drawing.Point(33, 443);
            this.lbTerms.Name = "lbTerms";
            this.lbTerms.Size = new System.Drawing.Size(188, 251);
            this.lbTerms.TabIndex = 11;
            this.lbTerms.SelectedIndexChanged += new System.EventHandler(this.lbTerms_SelectedIndexChanged);
            // 
            // rbGlobalDict
            // 
            this.rbGlobalDict.AutoSize = true;
            this.rbGlobalDict.Checked = true;
            this.rbGlobalDict.Location = new System.Drawing.Point(6, 16);
            this.rbGlobalDict.Name = "rbGlobalDict";
            this.rbGlobalDict.Size = new System.Drawing.Size(104, 17);
            this.rbGlobalDict.TabIndex = 19;
            this.rbGlobalDict.TabStop = true;
            this.rbGlobalDict.Text = "Словарь общий";
            this.rbGlobalDict.UseVisualStyleBackColor = true;
            this.rbGlobalDict.CheckedChanged += new System.EventHandler(this.rbGlobalDict_CheckedChanged_1);
            // 
            // rbTextDict
            // 
            this.rbTextDict.AutoSize = true;
            this.rbTextDict.Location = new System.Drawing.Point(145, 16);
            this.rbTextDict.Name = "rbTextDict";
            this.rbTextDict.Size = new System.Drawing.Size(105, 17);
            this.rbTextDict.TabIndex = 20;
            this.rbTextDict.Text = "Словарь текста";
            this.rbTextDict.UseVisualStyleBackColor = true;
            this.rbTextDict.CheckedChanged += new System.EventHandler(this.rbTextDict_CheckedChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGlobalDict);
            this.groupBox1.Controls.Add(this.rbTextDict);
            this.groupBox1.Location = new System.Drawing.Point(24, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 39);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 717);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbThreegramms);
            this.Controls.Add(this.lbBigramms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbLex);
            this.Controls.Add(this.lbTerms);
            this.Controls.Add(this.btnDrawGraphSumm);
            this.Controls.Add(this.btnDrawGraphOriginal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnSummirize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTextsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseTextsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSummirize;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDrawGraphOriginal;
        private System.Windows.Forms.Button btnDrawGraphSumm;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbThreegramms;
        private System.Windows.Forms.ListBox lbBigramms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbLex;
        private System.Windows.Forms.ListBox lbTerms;
        private System.Windows.Forms.RadioButton rbGlobalDict;
        private System.Windows.Forms.RadioButton rbTextDict;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

