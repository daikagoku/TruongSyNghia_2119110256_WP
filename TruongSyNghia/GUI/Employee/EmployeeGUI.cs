using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruongSyNghia.BAL.Department;
using TruongSyNghia.BAL.Employee;
using TruongSyNghia.DTO.Department;
using TruongSyNghia.DTO.Employee;

using TruongSyNghia.BEL.Employee;

namespace TruongSyNghia.GUI.Employee
{
    public partial class EmployeeGUI : Form
    {

        EmployeeBAL employeeBAL = new EmployeeBAL();
        DepartmentBAL departmentBAL = new DepartmentBAL();
        public EmployeeGUI()
        {
            InitializeComponent();
        }

        private void EmployeeGUI_Load(object sender, EventArgs e)
        {
            List<EmployeeDTO> employeeDTOs = employeeBAL.get();
            loadDataGrid(employeeDTOs);
            

            inputDepartmentSource.DataSource = departmentBAL.get();
            inputDepartment.DataSource = inputDepartmentSource;
            inputDepartment.DisplayMember = "name";
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
            dgvEmployee.Rows[index].Cells["date_birth"].Value = employee.date_birth.ToString("dd/MM/yyyy");
            dgvEmployee.Rows[index].Cells["place_birth"].Value = employee.place_birth;
            dgvEmployee.Rows[index].Cells["department_name"].Value = employee.department_name;
        }
        void loadDataGrid(List<EmployeeDTO> list)
        {
            dgvEmployee.Rows.Clear();
            foreach (EmployeeDTO employee in list)
            {
                addViewRow(employee);
            }
        }


        void clearInput()
        {
            inputId.Text = "";
            inputName.Text = "";
            inputPlace.Text = "";
            inputGender.Checked = false;
            //inputDepartment.SelectedIndex = 0;
        }
        void loadViewInput(EmployeeDTO e)
        {
            inputId.Text = e.id;
            inputName.Text = e.name;

            //inputDate.Value = e.date_birth;
            inputPlace.Text = e.place_birth;
            inputGender.Checked = e.gender;

            inputDepartment.Text = e.department_name;
        }

        EmployeeBEL getValueInput()
        {
            EmployeeBEL eBEL = new EmployeeBEL();
            eBEL.id = inputId.Text;
            eBEL.name = inputName.Text;
            eBEL.date_birth = inputDate.Value;
            eBEL.place_birth = inputPlace.Text;
            if (inputGender.Checked)
            {
                eBEL.gender = 1;
            }
            else
            {
                eBEL.gender = 0;
            }
            eBEL.department_id = ((DepartmentDTO)inputDepartment.SelectedItem).id;
            return eBEL;
        }
        Boolean validate()
        {
            if (inputName.Text.Equals(""))
            {
                MessageBox.Show("Không bỏ trống tên!!", "Thông báo");
                return false;
            }

            return true;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (validate())
            {

                try
                {
                    EmployeeBEL eBEL = getValueInput();
                    if (employeeBAL.post(eBEL))
                    {
                        EmployeeDTO employee = employeeBAL.get(eBEL.id);
                        addViewRow(employee);
                    }
                }
                catch(Exception error)
                {
                    MessageBox.Show("Có lỗi xãy ra !!"+error, "Thông báo");
                }

                clearInput();
            }
        }


        private void inputDepartmentSource_ListChanged(object sender, ListChangedEventArgs e)
        {

        }

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dgvEmployee.Rows.Count - 1)
            {
                dgvEmployee.Rows[index].Selected = true;
            }
        }

        private void dgvDepartment_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvEmployee.SelectedRows.Count > 0
                && dgvEmployee.SelectedRows[0].Index < dgvEmployee.Rows.Count - 1
                && dgvEmployee.SelectedRows[0].Index >= 0
            )
            {
                EmployeeDTO employee = employeeBAL.get(dgvEmployee.SelectedRows[0].Cells["id"].Value.ToString());
                loadViewInput(employee);

            }
            else
            {
                clearInput();
            }
        }

        private void btnPut_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0
                && dgvEmployee.SelectedRows[0].Index < dgvEmployee.Rows.Count - 1
                && dgvEmployee.SelectedRows[0].Index >= 0
            )
            {
                if (validate())
                {

                    try
                    {
                        EmployeeBEL eBEL = getValueInput();
                        int index = dgvEmployee.SelectedRows[0].Index;
                        if (employeeBAL.put(eBEL))
                        {
                            EmployeeDTO employee = employeeBAL.get(eBEL.id);
                            loadViewRow(index, employee);
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Có lỗi xãy ra !!" + error);
                    }
                }

            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0
                && dgvEmployee.SelectedRows[0].Index < dgvEmployee.Rows.Count - 1
                && dgvEmployee.SelectedRows[0].Index >= 0
            )
            {
                if (validate() && !inputId.Text.Equals(""))
                {

                    try
                    {
                        EmployeeBEL eBEL = getValueInput();
                        int index = dgvEmployee.SelectedRows[0].Index;
                        DialogResult result = MessageBox.Show("Bạn có muốn xóa dòng này??","Thông báo", MessageBoxButtons.YesNo);
                        if(result == DialogResult.Yes)
                        {
                            if (employeeBAL.delete(eBEL))
                            {
                                dgvEmployee.Rows.RemoveAt(index);
                                dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Selected = true;
                            }
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Có lỗi xãy ra !!" + error);
                    }
                }
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát??", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
