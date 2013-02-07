using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Novak.Northwind.DataLayer;

namespace Novak.Northwind.BusinessLayer
{
    public class CCustomers
    {
        // Private Fields
        private List<CCustomer> _glItems;

        // Public Properties
        public List<CCustomer> Items
        {
            get { return _glItems; }
            set { _glItems = value; }
        }

        public int Count
        {
            get { return _glItems.Count; }
        }

        public CCustomer this[int index]
        {
            get { return _glItems[index]; }
            set { _glItems[index] = value; }
        }

        // Public Constructors
        public CCustomers()
        {
            _glItems = new List<CCustomer>();
        }

        // Events
        public event EventHandler CustomersChanged;

        // Public Methods
        public void Add(CCustomer oItem)
        {
            _glItems.Add(oItem);
            if (!CustomersChanged.Equals(null))
                CustomersChanged(this, new EventArgs());
        }

        public void RemoveAt(int iIndex)
        {
            _glItems.RemoveAt(iIndex);
            if (!CustomersChanged.Equals(null))
                CustomersChanged(this, new EventArgs());
        }

        public void SelectCustomer()
        {
            NorthwindDataContext oDc = new NorthwindDataContext();

            // Select customers using LINQ
            var otblCustomers = from c in oDc.tblCustomers select c;

            // Fill generic list of customers
            foreach (tblCustomer otblCustomer in otblCustomers)
            {
                CCustomer oCustomer = new CCustomer();
                oCustomer.Load(otblCustomer);
                _glItems.Add(oCustomer);
            }

            oDc = null;
        }
    }
}
