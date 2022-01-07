using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruongSyNghia_Entity.BEL.Customer;

namespace TruongSyNghia_Entity.DAL.Customer
{
    class CustomerDAL:DatabaseBASE
    {
        public List<CustomerBEL> gets()
        {
            return customers.ToList();
        }

        public CustomerBEL getFirst()
        {
            return customers.First();
        }
        public CustomerBEL getLast()
        {
            return customers.Last();
        }
        public CustomerBEL get(String id)
        {
            return customers.Find(new Object[] {id});
        }
        public Boolean delete(CustomerBEL customerBEL)
        {
            customers.Remove(customerBEL);
            Entry(customerBEL).State = EntityState.Deleted;
            SaveChanges();
            return true;
        }
        public Boolean put(CustomerBEL customerBEL)
        {
            //customers.Attach(customerBEL);
            Entry(customerBEL).State = EntityState.Modified;
            SaveChanges();
            return true;
        }
        public Boolean post(CustomerBEL customerBEL)
        {
            customers.Add(customerBEL);
            Entry(customerBEL).State = EntityState.Added;
            SaveChanges();
            return true;
        }
    }
}
