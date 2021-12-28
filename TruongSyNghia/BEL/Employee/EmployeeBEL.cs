using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongSyNghia.BEL.Employee
{
    class EmployeeBEL
    {
        public String id { get; set; }
        public String name { get; set; }
        public DateTime date_birth { get; set; }
        public int gender { get; set; }
        public String place_birth { get; set; }
        public String department_id { get; set; }

        public EmployeeBEL()
        {

        }

        public EmployeeBEL(String id)
        {
            this.id = id;
        }
    }
}
