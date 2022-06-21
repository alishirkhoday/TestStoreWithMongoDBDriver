namespace TestStoreWithMongoDBDriver.UserInterface
{
    partial class frmAddOrEditGoods
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
            this.gbxAddOrEditGoods = new System.Windows.Forms.GroupBox();
            this.numUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancelGoods = new System.Windows.Forms.Button();
            this.btnAddOrEditGoods = new System.Windows.Forms.Button();
            this.gbxListGoods = new System.Windows.Forms.GroupBox();
            this.dgvListGoods = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteGoods = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEditGoods = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbxAddOrEditGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).BeginInit();
            this.gbxListGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAddOrEditGoods
            // 
            this.gbxAddOrEditGoods.Controls.Add(this.numUnitPrice);
            this.gbxAddOrEditGoods.Controls.Add(this.txtName);
            this.gbxAddOrEditGoods.Controls.Add(this.lblUnitPrice);
            this.gbxAddOrEditGoods.Controls.Add(this.lblName);
            this.gbxAddOrEditGoods.Controls.Add(this.btnCancelGoods);
            this.gbxAddOrEditGoods.Controls.Add(this.btnAddOrEditGoods);
            this.gbxAddOrEditGoods.Location = new System.Drawing.Point(12, 12);
            this.gbxAddOrEditGoods.Name = "gbxAddOrEditGoods";
            this.gbxAddOrEditGoods.Size = new System.Drawing.Size(658, 178);
            this.gbxAddOrEditGoods.TabIndex = 0;
            this.gbxAddOrEditGoods.TabStop = false;
            // 
            // numUnitPrice
            // 
            this.numUnitPrice.Location = new System.Drawing.Point(197, 85);
            this.numUnitPrice.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numUnitPrice.Name = "numUnitPrice";
            this.numUnitPrice.Size = new System.Drawing.Size(455, 27);
            this.numUnitPrice.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(197, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(455, 27);
            this.txtName.TabIndex = 0;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(6, 87);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.lblUnitPrice.TabIndex = 5;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // btnCancelGoods
            // 
            this.btnCancelGoods.Location = new System.Drawing.Point(446, 142);
            this.btnCancelGoods.Name = "btnCancelGoods";
            this.btnCancelGoods.Size = new System.Drawing.Size(100, 30);
            this.btnCancelGoods.TabIndex = 3;
            this.btnCancelGoods.Text = "Cancel";
            this.btnCancelGoods.UseVisualStyleBackColor = true;
            this.btnCancelGoods.Click += new System.EventHandler(this.btnCancelGoods_Click);
            // 
            // btnAddOrEditGoods
            // 
            this.btnAddOrEditGoods.Location = new System.Drawing.Point(552, 142);
            this.btnAddOrEditGoods.Name = "btnAddOrEditGoods";
            this.btnAddOrEditGoods.Size = new System.Drawing.Size(100, 30);
            this.btnAddOrEditGoods.TabIndex = 2;
            this.btnAddOrEditGoods.Text = "Add";
            this.btnAddOrEditGoods.UseVisualStyleBackColor = true;
            this.btnAddOrEditGoods.Click += new System.EventHandler(this.btnAddOrEditGoods_Click);
            // 
            // gbxListGoods
            // 
            this.gbxListGoods.Controls.Add(this.dgvListGoods);
            this.gbxListGoods.Location = new System.Drawing.Point(12, 196);
            this.gbxListGoods.Name = "gbxListGoods";
            this.gbxListGoods.Size = new System.Drawing.Size(658, 181);
            this.gbxListGoods.TabIndex = 2;
            this.gbxListGoods.TabStop = false;
            // 
            // dgvListGoods
            // 
            this.dgvListGoods.AllowUserToAddRows = false;
            this.dgvListGoods.AllowUserToDeleteRows = false;
            this.dgvListGoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmName,
            this.clmUnitPrice,
            this.btnDeleteGoods,
            this.btnEditGoods});
            this.dgvListGoods.Location = new System.Drawing.Point(3, 23);
            this.dgvListGoods.Name = "dgvListGoods";
            this.dgvListGoods.ReadOnly = true;
            this.dgvListGoods.RowHeadersWidth = 51;
            this.dgvListGoods.RowTemplate.Height = 29;
            this.dgvListGoods.Size = new System.Drawing.Size(649, 152);
            this.dgvListGoods.TabIndex = 0;
            this.dgvListGoods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListGoods_CellContentClick);
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
            // clmName
            // 
            this.clmName.DataPropertyName = "Name";
            this.clmName.HeaderText = "Name";
            this.clmName.MinimumWidth = 6;
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmUnitPrice
            // 
            this.clmUnitPrice.DataPropertyName = "UnitPrice";
            this.clmUnitPrice.HeaderText = "Unit Price";
            this.clmUnitPrice.MinimumWidth = 6;
            this.clmUnitPrice.Name = "clmUnitPrice";
            this.clmUnitPrice.ReadOnly = true;
            // 
            // btnDeleteGoods
            // 
            this.btnDeleteGoods.HeaderText = "Delete";
            this.btnDeleteGoods.MinimumWidth = 6;
            this.btnDeleteGoods.Name = "btnDeleteGoods";
            this.btnDeleteGoods.ReadOnly = true;
            this.btnDeleteGoods.Text = "Delete";
            this.btnDeleteGoods.UseColumnTextForButtonValue = true;
            // 
            // btnEditGoods
            // 
            this.btnEditGoods.HeaderText = "Edit";
            this.btnEditGoods.MinimumWidth = 6;
            this.btnEditGoods.Name = "btnEditGoods";
            this.btnEditGoods.ReadOnly = true;
            this.btnEditGoods.Text = "Edit";
            this.btnEditGoods.UseColumnTextForButtonValue = true;
            // 
            // frmAddOrEditGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 389);
            this.Controls.Add(this.gbxListGoods);
            this.Controls.Add(this.gbxAddOrEditGoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddOrEditGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Goods Management";
            this.Load += new System.EventHandler(this.frmAddOrEditGoods_Load);
            this.gbxAddOrEditGoods.ResumeLayout(false);
            this.gbxAddOrEditGoods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitPrice)).EndInit();
            this.gbxListGoods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbxAddOrEditGoods;
        private TextBox txtName;
        private Label lblUnitPrice;
        private Label lblName;
        private Button btnCancelGoods;
        private Button btnAddOrEditGoods;
        private NumericUpDown numUnitPrice;
        private GroupBox gbxListGoods;
        private DataGridView dgvListGoods;
        private DataGridViewTextBoxColumn clmId;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmUnitPrice;
        private DataGridViewButtonColumn btnDeleteGoods;
        private DataGridViewButtonColumn btnEditGoods;
    }
}