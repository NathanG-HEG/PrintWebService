using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrintWebService;

namespace OnlinePaymentSystemDemo
{
    public partial class PrintForm : Form
    {
        private PrintWebServiceClient printWs;
        public PrintForm()
        {
            InitializeComponent();
            printWs = new PrintWebServiceClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //do not process if some required fields are not filled
            if (idField.Text.Equals("") || combo_id.Text.Equals("") || quotaField.Text.Equals(""))
                return;

            decimal amount = (decimal) Convert.ToDouble(quotaField.Text);
            switch (combo_id.SelectedIndex)
            {
                case 0: printWs.TransferMoneyWithUsername(idField.Text, amount);
                    break;
                case 1: printWs.TransferMoneyWithCardId(Convert.ToInt32(idField.Text), amount);
                    break;
            }
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            //do not process if some required fields are not filled
            if (photocopies_in.Text.Equals("") || combo_product.Text.Equals("") || card_id_in.Text.Equals(""))
                return;

            int nbCopies = Convert.ToInt32(photocopies_in.Text);
            string product = combo_product.Text;
            int cardId = Convert.ToInt32(card_id_in.Text);

            bool canPrint = printWs.Print(nbCopies, product, cardId);
            if (!canPrint)
            {
                //error dialog
                Print_error errorDialog = new Print_error();
                errorDialog.ShowDialog(this);
                errorDialog.Dispose();
                return;
            }
            
            //print dialog
            Print_dialog printDialog = new Print_dialog();
            if (printDialog.ShowDialog(this) == DialogResult.OK)
            {
                printWs.DebitAccount(nbCopies, product, cardId);
            }
            printDialog.Dispose();

        }
    }
}
