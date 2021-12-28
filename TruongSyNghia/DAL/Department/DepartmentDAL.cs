using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruongSyNghia.BEL.Department;
using TruongSyNghia.DTO.Department;

namespace TruongSyNghia.DAL.Department
{
    class DepartmentDAL : BaseDAL
    {
        public DepartmentDAL()
        {
            this.table = "departmnet";
        }
        public List<DepartmentDTO> get()
        {
            List<DepartmentDTO> list = new List<DepartmentDTO>();
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("pr_getDepartments", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    list.Add(new DepartmentDTO(sqlDataReader));
                }
            }
            sqlConnection.Close();
            return list;
        }
        public DepartmentDTO get(String id)
        {
            DepartmentDTO list = new DepartmentDTO(id);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("pr_getDepartment", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@id", id));
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows && sqlDataReader.Read())
            {
                list = new DepartmentDTO(sqlDataReader);
            }
            sqlConnection.Close();
            return list;
        }

        public Boolean delete(DepartmentBEL departmentBEL)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("pr_deleteDepartment", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@id", departmentBEL.id));
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
        public Boolean post(DepartmentBEL departmentBEL)
        {

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("pr_postDepartment", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@id", departmentBEL.id));
            sqlCommand.Parameters.Add(new SqlParameter("@name", departmentBEL.name));

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
        public Boolean put(DepartmentBEL departmentBEL)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("pr_putDepartment", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@id", departmentBEL.id));
            sqlCommand.Parameters.Add(new SqlParameter("@name", departmentBEL.name));

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
    }
}
