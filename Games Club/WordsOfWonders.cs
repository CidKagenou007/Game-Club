using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Games_Library;

namespace Games_Club
{
    public partial class fmWordsOfWonders : Form
    {
        public fmWordsOfWonders()
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

        private void fmWordsOfWonders_Load(object sender, EventArgs e)
        {

            CustomWindow(Color.FromArgb(89, 158, 113), Color.FromArgb(51, 51, 51), Color.FromArgb(89, 158, 113), Handle);
            tabControl1.SelectedIndex = 0;


        }

        void Reset(Guna.UI2.WinForms.Guna2ImageButton Btn1, Guna.UI2.WinForms.Guna2ImageButton Btn2,
            Guna.UI2.WinForms.Guna2ImageButton Btn3, Label lbW)
        {
            Btn1.Enabled = true;
            Btn2.Enabled = true;
            Btn3.Enabled = true;

            lbW.Text = string.Empty;
        }

        void Reset(Guna.UI2.WinForms.Guna2ImageButton Btn1, Guna.UI2.WinForms.Guna2ImageButton Btn2,
            Guna.UI2.WinForms.Guna2ImageButton Btn3, Label lbW, Label lb1, Label lb2, Label lb3, Label lb4, Label lb5)
        {
            Reset(Btn1, Btn2, Btn3, lbW);


            lb1.Text = string.Empty;
            lb2.Text = string.Empty;
            lb3.Text = string.Empty;
            lb4.Text = string.Empty;
            lb5.Text = string.Empty;
        }

        void SelectBtn(object sender, Guna.UI2.WinForms.Guna2ImageButton Btn1, Guna.UI2.WinForms.Guna2ImageButton Btn2,
            Guna.UI2.WinForms.Guna2ImageButton Btn3 , Label Word)
        {
            if (sender == Btn1)
            {
                Word.Text += Btn1.Tag;
                Btn1.Enabled = false;
                return;
            }

            if (sender == Btn2)
            {
                Word.Text += Btn2.Tag;
                Btn2.Enabled = false;
                return;
            }

            if (sender == Btn3)
            {
                Word.Text += Btn3.Tag;
                Btn3.Enabled = false;
                return;
            }
        }

        bool AreAllCharactersUsed(Guna.UI2.WinForms.Guna2ImageButton Btn1, Guna.UI2.WinForms.Guna2ImageButton Btn2,
            Guna.UI2.WinForms.Guna2ImageButton Btn3)
        {
            return !(Btn1.Enabled || Btn2.Enabled || Btn3.Enabled);
        }

        bool IsWordsCorrect(string Word, int Index)
        {
            return clsWordsOfWonders.IsCorrect(Word, Index);
        }

        void AddWord(string Word, int Index, Label lb1, Label lb2, Label lb3, Label lb4, Label lb5)
        {


            switch (Index)
            {
                case 0:
                    {
                        switch (clsWordsOfWonders.Check(Word, Index))
                        {
                            case clsWordsOfWonders.enWordIndex.First:
                                {
                                    lb2.Text = Word[0].ToString();
                                    lb4.Text = Word[1].ToString();
                                    lb5.Text = Word[2].ToString();
                                    break;
                                }
                            case clsWordsOfWonders.enWordIndex.Second:
                                {
                                    lb1.Text = Word[0].ToString();
                                    lb2.Text = Word[1].ToString();
                                    lb3.Text = Word[2].ToString();
                                    break;
                                }
                        }
                        break;

                    }
                case 1:
                    {
                        switch (clsWordsOfWonders.Check(Word, Index))
                        {
                            case clsWordsOfWonders.enWordIndex.First:
                                {
                                    lb2.Text = Word[0].ToString();
                                    lb4.Text = Word[1].ToString();
                                    lb5.Text = Word[2].ToString();
                                    break;
                                }
                            case clsWordsOfWonders.enWordIndex.Second:
                                {
                                    lb1.Text = Word[0].ToString();
                                    lb2.Text = Word[1].ToString();
                                    lb3.Text = Word[2].ToString();
                                    break;
                                }
                        }
                        break;

                    }
                case 2:
                    {
                        switch (clsWordsOfWonders.Check(Word, Index))
                        {
                            case clsWordsOfWonders.enWordIndex.First:
                                {
                                    lb5.Text = Word[0].ToString();
                                    lb2.Text = Word[1].ToString();
                                    lb4.Text = Word[2].ToString();
                                    break;
                                }
                            case clsWordsOfWonders.enWordIndex.Second:
                                {
                                    lb1.Text = Word[0].ToString();
                                    lb2.Text = Word[1].ToString();
                                    lb3.Text = Word[2].ToString();
                                    break;
                                }
                        }
                        break;

                    }
                case 3:
                    {
                        switch (clsWordsOfWonders.Check(Word, Index))
                        {
                            case clsWordsOfWonders.enWordIndex.First:
                                {
                                    lb2.Text = Word[0].ToString();
                                    lb4.Text = Word[1].ToString();
                                    lb5.Text = Word[2].ToString();
                                    break;
                                }
                            case clsWordsOfWonders.enWordIndex.Second:
                                {
                                    lb1.Text = Word[0].ToString();
                                    lb2.Text = Word[1].ToString();
                                    lb3.Text = Word[2].ToString();
                                    break;
                                }
                        }
                        break;

                    }
            }
        }

