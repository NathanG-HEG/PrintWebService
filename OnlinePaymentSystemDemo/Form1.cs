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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.PrintWebServiceClient printWs = new ServiceReference1.PrintWebServiceClient();
            var username = usernameField.Text;
            float amount = (float) Convert.ToDouble(quotaField.Text);
            printWs.TransferMoneyWithUsername(username, amount);
        }
    }
}
