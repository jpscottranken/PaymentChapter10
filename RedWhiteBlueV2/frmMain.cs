using System;
using System.Drawing;
using System.Windows.Forms;

namespace RedWhiteBlueV2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void btnRed_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form Red = new frmRed();
            Red.ShowDialog();
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form White = new frmWhite();
            White.ShowDialog();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form Blue = new frmBlue();
            Blue.ShowDialog();
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
