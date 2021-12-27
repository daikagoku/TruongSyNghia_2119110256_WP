using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruongSyNghia.BEL.Employee;
using TruongSyNghia.DTO.Employee;

namespace TruongSyNghia.DAL.Employee
{
    class EmployeeDAL : BaseDAL
    {
        public EmployeeDAL() {
            this.table = "employee";
        }
        public EmployeeDTO get(String id)
        {
            EmployeeDTO employeeBEL = null;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("pr_getEmployeeByID @id", sqlConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@id", id));
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    employeeBEL = new EmployeeDTO(sqlDataReader);
                }
            }
            sqlConnection.Close();
            return employeeBEL;
        }
        public List<EmployeeDTO> get()
        {
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("pr_getEmployees", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    list.Add(new EmployeeDTO(sqlDataReader));
                }
            }
            sqlConnection.Close();
            return list;
        }


        public Boolean delete(EmployeeBEL employeeBEL)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("pr_deleteEmployee @id", sqlConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@id", employeeBEL.id));
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
        public Boolean post(EmployeeBEL employeeBEL)
        {
            employeeBEL.id = this.getNewID("id");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("pr_insertEmployee", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
        public Boolean put(EmployeeBEL employeeBEL)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("pr_updateEmployee", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
    }
}
