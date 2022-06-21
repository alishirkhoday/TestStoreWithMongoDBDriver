namespace TestStoreWithMongoDBDriver.UserInterface
{
    partial class frmSwitchBoard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCustomerManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGoodsManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInvoiceManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(282, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCustomerManagement,
            this.tsmGoodsManagement,
            this.tsmInvoiceManagement});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // tsmCustomerManagement
            // 
            this.tsmCustomerManagement.Name = "tsmCustomerManagement";
            this.tsmCustomerManagement.Size = new System.Drawing.Size(155, 26);
            this.tsmCustomerManagement.Text = "Customer";
            this.tsmCustomerManagement.Click += new System.EventHandler(this.tsmCustomerManagement_Click);
            // 
            // tsmGoodsManagement
            // 
            this.tsmGoodsManagement.Name = "tsmGoodsManagement";
            this.tsmGoodsManagement.Size = new System.Drawing.Size(155, 26);
            this.tsmGoodsManagement.Text = "Goods";
            this.tsmGoodsManagement.Click += new System.EventHandler(this.tsmGoodsManagement_Click);
            // 
            // tsmInvoiceManagement
            // 
            this.tsmInvoiceManagement.Name = "tsmInvoiceManagement";
            this.tsmInvoiceManagement.Size = new System.Drawing.Size(155, 26);
            this.tsmInvoiceManagement.Text = "Invoice";
            this.tsmInvoiceManagement.Click += new System.EventHandler(this.tsmInvoiceManagement_Click);
            // 
            // frmSwitchBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 153);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmSwitchBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Switch Board";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem managementToolStripMenuItem;
        private ToolStripMenuItem tsmCustomerManagement;
        private ToolStripMenuItem tsmGoodsManagement;
        private ToolStripMenuItem tsmInvoiceManagement;
    }
}