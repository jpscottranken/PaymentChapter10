using System;
using System.Drawing;
using System.Windows.Forms;

namespace PaymentOptions
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        string[] creditCardType =
        {
                "Visa",
                "MasterCard",
                "American Express"
        };

        string[] months =
        {
                "Select month...",
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
        };

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                SaveData();
            }
        }




        private void frmPaymentOptions_Load(object sender, EventArgs e)
        {
            FillUpCreditCardTypeListBox();
            FillUpMonthsComboBox();
            FillUpYearsComboBox();
        }

        private void FillUpMonthsComboBox()
        {
            cboMonth.Items.Clear();

            foreach (string month in months)
            {
                cboMonth.Items.Add(month);
            }

            cboMonth.SelectedIndex = 0;
        }

        private void FillUpCreditCardTypeListBox()
        {
            lstCreditCardType.Items.Clear();

            foreach (string cct in creditCardType)
            {
                lstCreditCardType.Items.Add(cct);
            }

            lstCreditCardType.SelectedIndex = 0;
        }

        private void FillUpYearsComboBox()
        {
            int year = DateTime.Today.Year;
            int endYear = year + 8;
            cboYear.Items.Add("Select year...");
            while (year <= endYear)
            {
                cboYear.Items.Add(year);
                year++;
            }

            cboYear.SelectedIndex = 0;
        }


        private bool IsValidData()
        {
            bool success = true;

            if (radCreditCard.Checked)
            {
                string errorMessage = "";

                if (lstCreditCardType.SelectedIndex == -1)
                {
                    errorMessage += "You must select a credit card type.\n";
                }
                if (txtCardNumber.Text == "")
                {
                    errorMessage += "You must enter a credit card number.\n";
                }
                if (cboMonth.SelectedIndex == 0)
                {
                    errorMessage += "You must select a month.\n";
                }
                if (cboYear.SelectedIndex == 0)
                {
                    errorMessage += "You must select a year.\n";
                }

                if (errorMessage != "")
                {
                    success = false;
                    MessageBox.Show(errorMessage, "Entry Error");
                }
            }
            return success;
        }

        private void SaveData()
        {
            string msg = "";
            if (radCreditCard.Checked)
            {
                msg += "Charge to credit card." + "\n\n";
                msg += "Card type: " + lstCreditCardType.Text + "\n";
                msg += "Card number: " + txtCardNumber.Text + "\n";
                msg += "Exp. date: "
                    + cboMonth.Text + "/"
                    + cboYear.Text + "\n";
            }
            else
            {
                msg += "Send bill to customer." + "\n\n";
            }

            bool isDefaultBilling = chkSetAsDefault.Checked;
            msg += "Default billing: " + isDefaultBilling;

            Tag = msg;
            DialogResult = DialogResult.OK;
        }

        private void rdoCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            if (radCreditCard.Checked)
                EnableControls();
            else
                DisableControls();
        }

        private void EnableControls()
        {
            lstCreditCardType.Enabled = true;
            txtCardNumber.Enabled = true;
            cboMonth.Enabled = true;
            cboYear.Enabled = true;
        }

        private void DisableControls()
        {
            lstCreditCardType.Enabled = false;
            txtCardNumber.Enabled = false;
            cboMonth.Enabled = false;
            cboYear.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