        bool IsLvlEnd(Label lb1, Label lb2, Label lb3, Label lb4, Label lb5)
        {
            return (lb1.Text != string.Empty && lb2.Text != string.Empty && lb3.Text != string.Empty &&
                lb4.Text != string.Empty && lb5.Text != string.Empty);


        }

        void PrintFailedMessage(string message)
        {
            MessageBox.Show(message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        bool IsGameEnd(int Lvl)
        {
            return Lvl == 3;
        }
        void Check(int Lvl, Guna.UI2.WinForms.Guna2ImageButton Btn1, Guna.UI2.WinForms.Guna2ImageButton Btn2,
            Guna.UI2.WinForms.Guna2ImageButton Btn3, Label lbW, Label lb1, Label lb2, Label lb3, Label lb4, Label lb5)
        {
            if (!(AreAllCharactersUsed(Btn1, Btn2, Btn3)))
            {
                PrintFailedMessage("You are'nt use all characters");
                return;
            }

            if (!IsWordsCorrect(lbW.Text, Lvl))
            {
                PrintFailedMessage("Wrong Word");
                return;
            }

            AddWord(lbW.Text, Lvl, lb1, lb2, lb3, lb4, lb5);

            if (IsLvlEnd(lb1, lb2, lb3, lb4, lb5))
            {
                MessageBox.Show("Lvl " + (Lvl + 1) + " Passed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset(Btn1, Btn2, Btn3, lbW, lb1, lb2, lb3, lb4, lb5);
                
                if (IsGameEnd(Lvl))
                {
                    MessageBox.Show("The Game Ends", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControl1.SelectedIndex = 0;

                }

                else
                {
                    tabControl1.SelectedIndex++;
                }

                
                return;

            }

            Reset(Btn1, Btn2, Btn3, lbW);
        }

        private void btnWords_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        SelectBtn(sender, L0btnT, L0btnC, L0btnA , L0lbWord);
                        break;
                    }
                case 1:
                    {
                        SelectBtn(sender, L1btnT, L1btnR, L1btnA, L1lbWord);
                        break;
                    }
                case 2:
                    {
                        SelectBtn(sender, L2btnT, L2btnN, L2btnE, L2lbWord);
                        break;
                    }
                case 3:
                    {
                        SelectBtn(sender, L3btnW, L3btnN, L3btnO, L3lbWord);
                        break;
                    }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {

                        Check(0, L0btnA, L0btnT, L0btnC, L0lbWord, L0lb1, L0lb2, L0lb3, L0lb4, L0lb5);
                        break;
                    }
                case 1:
                    {
                        Check(1, L1btnA, L1btnT, L1btnR, L1lbWord, L1lb1, L1lb2, L1lb3, L1lb4, L1lb5);
                        break;
                    }
                case 2:
                    {
                        Check(2, L2btnT, L2btnN, L2btnE, L2lbWord, L2lb1, L2lb2, L2lb3, L2lb4, L2lb5);
                        break;
                    }
                case 3:
                    {
                        Check(3, L3btnW, L3btnN, L3btnO, L3lbWord, L3lb1, L3lb2, L3lb3, L3lb4, L3lb5);
                        break;
                    }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {

                        Reset(L0btnA, L0btnT, L0btnC, L0lbWord);
                        break;
                    }
                case 1:
                    {
                        Reset(L1btnA, L1btnT, L1btnR, L1lbWord);
                        break;
                    }
                case 2:
                    {
                        Reset(L2btnT, L2btnE, L2btnN, L2lbWord);
                        break;
                    }
                case 3:
                    {
                        Reset(L3btnW, L3btnO, L3btnN, L3lbWord);
                        break;
                    }
            }
        }
    }
}

