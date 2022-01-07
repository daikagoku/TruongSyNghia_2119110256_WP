using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruongSyNghia_Entity.BAL.Customer;
using TruongSyNghia_Entity.BEL.Customer;

namespace TruongSyNghia_Entity.GUI.Customer
{
    public partial class CustomerGUI : Form
    {
        CustomerBAL customerBAL = new CustomerBAL();
        int selectRow = -1;
        public CustomerGUI()
        {
            InitializeComponent();
        }


        void addRowGrid(CustomerBEL customer)
        {
            int index = dgvCustomer.Rows.Add();
            loadRowGrid(index, customer);
        }
        void loadRowGrid(int index,CustomerBEL customer)
        {
            dgvCustomer.Rows[index].Cells["id"].Value = customer.id;
            dgvCustomer.Rows[index].Cells["name"].Value = customer.name;
        }
        private void CustomerGUI_Load(object sender, EventArgs e)
        {
            List<CustomerBEL> customers = customerBAL.gets();
            foreach(CustomerBEL customer in customers)
            {
                addRowGrid(customer);
            }
        }

        void clearInput()
        {
            inputId.Text = "";
            inputName.Text = "";
        }
        void loadInput(int index)
        {
            inputId.Text = dgvCustomer.Rows[index].Cells["id"].Value.ToString();
            inputName.Text = dgvCustomer.Rows[index].Cells["name"].Value.ToString();
        }
        void loadInput(CustomerBEL customer)
        {
            inputId.Text = customer.id;
            inputName.Text = customer.name;
        }
        CustomerBEL getValueInput()
        {
            String id = inputId.Text;
            CustomerBEL customer = customerBAL.get(id);
            if(customer == null)
            {
                customer = new CustomerBEL(id);
            }
            customer.name = inputName.Text;
            return customer;
        }
        Boolean validateId()
        {

            if (inputId.Text.Equals(""))
            {
                MessageBox.Show("Không bỏ trống mã nhân viên");
                return false;
            }
            else
            {
                CustomerBEL customer = customerBAL.get(inputId.Text.ToString());
                if(customer != null)
                {
                    MessageBox.Show("Đã tồn tại mã nhân viên");
                    return false;
                }

            }
            return true;
        }

        Boolean validateInput()
        {
            if (inputName.Text.Equals(""))
            {
                MessageBox.Show("Không bỏ trống tên nhân viên");
                return false;
            }

            return true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectRow != -1)
            {
                if (validateInput())
                {
                    CustomerBEL customer = getValueInput();
                    if (customerBAL.delete(customer))
                    {
                        dgvCustomer.Rows.RemoveAt(selectRow);

                    };
                }
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            if (validateId() && validateInput())
            {
                CustomerBEL customer = getValueInput();
                if (customerBAL.post(customer))
                {
                    addRowGrid(customer);
                    clearInput();
                };

            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dgvCustomer.Rows.Count - 1)
            {
                dgvCustomer.Rows[index].Selected = true;
            }
        }

        private void dgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0
                && dgvCustomer.SelectedRows[0].Index < dgvCustomer.Rows.Count - 1
                && dgvCustomer.SelectedRows[0].Index >= 0
            )
            {
                selectRow = dgvCustomer.SelectedRows[0].Index;
                loadInput(selectRow);
            }
            else
            {
                clearInput();
                selectRow = -1;
            }
        }

        private void buttonPut_Click(object sender, EventArgs e)
        {
            if (selectRow != -1)
            {
                if (validateInput())
                {
                    CustomerBEL customer = getValueInput();
                    customer.merge(getValueInput());
                    if (customerBAL.put(customer))
                    {
                        loadRowGrid(selectRow,customer);
                    };
                }
            }
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn kết thúc chương trình?", "Thông báo", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
