using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TextfileEdit
{
    public partial class DashboardForm : Form
    {
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(String sClassName, String sAppName);
        

        private IntPtr thisWindow;
        private Hotkey hotkey;

        public int wins = 0;
        public int draws = 0;
        public int losses = 0;
        public int winPerc = 0;
        public int drawPerc = 0;
        public int lossPerc = 0;
        public int winPercWDraw = 0;

        public string filePath;

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            filePath = Properties.Settings.Default.DefaultFilePath;
            txtFilePath.Text = filePath;

            //thisWindow = FindWindow(null, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
            thisWindow = FindWindow(null, "Edit score");
            hotkey = new Hotkey(thisWindow);
            hotkey.RegisterHotKeys();
            
        }
       

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                filePath = openFD.FileName;
                txtFilePath.Text = openFD.FileName;
            }
            //openFileDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpleSave();
            MessageBox.Show("Saved!");
        }

        private void winsTxt_TextChanged(object sender, EventArgs e)
        {
            if(winsTxt.Text == "")
            {
                winsTxt.Text = "0";
            }
            wins = Convert.ToInt32(winsTxt.Text);
            UpdatePercentLabels();
            
        }

        private void winBtn_Click(object sender, EventArgs e)
        {
            wins = 1 + wins;
            winsTxt.Text = wins.ToString();
            UpdatePercentLabels();
            SimpleSave();
            //this.Refresh();
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            
            draws = 1 + draws;
            drawsTxt.Text = draws.ToString();
            UpdatePercentLabels();
            SimpleSave();
        }

        private void loseBtn_Click(object sender, EventArgs e)
        {
            
            losses = 1 + losses;
            lossesTxt.Text = losses.ToString();
            UpdatePercentLabels();
            SimpleSave();

        }

        private void drawsTxt_TextChanged(object sender, EventArgs e)
        {
            if (drawsTxt.Text == "")
            {
                drawsTxt.Text = "0";
            }
            draws = Convert.ToInt32(drawsTxt.Text);
            UpdatePercentLabels();
        }

        private void LossesTxt_TextChanged(object sender, EventArgs e)
        {
            if (lossesTxt.Text == "")
            {
                lossesTxt.Text = "0";
            }
            losses = Convert.ToInt32(lossesTxt.Text);
            UpdatePercentLabels();
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            ReadFromTextFile();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveToTextFile();
        }
        private async void SaveToTextFile()
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        await sw.WriteLineAsync(textBox1.Text);
                       // MessageBox.Show("You have been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private async void ReadFromTextFile()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        textBox1.Text = await sr.ReadToEndAsync();
                    }
                }
            }
        }

        private void btnSaveSimple_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter(filePath);
            txt.Write(textBox1.Text);
            txt.Close();
        }
        private void SimpleSave()
        {
            try
            {
                TextWriter txt = new StreamWriter(filePath);
                if (draws == 0)
                    txt.Write("W-" + wins + "   " + winPerc + "%" + "\r\n" + "L-" + losses);
                else
                    txt.Write("W-" + wins + "   " + winPercWDraw + "%" + "\r\n" + "D-" + draws + "\r\n" + "L-" + losses);
                txt.Close();
            }
            catch(DirectoryNotFoundException dirEx)
            {
                MessageBox.Show("Filepath not found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {
            filePath = txtFilePath.Text;
        }

        private void changeDefaultFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();

            if (openFD.ShowDialog() == DialogResult.OK)
            {
                filePath = openFD.FileName;
                txtFilePath.Text = openFD.FileName;
                Properties.Settings.Default.DefaultFilePath = openFD.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void lblWinPercent_Click(object sender, EventArgs e)
        {

        }
        private void UpdatePercentLabels()
        {
            CalcPercentage();
            lblWinPercent.Text = winPerc.ToString() + "%";
            lblDrawPercent.Text = drawPerc.ToString() + "%";
            lblLossPercent.Text = lossPerc.ToString() + "%";
        }
        public void CalcPercentage()
        {
            if(wins == 0 && draws == 0 && losses == 0)
            {
                winPerc = 0;
                drawPerc = 0;
                lossPerc = 0;
            }
            else
            {
                winPerc = (int)(((double)wins / (wins + draws + losses)) * 100);
                drawPerc = (int)(((double)draws / (wins + draws + losses)) * 100);
                lossPerc = (int)(((double)losses / (wins + draws + losses)) * 100);
                winPercWDraw = (int)(((double)losses / (wins + losses)) * 100);
            }
            
            //return winPerc;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetScores();
        }

        private void minusWinBtn_Click(object sender, EventArgs e)
        {
            wins = wins - 1;
            winsTxt.Text = wins.ToString();
            UpdatePercentLabels();
            SimpleSave();
        }

        private void minusDrawBtn_Click(object sender, EventArgs e)
        {
            draws = draws - 1;
            drawsTxt.Text= draws.ToString();
            UpdatePercentLabels();
            SimpleSave();
        }

        private void minusLossBtn_Click(object sender, EventArgs e)
        {
            losses = losses - 1;
            lossesTxt.Text = losses.ToString();
            UpdatePercentLabels();
            SimpleSave();
        }
        private void ResetScores()
        {
            wins = 0;
            draws = 0;
            losses = 0;

            winsTxt.Text = wins.ToString();
            drawsTxt.Text = draws.ToString();
            lossesTxt.Text = losses.ToString();

            SimpleSave();
        }
        /*
        private void DashboardForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString() == "NumPad0")
            {
                ResetScores();
            }
            if (e.Control && e.KeyCode.ToString() == "A")
            {
                wins = 1 + wins;
                winsTxt.Text = wins.ToString();
                UpdatePercentLabels();
                SimpleSave();
            }
            if (e.KeyCode.ToString() == "NumPad2")
            {
                draws = 1 + draws;
                drawsTxt.Text = draws.ToString();
                UpdatePercentLabels();
                SimpleSave();
            }
            if (e.KeyCode.ToString() == "NumPad3")
            {
                losses = 1 + losses;
                lossesTxt.Text = losses.ToString();
                UpdatePercentLabels();
                SimpleSave();
            }
        }
        */
        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            hotkey.UnRegisterHotKeys();
        }

        protected override void WndProc(ref Message keyPressed)
        {
            if( keyPressed.Msg == 0x0312 && keyPressed.WParam.ToInt32() == 1)
            {
                AddWin();
            }
            if( keyPressed.Msg == 0x0312 && keyPressed.WParam.ToInt32() == 2)
            {
                AddDraw();
            }
            if (keyPressed.Msg == 0x0312 && keyPressed.WParam.ToInt32() == 3)
            {
                AddLoss();
            }

            if (keyPressed.Msg == 0x0312 && keyPressed.WParam.ToInt32() == 4)
            {
                SubtracWin();
            }
            if (keyPressed.Msg == 0x0312 && keyPressed.WParam.ToInt32() == 5)
            {
                SubtracDraw();
            }
            if (keyPressed.Msg == 0x0312 && keyPressed.WParam.ToInt32() == 6)
            {
                SubtracLoss();
            }
            base.WndProc(ref keyPressed);
        }
        private void AddWin()
        {
            wins = 1 + wins;
            winsTxt.Text = wins.ToString();
            UpdatePercentLabels();
            SimpleSave();
        }
        private void AddDraw()
        {
            draws = 1 + draws;
            drawsTxt.Text = draws.ToString();
            UpdatePercentLabels();
            SimpleSave();
        }
        private void AddLoss()
        {
            losses = 1 + losses;
            lossesTxt.Text = losses.ToString();
            UpdatePercentLabels();
            SimpleSave();
        }
        private void SubtracWin()
        {
            wins = wins - 1;
            winsTxt.Text = wins.ToString();
            UpdatePercentLabels();
            SimpleSave();
        }
        private void SubtracDraw()
        {
            draws = draws - 1;
            drawsTxt.Text = draws.ToString();
            UpdatePercentLabels();
            SimpleSave();
        }
        private void SubtracLoss()
        {
            losses = losses - 1;
            lossesTxt.Text = losses.ToString();
            UpdatePercentLabels();
            SimpleSave();
        }
    }
}
