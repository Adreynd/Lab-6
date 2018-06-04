using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    class CustomerList
    {
        public List<Customer> customers;
        private int count;

        public CustomerList()
        {
            customers = null;
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

        public void Add(Customer c)
        {
            customers.Add(c);
        }

        public void Remove(Customer c)
        {
            customers.Remove(c);
        }

        static public CustomerList operator+(CustomerList cl, Customer c)
        {
            cl.Add(c);
            return cl;
        }

        static public CustomerList operator-(CustomerList cl, Customer c)
        {
            cl.Remove(c);
            return cl;
        }
    }
}
