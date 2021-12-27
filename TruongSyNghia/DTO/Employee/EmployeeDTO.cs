using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongSyNghia.DTO.Employee
{
    class EmployeeDTO
    {
        public String id { get; set; }
        public String name { get; set; }
        public DateTime date_birth { get; set; }
        public Boolean gender { get; set; }
        public String place_birth { get; set; }
        public String department_name { get; set; }
        public EmployeeDTO(SqlDataReader sqlDataReader)
        {
            this.id = sqlDataReader["id"].ToString();
            this.name = sqlDataReader["name"].ToString();

            String gender = sqlDataReader["gender"].ToString();
            this.gender = gender.Equals("1");

            this.place_birth = sqlDataReader["place_birth"].ToString();

            this.department_name = sqlDataReader["department_name"].ToString();
        }

    }
}
