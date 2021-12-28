using System;
using System.Collections.Generic;
using System.Data;
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
            this.primary = "id";
            this.table = "employee";
        }
        public EmployeeDTO get(String id)
        {
            EmployeeDTO employeeBEL = null;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("pr_getEmployee", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
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
            sqlCommand.CommandType = CommandType.StoredProcedure;
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
            SqlCommand sqlCommand = new SqlCommand("pr_deleteEmployee", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@id", employeeBEL.id));
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
        public Boolean post(EmployeeBEL employeeBEL)
        {

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("pr_postEmployee", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@id", employeeBEL.id));
            sqlCommand.Parameters.Add(new SqlParameter("@name", employeeBEL.name));
            sqlCommand.Parameters.Add(new SqlParameter("@date_birth", employeeBEL.date_birth));
            sqlCommand.Parameters.Add(new SqlParameter("@place_birth", employeeBEL.place_birth));
            sqlCommand.Parameters.Add(new SqlParameter("@gender", employeeBEL.gender));
            sqlCommand.Parameters.Add(new SqlParameter("@department_id", employeeBEL.department_id));

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
        public Boolean put(EmployeeBEL employeeBEL)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("pr_putEmployee", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@id", employeeBEL.id));
            sqlCommand.Parameters.Add(new SqlParameter("@name", employeeBEL.name));
            sqlCommand.Parameters.Add(new SqlParameter("@date_birth", employeeBEL.date_birth));
            sqlCommand.Parameters.Add(new SqlParameter("@place_birth", employeeBEL.place_birth));
            sqlCommand.Parameters.Add(new SqlParameter("@gender", employeeBEL.gender));
            sqlCommand.Parameters.Add(new SqlParameter("@department_id", employeeBEL.department_id));

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
    }
}
