namespace wiezien
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszLogDoPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersTextBox = new System.Windows.Forms.TextBox();
            this.gamesTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.programLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roundsTextBox = new System.Windows.Forms.TextBox();
            this.pointsBox = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.playersToShowBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bestWorstComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.betterWorseComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.commitButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.automaticCheckBox = new System.Windows.Forms.CheckBox();
            this.automaticTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ilość graczy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ilość gier:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszLogDoPlikuToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszLogDoPlikuToolStripMenuItem
            // 
            this.zapiszLogDoPlikuToolStripMenuItem.Name = "zapiszLogDoPlikuToolStripMenuItem";
            this.zapiszLogDoPlikuToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.zapiszLogDoPlikuToolStripMenuItem.Text = "Zapisz log do pliku...";
            this.zapiszLogDoPlikuToolStripMenuItem.Click += new System.EventHandler(this.zapiszLogDoPlikuToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // playersTextBox
            // 
            this.playersTextBox.Location = new System.Drawing.Point(84, 41);
            this.playersTextBox.Name = "playersTextBox";
            this.playersTextBox.Size = new System.Drawing.Size(62, 20);
            this.playersTextBox.TabIndex = 3;
            this.playersTextBox.Text = "1000";
            // 
            // gamesTextBox
            // 
            this.gamesTextBox.Location = new System.Drawing.Point(224, 41);
            this.gamesTextBox.Name = "gamesTextBox";
            this.gamesTextBox.Size = new System.Drawing.Size(62, 20);
            this.gamesTextBox.TabIndex = 4;
            this.gamesTextBox.Text = "1000";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(458, 37);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(192, 26);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // programLog
            // 
            this.programLog.Location = new System.Drawing.Point(9, 69);
            this.programLog.Multiline = true;
            this.programLog.Name = "programLog";
            this.programLog.ReadOnly = true;
            this.programLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.programLog.Size = new System.Drawing.Size(641, 151);
            this.programLog.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rund/grę";
            // 
            // roundsTextBox
            // 
            this.roundsTextBox.Location = new System.Drawing.Point(352, 41);
            this.roundsTextBox.Name = "roundsTextBox";
            this.roundsTextBox.Size = new System.Drawing.Size(37, 20);
            this.roundsTextBox.TabIndex = 9;
            this.roundsTextBox.Text = "15";
            // 
            // pointsBox
            // 
            this.pointsBox.Enabled = false;
            this.pointsBox.Location = new System.Drawing.Point(263, 226);
            this.pointsBox.Name = "pointsBox";
            this.pointsBox.Size = new System.Drawing.Size(45, 20);
            this.pointsBox.TabIndex = 11;
            this.pointsBox.Text = "3,0";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(12, 226);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(155, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Wyświetl graczy z wynikiem";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(12, 249);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.Text = "Wyświetl ";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // playersToShowBox
            // 
            this.playersToShowBox.Enabled = false;
            this.playersToShowBox.Location = new System.Drawing.Point(84, 248);
            this.playersToShowBox.Name = "playersToShowBox";
            this.playersToShowBox.Size = new System.Drawing.Size(44, 20);
            this.playersToShowBox.TabIndex = 14;
            this.playersToShowBox.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "graczy z";
            // 
            // bestWorstComboBox
            // 
            this.bestWorstComboBox.Enabled = false;
            this.bestWorstComboBox.FormattingEnabled = true;
            this.bestWorstComboBox.Items.AddRange(new object[] {
            "najlepszym",
            "najgorszym"});
            this.bestWorstComboBox.Location = new System.Drawing.Point(186, 248);
            this.bestWorstComboBox.Name = "bestWorstComboBox";
            this.bestWorstComboBox.Size = new System.Drawing.Size(122, 21);
            this.bestWorstComboBox.TabIndex = 16;
            this.bestWorstComboBox.Text = "najlepszym";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "punktów.";
            // 
            // betterWorseComboBox
            // 
            this.betterWorseComboBox.Enabled = false;
            this.betterWorseComboBox.FormattingEnabled = true;
            this.betterWorseComboBox.Items.AddRange(new object[] {
            "zbliżonym do",
            "lepszym niż",
            "gorszym niż"});
            this.betterWorseComboBox.Location = new System.Drawing.Point(166, 225);
            this.betterWorseComboBox.Name = "betterWorseComboBox";
            this.betterWorseComboBox.Size = new System.Drawing.Size(91, 21);
            this.betterWorseComboBox.TabIndex = 18;
            this.betterWorseComboBox.Text = "zbliżonym do";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "wynikiem.";
            // 
            // commitButton
            // 
            this.commitButton.Enabled = false;
            this.commitButton.Location = new System.Drawing.Point(381, 230);
            this.commitButton.Name = "commitButton";
            this.commitButton.Size = new System.Drawing.Size(269, 33);
            this.commitButton.TabIndex = 20;
            this.commitButton.Text = "Wykonaj";
            this.commitButton.UseVisualStyleBackColor = true;
            this.commitButton.Click += new System.EventHandler(this.commitButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Enabled = false;
            this.continueButton.Location = new System.Drawing.Point(375, 5);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(269, 21);
            this.continueButton.TabIndex = 7;
            this.continueButton.Text = "Kontynuuj";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // automaticCheckBox
            // 
            this.automaticCheckBox.AutoSize = true;
            this.automaticCheckBox.Location = new System.Drawing.Point(9, 8);
            this.automaticCheckBox.Name = "automaticCheckBox";
            this.automaticCheckBox.Size = new System.Drawing.Size(139, 17);
            this.automaticCheckBox.TabIndex = 21;
            this.automaticCheckBox.Text = "Rozegraj automatycznie";
            this.automaticCheckBox.UseVisualStyleBackColor = true;
            // 
            // automaticTextBox
            // 
            this.automaticTextBox.Location = new System.Drawing.Point(149, 6);
            this.automaticTextBox.Name = "automaticTextBox";
            this.automaticTextBox.Size = new System.Drawing.Size(65, 20);
            this.automaticTextBox.TabIndex = 22;
            this.automaticTextBox.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "gier.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.automaticTextBox);
            this.panel1.Controls.Add(this.automaticCheckBox);
            this.panel1.Controls.Add(this.continueButton);
            this.panel1.Location = new System.Drawing.Point(6, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 35);
            this.panel1.TabIndex = 24;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.txt";
            this.saveFileDialog1.FileName = "log.txt";
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 312);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.commitButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.betterWorseComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bestWorstComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.playersToShowBox);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pointsBox);
            this.Controls.Add(this.roundsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.programLog);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.gamesTextBox);
            this.Controls.Add(this.playersTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Dylemat Więźnia v0.9 RC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.TextBox playersTextBox;
        private System.Windows.Forms.TextBox gamesTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox programLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roundsTextBox;
        private System.Windows.Forms.TextBox pointsBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox playersToShowBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox bestWorstComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox betterWorseComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button commitButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.CheckBox automaticCheckBox;
        private System.Windows.Forms.TextBox automaticTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem zapiszLogDoPlikuToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

