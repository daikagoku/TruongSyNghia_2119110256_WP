using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruongSyNghia_Entity.BEL.Customer;
using TruongSyNghia_Entity.DAL.Customer;

namespace TruongSyNghia_Entity.BAL.Customer
{
    class CustomerBAL
    {
        CustomerDAL customerDAL = new CustomerDAL();
        public List<CustomerBEL> gets()
        {
            return customerDAL.gets();
        }
        public CustomerBEL get(String id)
        {
            return customerDAL.get(id);
        }
        public Boolean delete(CustomerBEL customerBEL)
        {
            return customerDAL.delete(customerBEL);
        }
        public Boolean put(CustomerBEL customerBEL)
        {
            return customerDAL.put(customerBEL);
        }
        public Boolean post(CustomerBEL customerBEL)
        {
            return customerDAL.post(customerBEL);
        }
    }
}
