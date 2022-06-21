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

namespace TestStoreWithMongoDBDriver.UserInterface
{
    public partial class frmAddOrEditGoods : Form
    {
        
        public frmAddOrEditGoods()
        {
            InitializeComponent();
        }

        private IMongoCollection<Goods> GetCollection()
        {
            var client = new MongoClient();
            var db = client.GetDatabase("TestStore");
            var goodsCollection = db.GetCollection<Goods>("Goods");
            return goodsCollection;
        }

        private void BindGrid()
        {
            var goodsCollection = GetCollection();
            var filter = new BsonDocument();
            var document = goodsCollection.Find(filter).ToList();
            dgvListGoods.AutoGenerateColumns = false;
            dgvListGoods.DataSource = null;
            dgvListGoods.DataSource = document;
        }

        private void ClearForm()
        {
            txtName.Text = "";
            numUnitPrice.Value = 0;
            txtName.Focus();
            btnAddOrEditGoods.Text = "Add";
        }

        private void frmAddOrEditGoods_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnAddOrEditGoods_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && numUnitPrice.Value > 0)
            {
                if (btnAddOrEditGoods.Text == "Add")
                {
                    var goodsCollection = GetCollection();
                    var goods = new Goods
                    {
                        Name = txtName.Text,
                        UnitPrice = Convert.ToInt32(numUnitPrice.Value)
                    };
                    goodsCollection.InsertOne(goods);
                    ClearForm();
                    BindGrid();
                }

                if (btnAddOrEditGoods.Text == "Edit")
                {
                    var goodsCollection = GetCollection();
                    var goodsUpdate = new Goods
                    {
                        Id = dgvListGoods.CurrentRow.Cells[0].Value.ToString(),
                        Name = txtName.Text,
                        UnitPrice = Convert.ToInt32(numUnitPrice.Value)
                    };
                    var goodsId = dgvListGoods.CurrentRow.Cells[0].Value.ToString();
                    var filter = Builders<Goods>.Filter.Eq("_id", ObjectId.Parse(goodsId));
                    var update = Builders<Goods>.Update
                        .Set("Name", goodsUpdate.Name)
                        .Set("UnitPrice", goodsUpdate.UnitPrice);
                    goodsCollection.UpdateOne(filter, update);
                    ClearForm();
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("Please Fill Form");
                txtName.Focus();
            }
        }

        private void btnCancelGoods_Click(object sender, EventArgs e)
        {
            BindGrid();
            ClearForm();
        }

        private void dgvListGoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var goodsCollection = GetCollection();
                string goodsName = dgvListGoods.CurrentRow.Cells[1].Value.ToString();
                if (MessageBox.Show("Are you sure you want to delete " + goodsName + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    int selectedRecordIndex = e.RowIndex;
                    var goodsId = dgvListGoods.Rows[selectedRecordIndex].Cells[0].Value.ToString();
                    if (goodsId != null)
                    {
                        goodsCollection.DeleteOne(c => c.Id == goodsId);
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
            if (e.ColumnIndex == 4)
            {
                var goodsCollection = GetCollection();
                int selectedRecordIndex = e.RowIndex;
                var goodsId = dgvListGoods.Rows[selectedRecordIndex].Cells[0].Value.ToString();
                var filter = Builders<Goods>.Filter.Eq("_id", ObjectId.Parse(goodsId));
                var item = goodsCollection.Find(filter).FirstOrDefault();
                if (item != null)
                {
                    txtName.Text = item.Name;
                    numUnitPrice.Value = item.UnitPrice;
                    btnAddOrEditGoods.Text = "Edit";
                }
            }
        }
    }
}
