using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Games_Club
{
    public partial class fmGamesClub : Form
    {
        public fmGamesClub()
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


        private void Maze_Click(object sender, EventArgs e)
        {
            this.Hide();

            fmMaze Play = new fmMaze();
            Play.ShowDialog();

            Play = null;

            this.Show();
        }

        private void PaperRockScissors_Click(object sender, EventArgs e)
        {
            this.Hide();

            fmPaperRockScissors Play = new fmPaperRockScissors();
            Play.ShowDialog();

            Play = null;

            this.Show();
        }

        private void fmGamesClub_Load(object sender, EventArgs e)
        {
            CustomWindow(Color.FromArgb(0, 192, 0), Color.FromArgb(51, 51, 51), Color.Green, Handle);

        }

        private void fmGamesClub_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void WordsOfWonders_Click(object sender, EventArgs e)
        {
            this.Hide();

            fmWordsOfWonders Play = new fmWordsOfWonders();
            Play.ShowDialog();

            Play = null;

            this.Show();
        }
    }
}
