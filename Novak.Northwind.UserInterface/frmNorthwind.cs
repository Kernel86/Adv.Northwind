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
        bool _bIsFormLoaded = false;

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
                _bIsFormLoaded = true;
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

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (_bIsFormLoaded)
                {
                    CCustomer oCustomer = _oCustomers[dgvCustomers.CurrentRow.Index];

                    PopulateScreen(oCustomer);
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void PopulateScreen(CCustomer oCustomer)
        {
            txtCustomerID.Text = oCustomer.CustomerID;
            txtCompanyName.Text = oCustomer.CompanyName;
            txtContactName.Text = oCustomer.ContactName;
            txtContactTitle.Text = oCustomer.ContactTitle;
            txtAddress.Text = oCustomer.Address;
            txtCity.Text = oCustomer.City;
            txtRegion.Text = oCustomer.Region;
            txtPostalCode.Text = oCustomer.PostalCode;
            txtCountry.Text = oCustomer.Country;
            txtPhone.Text = oCustomer.Phone;
            txtFax.Text = oCustomer.Fax;
            txtSalesRep.Text = oCustomer.SalesRep.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CCustomer oCustomer = _oCustomers[dgvCustomers.CurrentRow.Index];

                PopulateCustomer(oCustomer);

                oCustomer.Update();

                dgvCustomers.DataSource = null;
                dgvCustomers.DataSource = _oCustomers.Items;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void PopulateCustomer(CCustomer oCustomer)
        {
            oCustomer.CustomerID = txtCustomerID.Text;
            oCustomer.CompanyName = txtCompanyName.Text;
            oCustomer.ContactName = txtContactName.Text;
            oCustomer.ContactTitle = txtContactTitle.Text;
            oCustomer.Address = txtAddress.Text;
            oCustomer.City = txtCity.Text;
            oCustomer.Region = txtRegion.Text;
            oCustomer.PostalCode = txtPostalCode.Text;
            oCustomer.Country = txtCountry.Text;
            oCustomer.Phone = txtPhone.Text;
            oCustomer.Fax = txtFax.Text;
            oCustomer.SalesRep = int.Parse(txtSalesRep.Text);
        }
    }
}
