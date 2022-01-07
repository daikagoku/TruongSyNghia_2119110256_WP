
namespace TruongSyNghia_Entity.GUI.Customer
{
    partial class CustomerGUI
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
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonOut = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonPut = new System.Windows.Forms.Button();
            this.buttonPost = new System.Windows.Forms.Button();
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.inputId = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.groupInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.dgvCustomer.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(776, 257);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            this.dgvCustomer.SelectionChanged += new System.EventHandler(this.dgvCustomer_SelectionChanged);
            // 
            // id
            // 
            this.id.FillWeight = 1F;
            this.id.HeaderText = "Mã NV";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.FillWeight = 3F;
            this.name.HeaderText = "Họ tên";
            this.name.Name = "name";
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(713, 415);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(75, 23);
            this.buttonOut.TabIndex = 1;
            this.buttonOut.Text = "Thoát";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(498, 415);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonPut
            // 
            this.buttonPut.Location = new System.Drawing.Point(606, 415);
            this.buttonPut.Name = "buttonPut";
            this.buttonPut.Size = new System.Drawing.Size(75, 23);
            this.buttonPut.TabIndex = 2;
            this.buttonPut.Text = "Sửa";
            this.buttonPut.UseVisualStyleBackColor = true;
            this.buttonPut.Click += new System.EventHandler(this.buttonPut_Click);
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(389, 415);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 3;
            this.buttonPost.Text = "Thêm";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // groupInput
            // 
            this.groupInput.Controls.Add(this.label2);
            this.groupInput.Controls.Add(this.label1);
            this.groupInput.Controls.Add(this.inputName);
            this.groupInput.Controls.Add(this.inputId);
            this.groupInput.Location = new System.Drawing.Point(13, 285);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(775, 113);
            this.groupInput.TabIndex = 4;
            this.groupInput.TabStop = false;
            this.groupInput.Text = "Thông tin nhân viên";
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(133, 20);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(100, 20);
            this.inputId.TabIndex = 0;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(133, 47);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(318, 20);
            this.inputName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên";
            // 
            // CustomerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupInput);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.buttonPut);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.dgvCustomer);
            this.Name = "CustomerGUI";
            this.Text = "CustomerGUI";
            this.Load += new System.EventHandler(this.CustomerGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.groupInput.ResumeLayout(false);
            this.groupInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPut;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}