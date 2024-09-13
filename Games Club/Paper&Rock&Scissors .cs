using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Games_Club.Properties;
using GamesLibrary;
using static GamesLibrary.clsPaperRockScissors;

namespace Games_Club
{
    public partial class fmPaperRockScissors : Form
    {
        public fmPaperRockScissors()
        {
            InitializeComponent();
        }

        
        private string ToBgr(Color c) => $"{c.B:X2}{c.G:X2}{c.R:X2}";
        

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        const int DWWMA_CAPTION_COLOR = 35;
        const int DWWMA_BORDER_COLOR = 34;
        const int DWMWA_TEXT_COLOR = 36;
        public void CustomWindow(Color captionColor, Color fontColor, Color borderColor, IntPtr handle)
        {
            IntPtr hWnd = handle;
            //Change caption color
            int[] caption = new int[] { int.Parse(ToBgr(captionColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWWMA_CAPTION_COLOR, caption, 4);
            //Change font color
            int[] font = new int[] { int.Parse(ToBgr(fontColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWMWA_TEXT_COLOR, font, 4);
            //Change border color
            int[] border = new int[] { int.Parse(ToBgr(borderColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWWMA_BORDER_COLOR, border, 4);

        }

        

        void ResetPlayPage()
        {
            pbPlayer1.Image = Resources.question;
            pbComputer.Image = Resources.question;

            btnPaper.Enabled = true;
            btnScissors.Enabled = true;
            btnRock.Enabled = true;

            lbDraws.Text = "0";
            lbLoses.Text = "0";
            lbWins.Text = "0";

            lbWinner.Text = "On Progressing";

            lbCurrentRound.Text = "1";
        }

        void ResetPreparePage()
        {
            tbName.Clear();
            nRounds.Value = 1;
        }

        private void fmPaperRockScissors_Load(object sender, EventArgs e)
        {
            CustomWindow(Color.FromArgb(0, 192, 0), Color.FromArgb(51, 51, 51), Color.Green, Handle);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            clsPaperRockScissors.Rounds = (short)nRounds.Value;

            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                tbName.Focus();
                errorProvider1.SetError(tbName, "Name should have a value!");
                return;
            }

            errorProvider1.SetError(tbName, "");
            
            clsPaperRockScissors.Name = tbName.Text.Trim();

            tabControl1.SelectedIndex = 1;

            

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            
            tabControl1.SelectedIndex = 0;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                ResetPreparePage();
                
            }

            if (tabControl1.SelectedIndex == 1)
            {

                ResetPlayPage();
                lbName.Text = clsPaperRockScissors.Name.ToString();
                lbRounds.Text = clsPaperRockScissors.Rounds.ToString();

                

            }
        }

        void ComputerChoice()
        {
            Random random = new Random();

            clsPaperRockScissors.PcChoice = (enChoice)random.Next(1, 4);

            switch (clsPaperRockScissors.PcChoice)
            {

                case enChoice.Rock:
                    {
                        pbComputer.Image = Resources.hand;
                        break;
                    }
                case enChoice.Paper:
                    {
                        pbComputer.Image = Resources.hand_paper;
                        break;
                    }
                case enChoice.Scissors:
                    {
                        pbComputer.Image = Resources.victory;
                        break;
                    }
            }
        }

        void PlayerChoice(object sender)
        {
            if (sender == btnRock)
            {
                pbPlayer1.Image = Resources.hand;
                clsPaperRockScissors.PlayerChoice = enChoice.Rock;
                return;
            }

            if (sender == btnPaper)
            {
                pbPlayer1.Image = Resources.hand_paper;
                clsPaperRockScissors.PlayerChoice = enChoice.Paper;
                return;
            }

            if (sender == btnScissors)
            {
                pbPlayer1.Image = Resources.victory;
                clsPaperRockScissors.PlayerChoice = enChoice.Scissors;
                return;
            }
        }

        void ResultOfRound()
        {
            switch (clsPaperRockScissors.WinnerOfRound())
            {
                case enWinner.Player:
                    {
                        lbWins.Text = (Convert.ToInt16(lbWins.Text) + 1).ToString();
                        break;
                    }
                case enWinner.Computer:
                    {
                        lbLoses.Text = (Convert.ToInt16(lbLoses.Text) + 1).ToString();
                        break;
                    }
                case enWinner.Draw:
                    {
                        lbDraws.Text = (Convert.ToInt16(lbDraws.Text) + 1).ToString();
                        break;
                    }
            }
        }

        void ResultOfGame()
        {
            switch (clsPaperRockScissors.WinnerOfGame
                (Convert.ToInt16(lbWins.Text) , Convert.ToInt16(lbLoses.Text)))
            {
                case enWinner.Player:
                    {
                        lbWinner.Text = lbName.Text;
                        break;
                    }
                case enWinner.Computer:
                    {
                        lbWinner.Text = "Computer";
                        break;
                    }
                case enWinner.Draw:
                    {
                        lbWinner.Text = "Draw";
                        break;
                    }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            
            ComputerChoice();

            PlayerChoice(sender);

            ResultOfRound();

            lbCurrentRound.Text = (Convert.ToInt16(lbCurrentRound.Text) + 1).ToString();

        }

        private void lbCurrentRound_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(lbCurrentRound.Text) > Convert.ToInt16(lbRounds.Text))
            {
                
                lbCurrentRound.Text = (Convert.ToInt16(lbCurrentRound.Text) - 1).ToString();

                ResultOfGame();

                MessageBox.Show("The Winner is: " + lbWinner.Text, "Game End" , MessageBoxButtons.OK , MessageBoxIcon.Information); 

                btnPaper.Enabled = false;
                btnScissors.Enabled = false;
                btnRock.Enabled = false;
            }

        }
    }
}
