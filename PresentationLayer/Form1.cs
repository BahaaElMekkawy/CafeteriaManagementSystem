using System.ComponentModel;

using BusinessLogicLayer;
using BusinessLogicLayer.Managers.Order;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        BindingList<OrderItems> orderItems = new BindingList<OrderItems>();
        List<Item> items = new List<Item>();
        int currentOrderId = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMenuItems();
            ConfigureOrderGridView();
        }

        private void LoadMenuItems()
        {
            items = ItemManager.GetAllItems().Where(I => I.Stock > 0).ToList();
            MenuGridView.DataSource = items;
            MenuGridView.ReadOnly = true;
            MenuGridView.Columns["IsAvailable"].Visible = false;
            MenuGridView.EnableHeadersVisualStyles = false; // Important to allow custom styles
            MenuGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            MenuGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            MenuGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MenuGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

        }

        private void ConfigureOrderGridView()
        {
            orderGridView.DataSource = orderItems;
            orderGridView.ReadOnly = true;
            orderGridView.Columns["Id"].Visible = false;
            orderGridView.Columns["IsAvailable"].Visible = false;
            orderGridView.Columns["Stock"].Visible = false;
            orderGridView.Columns["Description"].Visible = false;
            orderGridView.Columns["OrderId"].Visible = false;


            orderGridView.Columns["Name"].DisplayIndex = 0;
            orderGridView.Columns["Price"].DisplayIndex = 1;
            orderGridView.Columns["Quantity"].DisplayIndex = 2;
            orderGridView.Columns["Total"].DisplayIndex = 3;

            orderGridView.EnableHeadersVisualStyles = false; // Important to allow custom styles
            orderGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            orderGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            orderGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void MenuGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = MenuGridView.Rows[e.RowIndex];
            txtBoxItemName.Text = row.Cells["Name"].Value?.ToString();
            txtBoxItemPrice.Text = row.Cells["Price"].Value?.ToString();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (MenuGridView.CurrentRow == null) return;

            Item selectedItem = (Item)MenuGridView.CurrentRow.DataBoundItem;

            if (selectedItem.Stock <= 0)
            {
                MessageBox.Show("This item is out of stock!");
                return;
            }

            selectedItem.Stock--;

            var existingOrderItem = orderItems.FirstOrDefault(i => i.Id == selectedItem.Id);
            if (existingOrderItem != null)
            {
                existingOrderItem.Quantity++;
            }
            else
            {
                orderItems.Add(new OrderItems
                {
                    Id = selectedItem.Id,
                    Name = selectedItem.Name,
                    Price = selectedItem.Price,
                    Quantity = 1,
                });
            }

            MenuGridView.DataSource = null;
            MenuGridView.DataSource = items.Where(I => I.IsAvailable && I.Stock > 0).ToList();
            MenuGridView.Columns["IsAvailable"].Visible = false;
            LoadMenuItems();

            MenuGridView.Refresh();

            txtBoxTotalPrice.Text = orderItems.Sum(item => item.Total).ToString("F2");
            orderGridView.Refresh();

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (orderItems.Count == 0)
            {
                MessageBox.Show("No items in the order.");
                return;
            }

            if (currentOrderId == 0)
            {
                currentOrderId = OrderManager.InsertOrder();
            }

            foreach (var orderItem in orderItems)
            {
                for (int i = 0; i < orderItem.Quantity; i++)
                {
                    OrderManager.AddOrderItems(currentOrderId, orderItem.Id);
                }
            }

            MessageBox.Show("Order Placed Successfully!");

            orderItems.Clear();
            LoadMenuItems();
            orderGridView.Refresh();
            currentOrderId = 0;
            txtBoxTotalPrice.Text = "0.00";
        }

        private void txtBoxTotalPrice_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void PriceTxtBox_Click(object sender, EventArgs e) { }

        private void itemTxtBoxLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = txtAddName.Text;
            string Desc = txtAddDesc.Text;
            decimal price = numAddPrice.Value;
            int stock = (int)NumAddStock.Value;

            if (name == "" || price == 0 || stock == 0)
            {
                MessageBox.Show("You Must Enter The Whole Data");
                return;
            }
            else {
                ItemManager.InsertItem(name, price, stock, Desc);
                txtAddName.Text = "";
                txtAddDesc.Text = "";
                numAddPrice.Value = 0;
                NumAddStock.Value = 0;
                LoadMenuItems();
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MenuGridView.CurrentRow == null) return;

            Item selectedItem = (Item)MenuGridView.CurrentRow.DataBoundItem;

            ItemManager.DeleteItem(selectedItem.Id);
            LoadMenuItems();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}