using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruongSyNghia.BAL.Employee;
using TruongSyNghia.DTO.Employee;

namespace TruongSyNghia.GUI.Customer
{
    public partial class EmployeeGUI : Form
    {

        EmployeeBAL employeeBAL = new EmployeeBAL();
        public EmployeeGUI()
        {
            InitializeComponent();
        }

        private void EmployeeGUI_Load(object sender, EventArgs e)
        {
            dgvEmployeeSource.DataSource = employeeBAL.get();
        }

        void addViewRow(EmployeeDTO employee)
        {
            int index = dgvEmployee.Rows.Add();
            loadViewRow(index, employee);
        }
        void loadViewRow(int index,EmployeeDTO employee)  
        {
            dgvEmployee.Rows[index].Cells["id"].Value = employee.id;
            dgvEmployee.Rows[index].Cells["name"].Value = employee.name;
            dgvEmployee.Rows[index].Cells["gender"].Value = employee.gender;
            dgvEmployee.Rows[index].Cells["date_birth"].Value = employee.date_birth;
            dgvEmployee.Rows[index].Cells["place_birth"].Value = employee.place_birth;
            dgvEmployee.Rows[index].Cells["department_name"].Value = employee.department_name;
        }
        private void dgvEmployeeSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            dgvEmployee.Rows.Clear();
            foreach (EmployeeDTO employee in dgvEmployeeSource.List)
            {
                addViewRow(employee);
            }
        }
    }
}
