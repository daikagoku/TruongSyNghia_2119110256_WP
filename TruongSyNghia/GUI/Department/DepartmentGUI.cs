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
using TruongSyNghia.BEL.Department;
using TruongSyNghia.DTO.Department;

namespace TruongSyNghia.GUI.Department
{
    public partial class DepartmentGUI : Form
    {
        DepartmentBAL departmentBAL = new DepartmentBAL();
        public DepartmentGUI()
        {
            InitializeComponent();
        }

        private void DepartmentGUI_Load(object sender, EventArgs e)
        {
            List<DepartmentDTO>  list = departmentBAL.get();
            loadViewGrid(list);
        }
        void addViewRow(DepartmentDTO department)
        {
            int index = dgvDepartment.Rows.Add();
            loadViewRow(index, department);
        }
        void loadViewRow(int index, DepartmentDTO department)
        {
            dgvDepartment.Rows[index].Cells["id"].Value = department.id;
            dgvDepartment.Rows[index].Cells["name"].Value = department.name;
        }
        void loadViewGrid(List<DepartmentDTO> list)
        {
            dgvDepartment.Rows.Clear();
            foreach (DepartmentDTO department in list)
            {
                addViewRow(department);
            }
        }
        private void dgvDepartmentSource_DataSourceChanged(object sender, EventArgs e)
        {

        }


        void clearInput()
        {
            inputId.Text = "";
            inputName.Text = "";
        }
        void loadViewInput(DepartmentDTO department){
            inputId.Text = department.id;
            inputName.Text = department.name;
        }

        DepartmentBEL getInputValue()
        {
            DepartmentBEL department = new DepartmentBEL();
            department.id = inputId.Text;
            department.name = inputName.Text;
            return department;
        }
        Boolean validate()
        {
            if (inputId.Text.Equals(""))
            {

                MessageBox.Show("Không bỏ trống mã đơn vị !!");
                return false;
            }
            else if(inputName.Text.Equals(""))
            {
                MessageBox.Show("Không bỏ trống tên đơn vị !!");
                return false;
            }

            return true;
        }
        private void btnPost_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                DepartmentBEL departmentBEL = getInputValue();
                try
                {
                    if (departmentBAL.post(departmentBEL))
                    {
                        DepartmentDTO departmentDTO = new DepartmentDTO(inputId.Text);
                        departmentDTO.name = inputName.Text;
                        addViewRow(departmentDTO);
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi xãy ra !!");
                }

                clearInput();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvDepartment.SelectedRows.Count > 0 
                && dgvDepartment.SelectedRows[0].Index < dgvDepartment.Rows.Count -1
                && dgvDepartment.SelectedRows[0].Index >= 0
            )
            {
                int index = dgvDepartment.SelectedRows[0].Index;
                DepartmentBEL departmentBEL = getInputValue();
                try
                {
                    if (departmentBAL.delete(departmentBEL))
                    {
                        dgvDepartment.Rows.RemoveAt(index);
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi xãy ra !!");
                }
            }

        }

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0 && index < dgvDepartment.Rows.Count-1)
            {
                dgvDepartment.Rows[index].Selected = true;
            }
        }

        private void dgvDepartment_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvDepartment.SelectedRows.Count > 0
                && dgvDepartment.SelectedRows[0].Index < dgvDepartment.Rows.Count - 1
                && dgvDepartment.SelectedRows[0].Index >= 0
            )
            {
                DepartmentDTO department = departmentBAL.get(dgvDepartment.SelectedRows[0].Cells["id"].Value.ToString());
                loadViewInput(department);

            }
            else
            {
                clearInput();
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
