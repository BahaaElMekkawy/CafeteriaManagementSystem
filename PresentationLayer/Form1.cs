using System.ComponentModel;

using BusinessLogicLayer;
using BusinessLogicLayer.Managers.Order;
using System.Linq;

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
            items = ItemManager.GetAllItems().Where(I => I.IsAvailable && I.Stock > 0).ToList();
            MenuGridView.DataSource = items;
            MenuGridView.ReadOnly = true;
            MenuGridView.Columns["IsAvailable"].Visible = false;
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
    }
}