using MongoDB.Bson;
using MongoDB.Driver;
using TestStoreWithMongoDBDriver.DomainModel.Entities;

namespace TestStoreWithMongoDBDriver.UserInterface
{
    public partial class frmAddOrEditCustomer : Form
    {
        public frmAddOrEditCustomer()
        {
            InitializeComponent();
        }

        private IMongoCollection<Customer> GetCollection()
        {
            var client = new MongoClient();
            var db = client.GetDatabase("TestStore");
            var customerCollection = db.GetCollection<Customer>("Customers");
            return customerCollection;
        }

        private void BindGrid()
        {
            var client = new MongoClient();
            var db = client.GetDatabase("TestStore");
            var customerCollection = db.GetCollection<Customer>("Customers");
            var filter = new BsonDocument();
            var document = customerCollection.Find(filter).ToList();
            dgvListCustomers.AutoGenerateColumns = false;
            dgvListCustomers.DataSource = null;
            dgvListCustomers.DataSource = document;
        }

        private void ClearForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMobileNumber.Text = "";
            txtFirstName.Focus();
            btnAddOrEditCustomer.Text = "Add";
        }

        private void frmAddOrEditCustomer_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnAddOrEditCustomer_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtMobileNumber.Text != "")
            {
                if (btnAddOrEditCustomer.Text == "Add")
                {

                    var customerCollection = GetCollection();
                    var customerInsert = new Customer
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        MobileNumber = txtMobileNumber.Text
                    };
                    customerCollection.InsertOne(customerInsert);
                    ClearForm();
                    BindGrid();
                }
                if (btnAddOrEditCustomer.Text == "Edit")
                {
                    var customerCollection = GetCollection();
                    var customerUpdate = new Customer
                    {
                        Id = dgvListCustomers.CurrentRow.Cells[0].Value.ToString(),
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        MobileNumber = txtMobileNumber.Text
                    };
                    var customerId = dgvListCustomers.CurrentRow.Cells[0].Value.ToString();
                    var filter = Builders<Customer>.Filter.Eq("_id", ObjectId.Parse(customerId));
                    var update = Builders<Customer>.Update
                        .Set("FirstName", customerUpdate.FirstName)
                        .Set("LastName", customerUpdate.LastName)
                        .Set("MobileNumber", customerUpdate.MobileNumber);
                    customerCollection.UpdateOne(filter, update);
                    ClearForm();
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("Please fill form");
                txtFirstName.Focus();
            }
        }

        private void btnCancelCustomer_Click(object sender, EventArgs e)
        {
            BindGrid();
            ClearForm();
        }

        private void dgvListCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                string firstName = dgvListCustomers.CurrentRow.Cells[1].Value.ToString();
                string lastName = dgvListCustomers.CurrentRow.Cells[2].Value.ToString();
                string FN = firstName + " " + lastName;
                if (MessageBox.Show("Are you sure you want to delete " + FN + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    var customerCollection = GetCollection();
                    int selectedRecordIndex = e.RowIndex;
                    var customerId = dgvListCustomers.Rows[selectedRecordIndex].Cells[0].Value.ToString();
                    if (customerId != null)
                    {
                        customerCollection.DeleteOne(c => c.Id == customerId);
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
                    BindGrid();
                }
            }
            if (e.ColumnIndex == 5)
            {
                var customerCollection = GetCollection();
                int selectedRecordIndex = e.RowIndex;
                var customerId = dgvListCustomers.Rows[selectedRecordIndex].Cells[0].Value.ToString();
                var filter = Builders<Customer>.Filter.Eq("_id", ObjectId.Parse(customerId));
                var item = customerCollection.Find(filter).FirstOrDefault();
                if (item != null)
                {
                    txtFirstName.Text = item.FirstName;
                    txtLastName.Text = item.LastName;
                    txtMobileNumber.Text = item.MobileNumber;
                    btnAddOrEditCustomer.Text = "Edit";
                }
            }
        }
    }
}
