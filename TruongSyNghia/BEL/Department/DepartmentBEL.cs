using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongSyNghia.BEL.Department
{
    class DepartmentBEL
    {
        public String id { get; set; }
        public String name { get; set; }

        public DepartmentBEL()
        {

        }

        public DepartmentBEL(String id)
        {
            this.id = id;
        }
    }
}
