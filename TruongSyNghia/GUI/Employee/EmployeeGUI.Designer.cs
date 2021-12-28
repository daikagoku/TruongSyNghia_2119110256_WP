
namespace TruongSyNghia.GUI.Employee
{
    partial class EmployeeGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.place_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnPut = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputDepartment = new System.Windows.Forms.ComboBox();
            this.inputId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputPlace = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputGender = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputDate = new System.Windows.Forms.DateTimePicker();
            this.inputDepartmentSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDepartmentSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.date_birth,
            this.gender,
            this.place_birth,
            this.department_name});
            this.dgvEmployee.Location = new System.Drawing.Point(13, 110);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowTemplate.Height = 25;
            this.dgvEmployee.Size = new System.Drawing.Size(936, 280);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartment_CellClick);
            this.dgvEmployee.SelectionChanged += new System.EventHandler(this.dgvDepartment_SelectionChanged);
            // 
            // id
            // 
            this.id.FillWeight = 1F;
            this.id.HeaderText = "Mã";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.FillWeight = 2F;
            this.name.HeaderText = "Họ tên";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // date_birth
            // 
            this.date_birth.FillWeight = 1F;
            this.date_birth.HeaderText = "Ngày sinh";
            this.date_birth.Name = "date_birth";
            this.date_birth.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.FillWeight = 1F;
            this.gender.HeaderText = "Giới tính";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // place_birth
            // 
            this.place_birth.FillWeight = 3F;
            this.place_birth.HeaderText = "Nơi sinh";
            this.place_birth.Name = "place_birth";
            this.place_birth.ReadOnly = true;
            // 
            // department_name
            // 
            this.department_name.FillWeight = 2F;
            this.department_name.HeaderText = "Đơn vị";
            this.department_name.Name = "department_name";
            this.department_name.ReadOnly = true;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(874, 415);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnPut
            // 
            this.btnPut.Location = new System.Drawing.Point(772, 415);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(75, 23);
            this.btnPut.TabIndex = 2;
            this.btnPut.Text = "Sữa";
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(670, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(563, 415);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 4;
            this.btnPost.Text = "Thêm";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đơn vị";
            // 
            // inputDepartment
            // 
            this.inputDepartment.FormattingEnabled = true;
            this.inputDepartment.Location = new System.Drawing.Point(74, 51);
            this.inputDepartment.Name = "inputDepartment";
            this.inputDepartment.Size = new System.Drawing.Size(121, 23);
            this.inputDepartment.TabIndex = 7;
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(74, 13);
            this.inputId.Name = "inputId";
            this.inputId.ReadOnly = true;
            this.inputId.Size = new System.Drawing.Size(121, 23);
            this.inputId.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nơi sinh";
            // 
            // inputPlace
            // 
            this.inputPlace.Location = new System.Drawing.Point(312, 51);
            this.inputPlace.Name = "inputPlace";
            this.inputPlace.Size = new System.Drawing.Size(637, 23);
            this.inputPlace.TabIndex = 11;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(312, 13);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(257, 23);
            this.inputName.TabIndex = 12;
            // 
            // inputGender
            // 
            this.inputGender.AutoSize = true;
            this.inputGender.Location = new System.Drawing.Point(838, 13);
            this.inputGender.Name = "inputGender";
            this.inputGender.Size = new System.Drawing.Size(100, 19);
            this.inputGender.TabIndex = 13;
            this.inputGender.Text = "Giới tính Nam";
            this.inputGender.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày sinh";
            // 
            // inputDate
            // 
            this.inputDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputDate.Location = new System.Drawing.Point(670, 12);
            this.inputDate.Name = "inputDate";
            this.inputDate.Size = new System.Drawing.Size(137, 23);
            this.inputDate.TabIndex = 15;
            // 
            // inputDepartmentSource
            // 
            this.inputDepartmentSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.inputDepartmentSource_ListChanged);
            // 
            // EmployeeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.inputDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputGender);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputPlace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.inputDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPut);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "EmployeeGUI";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.EmployeeGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDepartmentSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox inputDepartment;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputPlace;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.CheckBox inputGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker inputDate;
        private System.Windows.Forms.BindingSource inputDepartmentSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_birth;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn place_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_name;
    }
}