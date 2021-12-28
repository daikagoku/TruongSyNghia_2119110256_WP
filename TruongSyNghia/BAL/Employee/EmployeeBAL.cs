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
        public EmployeeDTO get(String id)
        {
            return employeeDAL.get(id);
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
            String id = employeeDAL.getNewID();
            employeeBEL.id = id;
            return employeeDAL.post(employeeBEL);
        }
    }
}
