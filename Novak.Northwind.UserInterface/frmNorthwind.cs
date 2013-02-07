using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Novak.Northwind.BusinessLayer;

namespace Novak.Northwind.UserInterface
{
    public partial class frmNorthwind : Form
    {
        CCustomers _oCustomers;

        public frmNorthwind()
        {
            InitializeComponent();
        }

        private void frmNorthwind_Load(object sender, EventArgs e)
        {
            _oCustomers = new CCustomers();
        }

        private void btnSelectAllCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                _oCustomers.SelectCustomer();
                dgvCustomers.DataSource = null;
                dgvCustomers.DataSource = _oCustomers.Items;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                CCustomer oCustomer = _oCustomers[dgvCustomers.CurrentRow.Index];
                oCustomer.Delete();
                _oCustomers.RemoveAt(dgvCustomers.CurrentRow.Index);

                dgvCustomers.DataSource = null;
                dgvCustomers.DataSource = _oCustomers.Items;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }
    }
}
