using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruongSyNghia.BEL.Employee;
using TruongSyNghia.DAL.Employee;
using TruongSyNghia.DTO.Employee;

namespace TruongSyNghia.BAL.Employee
{
    class EmployeeBAL
    {
        private EmployeeDAL employeeDAL = new EmployeeDAL();
        public List<EmployeeDTO> get()
        {
            return employeeDAL.get();
        }
        public EmployeeDTO get(String MaKH)
        {
            return employeeDAL.get(MaKH);
        }
        public Boolean delete(EmployeeBEL employeeBEL)
        {
            return employeeDAL.delete(employeeBEL);
        }
        public Boolean put(EmployeeBEL employeeBEL)
        {
            return employeeDAL.put(employeeBEL);
        }
        public Boolean post(EmployeeBEL employeeBEL)
        {
            return employeeDAL.post(employeeBEL);
        }
    }
}
