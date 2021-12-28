using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongSyNghia.DTO.Department
{
    class DepartmentDTO
    {
        public String id { get; set; }
        public String name { get; set; }

        public DepartmentDTO(String id)
        {
            this.id = id;
        }
        public DepartmentDTO(SqlDataReader sqlDataReader)
        {
            this.id = sqlDataReader["id"].ToString();
            this.name = sqlDataReader["name"].ToString();
        }
    }
}
