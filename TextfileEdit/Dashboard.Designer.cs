namespace TextfileEdit
{
    partial class DashboardForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDefaultFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winsTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.drawsTxt = new System.Windows.Forms.TextBox();
            this.lossesTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.winBtn = new System.Windows.Forms.Button();
            this.drawBtn = new System.Windows.Forms.Button();
            this.loseBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSaveSimple = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblWinPercent = new System.Windows.Forms.Label();
            this.lblDrawPercent = new System.Windows.Forms.Label();
            this.lblLossPercent = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.minusWinBtn = new System.Windows.Forms.Button();
            this.minusDrawBtn = new System.Windows.Forms.Button();
            this.minusLossBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.txtFilePathTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.changeDefaultFileBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.changeDefaultFileToolStripMenuItem,
            this.changeDefaultFileBoxToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // changeDefaultFileToolStripMenuItem
            // 
            this.changeDefaultFileToolStripMenuItem.Name = "changeDefaultFileToolStripMenuItem";
            this.changeDefaultFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeDefaultFileToolStripMenuItem.Text = "Change default file";
            this.changeDefaultFileToolStripMenuItem.Click += new System.EventHandler(this.changeDefaultFileToolStripMenuItem_Click);
            // 
            // winsTxt
            // 
            this.winsTxt.Location = new System.Drawing.Point(93, 38);
            this.winsTxt.Name = "winsTxt";
            this.winsTxt.Size = new System.Drawing.Size(46, 20);
            this.winsTxt.TabIndex = 3;
            this.winsTxt.TabStop = false;
            this.winsTxt.Text = "0";
            this.winsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.winsTxt.TextChanged += new System.EventHandler(this.winsTxt_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Tiedosto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wins";
            // 
            // drawsTxt
            // 
            this.drawsTxt.Location = new System.Drawing.Point(93, 82);
            this.drawsTxt.Name = "drawsTxt";
            this.drawsTxt.Size = new System.Drawing.Size(46, 20);
            this.drawsTxt.TabIndex = 7;
            this.drawsTxt.TabStop = false;
            this.drawsTxt.Text = "0";
            this.drawsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.drawsTxt.TextChanged += new System.EventHandler(this.drawsTxt_TextChanged);
            // 
            // lossesTxt
            // 
            this.lossesTxt.Location = new System.Drawing.Point(93, 124);
            this.lossesTxt.Name = "lossesTxt";
            this.lossesTxt.Size = new System.Drawing.Size(46, 20);
            this.lossesTxt.TabIndex = 8;
            this.lossesTxt.TabStop = false;
            this.lossesTxt.Text = "0";
            this.lossesTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lossesTxt.TextChanged += new System.EventHandler(this.LossesTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Draws";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Losses";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // winBtn
            // 
            this.winBtn.Font = new System.Drawing.Font("OpenSymbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winBtn.Location = new System.Drawing.Point(163, 35);
            this.winBtn.Name = "winBtn";
            this.winBtn.Size = new System.Drawing.Size(29, 28);
            this.winBtn.TabIndex = 11;
            this.winBtn.Text = "+";
            this.winBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.winBtn.UseVisualStyleBackColor = true;
            this.winBtn.Click += new System.EventHandler(this.winBtn_Click);
            // 
            // drawBtn
            // 
            this.drawBtn.Font = new System.Drawing.Font("OpenSymbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawBtn.Location = new System.Drawing.Point(163, 75);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(29, 28);
            this.drawBtn.TabIndex = 12;
            this.drawBtn.Text = "+";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // loseBtn
            // 
            this.loseBtn.Font = new System.Drawing.Font("OpenSymbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loseBtn.Location = new System.Drawing.Point(163, 116);
            this.loseBtn.Name = "loseBtn";
            this.loseBtn.Size = new System.Drawing.Size(29, 28);
            this.loseBtn.TabIndex = 13;
            this.loseBtn.Text = "+";
            this.loseBtn.UseVisualStyleBackColor = true;
            this.loseBtn.Click += new System.EventHandler(this.loseBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(340, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 109);
            this.textBox1.TabIndex = 14;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "OMG";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(340, 36);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 15;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(443, 191);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 16;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnSaveSimple
            // 
            this.btnSaveSimple.Location = new System.Drawing.Point(340, 191);
            this.btnSaveSimple.Name = "btnSaveSimple";
            this.btnSaveSimple.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSimple.TabIndex = 17;
            this.btnSaveSimple.Text = "Save";
            this.btnSaveSimple.UseVisualStyleBackColor = true;
            this.btnSaveSimple.Click += new System.EventHandler(this.btnSaveSimple_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(93, 169);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(176, 20);
            this.txtFilePath.TabIndex = 18;
            this.txtFilePath.TabStop = false;
            this.txtFilePath.Text = "Choose txtfile";
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            // 
            // lblWinPercent
            // 
            this.lblWinPercent.AutoSize = true;
            this.lblWinPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinPercent.Location = new System.Drawing.Point(241, 35);
            this.lblWinPercent.Name = "lblWinPercent";
            this.lblWinPercent.Size = new System.Drawing.Size(45, 25);
            this.lblWinPercent.TabIndex = 19;
            this.lblWinPercent.Text = "0%";
            this.lblWinPercent.Click += new System.EventHandler(this.lblWinPercent_Click);
            // 
            // lblDrawPercent
            // 
            this.lblDrawPercent.AutoSize = true;
            this.lblDrawPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawPercent.Location = new System.Drawing.Point(241, 76);
            this.lblDrawPercent.Name = "lblDrawPercent";
            this.lblDrawPercent.Size = new System.Drawing.Size(45, 25);
            this.lblDrawPercent.TabIndex = 20;
            this.lblDrawPercent.Text = "0%";
            // 
            // lblLossPercent
            // 
            this.lblLossPercent.AutoSize = true;
            this.lblLossPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLossPercent.Location = new System.Drawing.Point(241, 116);
            this.lblLossPercent.Name = "lblLossPercent";
            this.lblLossPercent.Size = new System.Drawing.Size(45, 25);
            this.lblLossPercent.TabIndex = 21;
            this.lblLossPercent.Text = "0%";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.Location = new System.Drawing.Point(12, 169);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(68, 16);
            this.lblFilePath.TabIndex = 22;
            this.lblFilePath.Text = "File path";
            // 
            // minusWinBtn
            // 
            this.minusWinBtn.Font = new System.Drawing.Font("OpenSymbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusWinBtn.Location = new System.Drawing.Point(198, 35);
            this.minusWinBtn.Name = "minusWinBtn";
            this.minusWinBtn.Size = new System.Drawing.Size(29, 28);
            this.minusWinBtn.TabIndex = 23;
            this.minusWinBtn.Text = "-";
            this.minusWinBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minusWinBtn.UseVisualStyleBackColor = true;
            this.minusWinBtn.Click += new System.EventHandler(this.minusWinBtn_Click);
            // 
            // minusDrawBtn
            // 
            this.minusDrawBtn.Font = new System.Drawing.Font("OpenSymbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusDrawBtn.Location = new System.Drawing.Point(198, 76);
            this.minusDrawBtn.Name = "minusDrawBtn";
            this.minusDrawBtn.Size = new System.Drawing.Size(29, 28);
            this.minusDrawBtn.TabIndex = 24;
            this.minusDrawBtn.Text = "-";
            this.minusDrawBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minusDrawBtn.UseVisualStyleBackColor = true;
            this.minusDrawBtn.Click += new System.EventHandler(this.minusDrawBtn_Click);
            // 
            // minusLossBtn
            // 
            this.minusLossBtn.Font = new System.Drawing.Font("OpenSymbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLossBtn.Location = new System.Drawing.Point(198, 117);
            this.minusLossBtn.Name = "minusLossBtn";
            this.minusLossBtn.Size = new System.Drawing.Size(29, 28);
            this.minusLossBtn.TabIndex = 25;
            this.minusLossBtn.Text = "-";
            this.minusLossBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minusLossBtn.UseVisualStyleBackColor = true;
            this.minusLossBtn.Click += new System.EventHandler(this.minusLossBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(16, 201);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 26;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // txtFilePathTextBox
            // 
            this.txtFilePathTextBox.Location = new System.Drawing.Point(340, 230);
            this.txtFilePathTextBox.Name = "txtFilePathTextBox";
            this.txtFilePathTextBox.Size = new System.Drawing.Size(178, 20);
            this.txtFilePathTextBox.TabIndex = 27;
            this.txtFilePathTextBox.Text = "Choose txtfile";
            this.txtFilePathTextBox.TextChanged += new System.EventHandler(this.txtFilePathTextBox_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(246, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Show %";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // changeDefaultFileBoxToolStripMenuItem
            // 
            this.changeDefaultFileBoxToolStripMenuItem.Name = "changeDefaultFileBoxToolStripMenuItem";
            this.changeDefaultFileBoxToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.changeDefaultFileBoxToolStripMenuItem.Text = "Change default file box";
            this.changeDefaultFileBoxToolStripMenuItem.Click += new System.EventHandler(this.changeDefaultFileBoxToolStripMenuItem_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(567, 325);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtFilePathTextBox);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.minusLossBtn);
            this.Controls.Add(this.minusDrawBtn);
            this.Controls.Add(this.minusWinBtn);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.lblLossPercent);
            this.Controls.Add(this.lblDrawPercent);
            this.Controls.Add(this.lblWinPercent);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnSaveSimple);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.loseBtn);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.winBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lossesTxt);
            this.Controls.Add(this.drawsTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.winsTxt);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardForm";
            this.Text = "Edit score";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardForm_FormClosed);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TextBox winsTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox drawsTxt;
        private System.Windows.Forms.TextBox lossesTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button winBtn;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.Button loseBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnSaveSimple;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.ToolStripMenuItem changeDefaultFileToolStripMenuItem;
        private System.Windows.Forms.Label lblWinPercent;
        private System.Windows.Forms.Label lblDrawPercent;
        private System.Windows.Forms.Label lblLossPercent;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button minusWinBtn;
        private System.Windows.Forms.Button minusDrawBtn;
        private System.Windows.Forms.Button minusLossBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.TextBox txtFilePathTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem changeDefaultFileBoxToolStripMenuItem;
    }
}

