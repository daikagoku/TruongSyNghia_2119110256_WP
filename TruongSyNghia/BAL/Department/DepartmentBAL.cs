using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruongSyNghia.BEL.Department;
using TruongSyNghia.DAL.Department;
using TruongSyNghia.DTO.Department;

namespace TruongSyNghia.BAL.Department
{
    class DepartmentBAL
    {
        private DepartmentDAL departmentDAL = new DepartmentDAL();
        public List<DepartmentDTO> get()
        {
            return departmentDAL.get();
        }
        public DepartmentDTO get(String id)
        {
            return departmentDAL.get(id);
        }
        public Boolean delete(DepartmentBEL departmentBEL)
        {
            return departmentDAL.delete(departmentBEL);
        }
        public Boolean put(DepartmentBEL departmentBEL)
        {
            return departmentDAL.put(departmentBEL);
        }
        public Boolean post(DepartmentBEL departmentBEL)
        {
            return departmentDAL.post(departmentBEL);
        }
    }
}
