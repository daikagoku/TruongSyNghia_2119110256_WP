
namespace TruongSyNghia.GUI.Department
{
    partial class DepartmentGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputId = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnPut = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.tooltipMes = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn vị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đơn vị";
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(13, 47);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(197, 23);
            this.inputId.TabIndex = 2;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(13, 110);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(197, 23);
            this.inputName.TabIndex = 3;
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.dgvDepartment.Location = new System.Drawing.Point(274, 13);
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.ReadOnly = true;
            this.dgvDepartment.RowTemplate.Height = 25;
            this.dgvDepartment.Size = new System.Drawing.Size(339, 410);
            this.dgvDepartment.TabIndex = 4;
            this.dgvDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartment_CellClick);
            this.dgvDepartment.SelectionChanged += new System.EventHandler(this.dgvDepartment_SelectionChanged);
            // 
            // id
            // 
            this.id.FillWeight = 1F;
            this.id.HeaderText = "Mã đơn vị";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.FillWeight = 2F;
            this.name.HeaderText = "Tên đơn vị";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(75, 181);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 5;
            this.btnPost.Text = "Thêm";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnPut
            // 
            this.btnPut.Location = new System.Drawing.Point(75, 211);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(75, 23);
            this.btnPut.TabIndex = 6;
            this.btnPut.Text = "Sửa";
            this.btnPut.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(75, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(75, 271);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 8;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // DepartmentGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 438);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPut);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.dgvDepartment);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DepartmentGUI";
            this.Text = "DepartmentGUI";
            this.Load += new System.EventHandler(this.DepartmentGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.ToolTip tooltipMes;
    }
}