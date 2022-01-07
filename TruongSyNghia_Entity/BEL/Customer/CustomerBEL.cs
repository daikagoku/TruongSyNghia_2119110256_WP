using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongSyNghia_Entity.BEL.Customer
{
    class CustomerBEL
    {
        public String id { get; set; }
        public String name { get; set; }

        public CustomerBEL() { }
        public CustomerBEL(String id) { this.id = id; }
        public void merge(CustomerBEL customer)
        {
            this.name = customer.name;
        }
    }
}
