namespace TestStoreWithMongoDBDriver.UserInterface
{
    partial class frmAddOrEditCustomer
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
            this.gbxAddOrEditCustomer = new System.Windows.Forms.GroupBox();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMobileNumber = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnCancelCustomer = new System.Windows.Forms.Button();
            this.btnAddOrEditCustomer = new System.Windows.Forms.Button();
            this.gbxListCustomers = new System.Windows.Forms.GroupBox();
            this.dgvListCustomers = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbxAddOrEditCustomer.SuspendLayout();
            this.gbxListCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAddOrEditCustomer
            // 
            this.gbxAddOrEditCustomer.Controls.Add(this.txtMobileNumber);
            this.gbxAddOrEditCustomer.Controls.Add(this.txtLastName);
            this.gbxAddOrEditCustomer.Controls.Add(this.txtFirstName);
            this.gbxAddOrEditCustomer.Controls.Add(this.lblMobileNumber);
            this.gbxAddOrEditCustomer.Controls.Add(this.lblLastName);
            this.gbxAddOrEditCustomer.Controls.Add(this.lblFirstName);
            this.gbxAddOrEditCustomer.Controls.Add(this.btnCancelCustomer);
            this.gbxAddOrEditCustomer.Controls.Add(this.btnAddOrEditCustomer);
            this.gbxAddOrEditCustomer.Location = new System.Drawing.Point(12, 12);
            this.gbxAddOrEditCustomer.Name = "gbxAddOrEditCustomer";
            this.gbxAddOrEditCustomer.Size = new System.Drawing.Size(658, 243);
            this.gbxAddOrEditCustomer.TabIndex = 0;
            this.gbxAddOrEditCustomer.TabStop = false;
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(182, 149);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(470, 27);
            this.txtMobileNumber.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(182, 84);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(470, 27);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(182, 27);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(470, 27);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblMobileNumber
            // 
            this.lblMobileNumber.AutoSize = true;
            this.lblMobileNumber.Location = new System.Drawing.Point(6, 152);
            this.lblMobileNumber.Name = "lblMobileNumber";
            this.lblMobileNumber.Size = new System.Drawing.Size(114, 20);
            this.lblMobileNumber.TabIndex = 7;
            this.lblMobileNumber.Text = "Mobile Number";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 87);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(79, 20);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 30);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 20);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name";
            // 
            // btnCancelCustomer
            // 
            this.btnCancelCustomer.Location = new System.Drawing.Point(446, 207);
            this.btnCancelCustomer.Name = "btnCancelCustomer";
            this.btnCancelCustomer.Size = new System.Drawing.Size(100, 30);
            this.btnCancelCustomer.TabIndex = 4;
            this.btnCancelCustomer.Text = "Cancel";
            this.btnCancelCustomer.UseVisualStyleBackColor = true;
            this.btnCancelCustomer.Click += new System.EventHandler(this.btnCancelCustomer_Click);
            // 
            // btnAddOrEditCustomer
            // 
            this.btnAddOrEditCustomer.Location = new System.Drawing.Point(552, 207);
            this.btnAddOrEditCustomer.Name = "btnAddOrEditCustomer";
            this.btnAddOrEditCustomer.Size = new System.Drawing.Size(100, 30);
            this.btnAddOrEditCustomer.TabIndex = 3;
            this.btnAddOrEditCustomer.Text = "Add";
            this.btnAddOrEditCustomer.UseVisualStyleBackColor = true;
            this.btnAddOrEditCustomer.Click += new System.EventHandler(this.btnAddOrEditCustomer_Click);
            // 
            // gbxListCustomers
            // 
            this.gbxListCustomers.Controls.Add(this.dgvListCustomers);
            this.gbxListCustomers.Location = new System.Drawing.Point(12, 261);
            this.gbxListCustomers.Name = "gbxListCustomers";
            this.gbxListCustomers.Size = new System.Drawing.Size(658, 180);
            this.gbxListCustomers.TabIndex = 1;
            this.gbxListCustomers.TabStop = false;
            // 
            // dgvListCustomers
            // 
            this.dgvListCustomers.AllowUserToAddRows = false;
            this.dgvListCustomers.AllowUserToDeleteRows = false;
            this.dgvListCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmFirstName,
            this.clmLastName,
            this.clmMobileNumber,
            this.dataGridViewButtonColumn1,
            this.btnEdit});
            this.dgvListCustomers.Location = new System.Drawing.Point(3, 23);
            this.dgvListCustomers.Name = "dgvListCustomers";
            this.dgvListCustomers.ReadOnly = true;
            this.dgvListCustomers.RowHeadersWidth = 51;
            this.dgvListCustomers.RowTemplate.Height = 29;
            this.dgvListCustomers.Size = new System.Drawing.Size(649, 151);
            this.dgvListCustomers.TabIndex = 0;
            this.dgvListCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCustomers_CellContentClick);
            // 
            // clmId
            // 
            this.clmId.DataPropertyName = "id";
            this.clmId.HeaderText = "Id";
            this.clmId.MinimumWidth = 6;
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Visible = false;
            // 
            // clmFirstName
            // 
            this.clmFirstName.DataPropertyName = "FirstName";
            this.clmFirstName.HeaderText = "First Name";
            this.clmFirstName.MinimumWidth = 6;
            this.clmFirstName.Name = "clmFirstName";
            this.clmFirstName.ReadOnly = true;
            // 
            // clmLastName
            // 
            this.clmLastName.DataPropertyName = "LastName";
            this.clmLastName.HeaderText = "Last Name";
            this.clmLastName.MinimumWidth = 6;
            this.clmLastName.Name = "clmLastName";
            this.clmLastName.ReadOnly = true;
            // 
            // clmMobileNumber
            // 
            this.clmMobileNumber.DataPropertyName = "MobileNumber";
            this.clmMobileNumber.HeaderText = "Mobile Number";
            this.clmMobileNumber.MinimumWidth = 6;
            this.clmMobileNumber.Name = "clmMobileNumber";
            this.clmMobileNumber.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Delete";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Delete";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Edit";
            this.btnEdit.MinimumWidth = 6;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseColumnTextForButtonValue = true;
            // 
            // frmAddOrEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.gbxListCustomers);
            this.Controls.Add(this.gbxAddOrEditCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddOrEditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Management";
            this.Load += new System.EventHandler(this.frmAddOrEditCustomer_Load);
            this.gbxAddOrEditCustomer.ResumeLayout(false);
            this.gbxAddOrEditCustomer.PerformLayout();
            this.gbxListCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbxAddOrEditCustomer;
        private TextBox txtMobileNumber;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblMobileNumber;
        private Label lblLastName;
        private Label lblFirstName;
        private Button btnCancelCustomer;
        private Button btnAddOrEditCustomer;
        private GroupBox gbxListCustomers;
        private DataGridView dgvListCustomers;
        private DataGridViewTextBoxColumn clmId;
        private DataGridViewTextBoxColumn clmFirstName;
        private DataGridViewTextBoxColumn clmLastName;
        private DataGridViewTextBoxColumn clmMobileNumber;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn btnEdit;
    }
}