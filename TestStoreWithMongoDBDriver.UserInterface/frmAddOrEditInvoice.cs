using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using TestStoreWithMongoDBDriver.DomainModel.Entities;
using TestStoreWithMongoDBDriver.DomainModel.ListForDropDown;

namespace TestStoreWithMongoDBDriver.UserInterface
{
    public partial class frmAddOrEditInvoice : Form
    {
        private List<Goods> goodsList;
        public frmAddOrEditInvoice()
        {
            InitializeComponent();
            goodsList = new List<Goods>();
        }

        private IMongoCollection<Invoice> GetCollectionInvoice()
        {
            var client = new MongoClient();
            var db = client.GetDatabase("TestStore");
            var invoiceCollection = db.GetCollection<Invoice>("Invoices");
            return invoiceCollection;
        }

        private IMongoCollection<Customer> GetCollectionCustomer()
        {
            var client = new MongoClient();
            var db = client.GetDatabase("TestStore");
            var customerCollection = db.GetCollection<Customer>("Customers");
            return customerCollection;
        }

        private IMongoCollection<Goods> GetCollectionGoods()
        {
            var client = new MongoClient();
            var db = client.GetDatabase("TestStore");
            var goodsCollection = db.GetCollection<Goods>("Goods");
            return goodsCollection;
        }

        private void BindGrid()
        {
            var invoiceCollection = GetCollectionInvoice();
            var filter = new BsonDocument();
            var document = invoiceCollection.Find(filter).ToList();
            dgvListInvoices.AutoGenerateColumns = false;
            dgvListInvoices.DataSource = null;
            dgvListInvoices.DataSource = document;
            dataGridView1.DataSource = document;
        }

        private void BindComboBoxForCustomers()
        {
            var client = new MongoClient();
            var db = client.GetDatabase("TestStore");
            var customerCollection = db.GetCollection<Customer>("Customers");
            List<CustomersListItemForDropDown> customersListItemForDropDown = customerCollection.AsQueryable()
                .Select(x => new CustomersListItemForDropDown
                { CustomerId = x.Id, FullName = x.FirstName + " " + x.LastName }).ToList();
            customersListItemForDropDown.Insert(0, new CustomersListItemForDropDown
            { CustomerId = (-1).ToString(), FullName = "Choose Item" });
            cmbCustomers.ValueMember = "CustomerId";
            cmbCustomers.DisplayMember = "FullName";
            cmbCustomers.DataSource = customersListItemForDropDown;
        }

        private void BindComboBoxForGoods()
        {
            var client = new MongoClient();
            var db = client.GetDatabase("TestStore");
            var goodsCollection = db.GetCollection<Goods>("Goods");
            List<GoodsListItemForDropDown> goodsListItemForDropDowns = goodsCollection.AsQueryable()
                .Select(x => new GoodsListItemForDropDown
                { GoodsId = x.Id, Name = x.Name }).ToList();
            goodsListItemForDropDowns.Insert(0, new GoodsListItemForDropDown
            { GoodsId = (-1).ToString(), Name = "Choose Item" });
            cmbGoods.ValueMember = "GoodsId";
            cmbGoods.DisplayMember = "Name";
            cmbGoods.DataSource = goodsListItemForDropDowns;
        }

        private void ClearForm()
        {
            cmbCustomers.SelectedIndex = 0;
            cmbGoods.SelectedIndex = 0;
            cmbCustomers.Focus();
            btnAddOrEditInvoice.Text = "Add";
        }

        private List<Invoice> GetInvoiceBySearch(string parameter)
        {
            var invoiceCollection = GetCollectionInvoice();
            var query = invoiceCollection.AsQueryable().Where(x => x.Customer.FirstName.Contains(parameter)).ToList();
            return query;
        }

        private void BindSearchInInvoices()
        {
            dgvListInvoices.DataSource = GetInvoiceBySearch(txtSearch.Text);
        }

