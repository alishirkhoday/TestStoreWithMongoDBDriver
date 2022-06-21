using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestStoreWithMongoDBDriver.UserInterface
{
    public partial class frmSwitchBoard : Form
    {
        public frmSwitchBoard()
        {
            InitializeComponent();
        }

        private void tsmCustomerManagement_Click(object sender, EventArgs e)
        {
            frmAddOrEditCustomer frm = new frmAddOrEditCustomer();
            frm.ShowDialog();
        }

        private void tsmGoodsManagement_Click(object sender, EventArgs e)
        {
            frmAddOrEditGoods frm = new frmAddOrEditGoods();
            frm.ShowDialog();
        }

        private void tsmInvoiceManagement_Click(object sender, EventArgs e)
        {
            frmAddOrEditInvoice frm = new frmAddOrEditInvoice();
            frm.ShowDialog();
        }
    }
}
