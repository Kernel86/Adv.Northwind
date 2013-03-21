using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Novak.Northwind.UserInterface
{
    public partial class frmLogIt : Form
    {
        log4net.ILog log = log4net.LogManager.GetLogger("Utility.Logger");

        public frmLogIt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                log.Warn(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
