using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoinFlip
{
    public partial class frmCoinFlip : Form
    {
        public frmCoinFlip()
        {
            InitializeComponent();
        }

        string[] images =
        {
            "C:/Users/jpscott/Desktop/PaymentOptions/PaymentChapter10/CoinFlip/images/heads.jpg",
            "C:/Users/jpscott/Desktop/PaymentOptions/PaymentChapter10/CoinFlip/images/tails.jpg"
        };

        private void btnFlipCoin_Click(object sender, EventArgs e)
        {
            int headsOrTails = GenerateRandomNumber();
            string winner = FindTheWinner(headsOrTails);
            ShowTheWinner(winner);
        }

        private int GenerateRandomNumber()
        {
            Random rand = new Random();
            int number  = rand.Next(1, 3);
            return number;
        }

        private string FindTheWinner(int hot)
        {
            string w;

            w = (hot == 1) ? "Heads" : "Tails";

            //if (hot == 1)
            //{
            //    w = "Heads";
            //}
            //else if (hot == 2)
            //{
            //    w = "Tails";
            //}

            return w;
        }

        private void ShowTheWinner(string w)
        {
            if (w == "Heads")
            {
                pbHeadsOrTails.Image = Image.FromFile(images[0]);
            }

            else if (w == "Tails")
            {
                pbHeadsOrTails.Image = Image.FromFile(images[1]);
            }

            lblResults.Text = $"{w} Won!";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll() 
        {
            pbHeadsOrTails.Image = null;
            lblResults.Text = "";
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
            "Do You Really Want To Exit The Program?",
            "EXIT NOW?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
