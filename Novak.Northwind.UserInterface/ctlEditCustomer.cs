using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Novak.Northwind.UserInterface
{
    public partial class ctlEditCustomer : UserControl
    {
        public string CustomerId
        {
            get { return this.txtCustomerID.Text; }
            set { this.txtCustomerID.Text = value; }
        }

        public string CompanyName
        {
            get { return this.txtCompanyName.Text; }
            set { this.txtCompanyName.Text = value; }
        }

        public ctlEditCustomer()
        {
            InitializeComponent();
        }

        private void ctlEditCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