        private void frmAddOrEditInvoice_Load(object sender, EventArgs e)
        {
            BindGrid();
            BindComboBoxForCustomers();
            BindComboBoxForGoods();
        }

        private void btnAddOrEditInvoice_Click(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedIndex > 0)
            {
                if (btnAddOrEditInvoice.Text == "Add")
                {
                    var selectValueComboBoxCustomer = cmbCustomers.SelectedValue.ToString();
                    var customerCollection = GetCollectionCustomer();
                    var filter = Builders<Customer>.Filter.Eq("_id", ObjectId.Parse(selectValueComboBoxCustomer));
                    var itemCustomer = customerCollection.Find(filter).FirstOrDefault();
                    var customer = new Customer
                    {
                        Id = itemCustomer.Id,
                        FirstName = itemCustomer.FirstName,
                        LastName = itemCustomer.LastName,
                        MobileNumber = itemCustomer.MobileNumber
                    };
                    var invoiceCollection = GetCollectionInvoice();
                    var invoice = new Invoice
                    {
                        Customer = customer,
                        Goods = goodsList
                    };
                    invoiceCollection.InsertOne(invoice);
                    ClearForm();
                    BindGrid();
                }
                if (btnAddOrEditInvoice.Text == "Edit")
                {
                    var invoiceCollection = GetCollectionInvoice();
                    var invoiceUpdate = new Invoice
                    {
                        
                    };
                }
            }
            else
            {
                MessageBox.Show("Please Fill Form");
                cmbCustomers.Focus();
            }
        }

        private void btnCancelInvoice_Click(object sender, EventArgs e)
        {
            BindGrid();
            ClearForm();
        }

        private void dgvListInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                var invoiceCollection = GetCollectionInvoice();
                if (MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    int selectedRecordIndex = e.RowIndex;
                    var invoiceId = dgvListInvoices.Rows[selectedRecordIndex].Cells[0].Value.ToString();
                    if (invoiceId != null)
                    {
                        invoiceCollection.DeleteOne(c => c.Id == invoiceId);
                        MessageBox.Show("Delete");
                        BindGrid();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed delete");
                    }
                }
                else
                {
                    ClearForm();
                }
            }
            if (e.ColumnIndex == 2)
            {
                var invoiceCollection = GetCollectionInvoice();
                int selectedRecordIndex = e.RowIndex;
                var invoiceId = dgvListInvoices.Rows[selectedRecordIndex].Cells[0].Value.ToString();
                var filter = Builders<Invoice>.Filter.Eq("_id", ObjectId.Parse(invoiceId));
                var item = invoiceCollection.Find(filter).FirstOrDefault();
                if (item != null)
                {
                    btnAddOrEditInvoice.Text = "Edit";
                }
            }
        }

        private void btnAddGoodsInInvoice_Click(object sender, EventArgs e)
        {
            if (cmbGoods.SelectedIndex > 0)
            {
                var selectValueComboBoxGoods = cmbGoods.SelectedValue.ToString();
                var goodsCollection = GetCollectionGoods();
                var filter = Builders<Goods>.Filter.Eq("_id", ObjectId.Parse(selectValueComboBoxGoods));
                var itemGoods = goodsCollection.Find(filter).FirstOrDefault();
                var goods = new Goods
                {
                    Id = itemGoods.Id,
                    Name = itemGoods.Name,
                    UnitPrice = itemGoods.UnitPrice
                };
                goodsList.Add(goods);
                cmbGoods.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Please choose item");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var row = dataGridView1.CurrentRow.DataBoundItem;
            var invoice = (Invoice)row;
            dataGridView2.DataSource = new List<Customer> { invoice.Customer };
            dataGridView3.DataSource = invoice.Goods;
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            var i = GetCollectionInvoice();
            var index = Builders<Invoice>.IndexKeys.Ascending("Customer");
            //i.Indexes.CreateOneAsync(index);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindSearchInInvoices();
        }
    }
}
