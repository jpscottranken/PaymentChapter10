using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedWhiteBlueV2
{
    public partial class frmRed : Form
    {
        public frmRed()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form Main = new frmMain();
            Main.ShowDialog();
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
