using System.Windows.Forms;
using System.Xml.Linq;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Item> items = new List<Item>();
            items = ItemManager.GetAllItems().Where(I => I.IsAvailable).ToList();
            var itemsToView = items.Select(I => new
            {
                I.Id,
                I.Name,
                I.Price,
                I.Description,
                I.Stock
            }).ToList();
            MenuGridView.DataSource = itemsToView;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void PriceTxtBox_Click(object sender, EventArgs e)
        {

        }

        private void MenuGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = MenuGridView.Rows[e.RowIndex];

            var name = row.Cells["Name"].Value?.ToString();
            var price = row.Cells["Price"].Value?.ToString();

            txtBoxItemName.Text = name;
            txtBoxItemPrice.Text = price?.ToString();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
