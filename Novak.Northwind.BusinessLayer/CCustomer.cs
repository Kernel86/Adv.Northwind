﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Novak.Northwind.DataLayer;

namespace Novak.Northwind.BusinessLayer
{
    public class CCustomer
    {
        // Private Fields
        private string _CustomerID;
        private string _CompanyName;
        private string _ContactName;
        private string _ContactTitle;
        private string _Address;
        private string _City;
        private string _Region;
        private string _PostalCode;
        private string _Country;
        private string _Phone;
        private string _Fax;
        private int _SalesRep;

        // Public Properties
#region "Public Properties"
        public string CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }

        public string CompanyName
        {
            get { return _CompanyName; }
            set { _CompanyName = value; }
        }

        public string ContactName
        {
            get { return _ContactName; }
            set { _ContactName = value; }
        }

        public string ContactTitle
        {
            get { return _ContactTitle; }
            set { _ContactTitle = value; }
        }

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }

        public string Region
        {
            get { return _Region; }
            set { _Region = value; }
        }

        public string PostalCode
        {
            get { return _PostalCode; }
            set { _PostalCode = value; }
        }

        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }

        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        public string Fax
        {
            get { return _Fax; }
            set { _Fax = value; }
        }

        public int SalesRep
        {
            get { return _SalesRep; }
            set { _SalesRep = value; }
        }
#endregion

        // Public Methods
        public int Update()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GetData()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
