using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceReference1;

namespace OnlinePaymentSystemDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.PrintWebServiceClient printWs = new ServiceReference1.PrintWebServiceClient();
            var username = idField.Text;
            decimal amount = (decimal) Convert.ToDouble(quotaField.Text);
            switch (combo_id.SelectedIndex)
            {
                case 0: printWs.TransferMoneyWithUsername(idField.Text, 0);
                    break;
                case 1: printWs.TransferMoneyWithUserId(Convert.ToInt32(idField.Text), 0);
                    break;
            }
        }


    }
}
