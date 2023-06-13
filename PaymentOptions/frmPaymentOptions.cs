using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentOptions
{
    public partial class frmPaymentOptions : Form
    {
        public frmPaymentOptions()
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
                "Select A Month",
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
            cboYear.Items.Add("Select a year...");
            while (year <= endYear)
            {
                cboYear.Items.Add(year);
                year++;
            }

            cboYear.SelectedIndex = 0;
        }
    }
}
