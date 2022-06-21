namespace TestStoreWithMongoDBDriver.UserInterface
{
    partial class frmAddOrEditInvoice
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
            this.dgvListInvoices = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteInvoice = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEditInvoice = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbxInsertInvoice = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbGoods = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblGoods = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnIndex = new System.Windows.Forms.Button();
            this.btnCancelInvoice = new System.Windows.Forms.Button();
            this.btnAddGoodsInInvoice = new System.Windows.Forms.Button();
            this.btnAddOrEditInvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInvoices)).BeginInit();
            this.gbxInsertInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListInvoices
            // 
            this.dgvListInvoices.AllowUserToAddRows = false;
            this.dgvListInvoices.AllowUserToDeleteRows = false;
            this.dgvListInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.btnDeleteInvoice,
            this.btnEditInvoice});
            this.dgvListInvoices.Location = new System.Drawing.Point(6, 412);
            this.dgvListInvoices.Name = "dgvListInvoices";
            this.dgvListInvoices.ReadOnly = true;
            this.dgvListInvoices.RowHeadersWidth = 51;
            this.dgvListInvoices.RowTemplate.Height = 29;
            this.dgvListInvoices.Size = new System.Drawing.Size(396, 190);
            this.dgvListInvoices.TabIndex = 0;
            this.dgvListInvoices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListInvoices_CellContentClick);
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
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.HeaderText = "Delete";
            this.btnDeleteInvoice.MinimumWidth = 6;
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.ReadOnly = true;
            this.btnDeleteInvoice.Text = "Delete";
            this.btnDeleteInvoice.UseColumnTextForButtonValue = true;
            // 
            // btnEditInvoice
            // 
            this.btnEditInvoice.HeaderText = "Edit";
            this.btnEditInvoice.MinimumWidth = 6;
            this.btnEditInvoice.Name = "btnEditInvoice";
            this.btnEditInvoice.ReadOnly = true;
            this.btnEditInvoice.Text = "Edit";
            this.btnEditInvoice.UseColumnTextForButtonValue = true;
            // 
            // gbxInsertInvoice
            // 
            this.gbxInsertInvoice.Controls.Add(this.txtSearch);
            this.gbxInsertInvoice.Controls.Add(this.dgvListInvoices);
            this.gbxInsertInvoice.Controls.Add(this.dataGridView3);
            this.gbxInsertInvoice.Controls.Add(this.dataGridView2);
            this.gbxInsertInvoice.Controls.Add(this.dataGridView1);
            this.gbxInsertInvoice.Controls.Add(this.cmbGoods);
            this.gbxInsertInvoice.Controls.Add(this.lblSearch);
            this.gbxInsertInvoice.Controls.Add(this.lblGoods);
            this.gbxInsertInvoice.Controls.Add(this.cmbCustomers);
            this.gbxInsertInvoice.Controls.Add(this.lblCustomer);
            this.gbxInsertInvoice.Controls.Add(this.btnIndex);
            this.gbxInsertInvoice.Controls.Add(this.btnCancelInvoice);
            this.gbxInsertInvoice.Controls.Add(this.btnAddGoodsInInvoice);
            this.gbxInsertInvoice.Controls.Add(this.btnAddOrEditInvoice);
            this.gbxInsertInvoice.Location = new System.Drawing.Point(12, 12);
            this.gbxInsertInvoice.Name = "gbxInsertInvoice";
            this.gbxInsertInvoice.Size = new System.Drawing.Size(864, 607);
            this.gbxInsertInvoice.TabIndex = 2;
            this.gbxInsertInvoice.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(97, 247);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(222, 27);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(408, 412);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(450, 190);
            this.dataGridView3.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(408, 216);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(450, 190);
            this.dataGridView2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(408, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(450, 190);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // cmbGoods
            // 
            this.cmbGoods.FormattingEnabled = true;
            this.cmbGoods.Location = new System.Drawing.Point(97, 105);
            this.cmbGoods.Name = "cmbGoods";
            this.cmbGoods.Size = new System.Drawing.Size(222, 28);
            this.cmbGoods.TabIndex = 4;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(6, 250);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 20);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search";
            // 
            // lblGoods
            // 
            this.lblGoods.AutoSize = true;
            this.lblGoods.Location = new System.Drawing.Point(6, 108);
            this.lblGoods.Name = "lblGoods";
            this.lblGoods.Size = new System.Drawing.Size(52, 20);
            this.lblGoods.TabIndex = 3;
            this.lblGoods.Text = "Goods";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(97, 46);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(222, 28);
            this.cmbCustomers.TabIndex = 2;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(6, 49);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(72, 20);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Customer";
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(30, 170);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(120, 40);
            this.btnIndex.TabIndex = 0;
            this.btnIndex.Text = "Index";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // btnCancelInvoice
            // 
            this.btnCancelInvoice.Location = new System.Drawing.Point(156, 170);
            this.btnCancelInvoice.Name = "btnCancelInvoice";
            this.btnCancelInvoice.Size = new System.Drawing.Size(120, 40);
            this.btnCancelInvoice.TabIndex = 0;
            this.btnCancelInvoice.Text = "Cancel";
            this.btnCancelInvoice.UseVisualStyleBackColor = true;
            this.btnCancelInvoice.Click += new System.EventHandler(this.btnCancelInvoice_Click);
            // 
            // btnAddGoodsInInvoice
            // 
            this.btnAddGoodsInInvoice.Location = new System.Drawing.Point(325, 105);
            this.btnAddGoodsInInvoice.Name = "btnAddGoodsInInvoice";
            this.btnAddGoodsInInvoice.Size = new System.Drawing.Size(77, 28);
            this.btnAddGoodsInInvoice.TabIndex = 0;
            this.btnAddGoodsInInvoice.Text = "Add";
            this.btnAddGoodsInInvoice.UseVisualStyleBackColor = true;
            this.btnAddGoodsInInvoice.Click += new System.EventHandler(this.btnAddGoodsInInvoice_Click);
            // 
            // btnAddOrEditInvoice
            // 
            this.btnAddOrEditInvoice.Location = new System.Drawing.Point(282, 170);
            this.btnAddOrEditInvoice.Name = "btnAddOrEditInvoice";
            this.btnAddOrEditInvoice.Size = new System.Drawing.Size(120, 40);
            this.btnAddOrEditInvoice.TabIndex = 0;
            this.btnAddOrEditInvoice.Text = "Add";
            this.btnAddOrEditInvoice.UseVisualStyleBackColor = true;
            this.btnAddOrEditInvoice.Click += new System.EventHandler(this.btnAddOrEditInvoice_Click);
            // 
            // frmAddOrEditInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 631);
            this.Controls.Add(this.gbxInsertInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddOrEditInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Invoice Management";
            this.Load += new System.EventHandler(this.frmAddOrEditInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInvoices)).EndInit();
            this.gbxInsertInvoice.ResumeLayout(false);
            this.gbxInsertInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dgvListInvoices;
        private GroupBox gbxInsertInvoice;
        private ComboBox cmbCustomers;
        private Label lblCustomer;
        private Button btnCancelInvoice;
        private Button btnAddOrEditInvoice;
        private ComboBox cmbGoods;
        private Label lblGoods;
        private Button btnAddGoodsInInvoice;
        private DataGridViewTextBoxColumn clmId;
        private DataGridViewButtonColumn btnDeleteInvoice;
        private DataGridViewButtonColumn btnEditInvoice;
        private DataGridView dataGridView1;
        private DataGridView dataGridView3;
        private DataGridView dataGridView2;
        private Button btnIndex;
        private TextBox txtSearch;
        private Label lblSearch;
    }
}