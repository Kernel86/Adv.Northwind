using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Novak.Northwind.BusinessLayer;

namespace Novak.Northwind.Web
{
    public partial class _Default : System.Web.UI.Page
    {
        CCustomers _oCustomers;

        protected void Page_Load(object sender, EventArgs e)
        {
            _oCustomers = new CCustomers();
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
               /* NorthwindService.NorthwindClient oClient = new NorthwindService.NorthwindClient();
                List<CCustomer> oCustomerList = new List<CCustomer>;

                oCustomerList = oClient.GetCustomers();

                dgvCustomers.DataSource = null;
                dgvCustomers.DataSource = oCustomerList;
                dgvCustomers.DataBind();

                oClient.Close();
                oClient = null; */
            }
            catch (Exception ex)
            {
                //lblStatus.Text = ex.Message;
            }
        }
    }
}
