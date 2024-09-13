using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games_Club
{
    public partial class fmMaze : Form
    {
        public fmMaze()
        {
            InitializeComponent();
            MoveToStart();
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

        private void fmMaze_Load(object sender, EventArgs e)
        {
            CustomWindow(Color.FromArgb(0, 192, 0), Color.FromArgb(51, 51, 51), Color.Green, Handle);

        }

        private void lbFinish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Game Ends" , "Success" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void MoveToStart()
        {
            Point Start = guna2Panel1.Location;

            Start.Offset(10, 15);

            Cursor.Position = PointToScreen(Start);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {

            MessageBox.Show("Game Over", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MoveToStart();
        }
    }
}
