using System;
using System.Drawing;
using System.Windows.Forms;

namespace RedWhiteBlueV1
{
    public partial class frmRWBV1 : Form
    {
        public frmRWBV1()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
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
