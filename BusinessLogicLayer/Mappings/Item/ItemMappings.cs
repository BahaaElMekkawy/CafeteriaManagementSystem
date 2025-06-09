using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public static class ItemMappings
    {
        public static Item FromDataRowToItem(DataRow row) 
        {
            Item item = new Item();
            int.TryParse(row["Id"]?.ToString()??"-1" , out int id);
            item.Id = id;

            string name = row["Name"]?.ToString()!;
            item.Name =name ;

            double.TryParse(row["Price"]?.ToString(), out double price);
            item.Price = price;

            string description = row["Description"]?.ToString()??"";
            item.Description = description;

            bool.TryParse( row["IsAvailable"]?.ToString(),out bool isAvailable);
            item.IsAvailable = isAvailable;

            int.TryParse(row["Stock"]?.ToString() ?? "-1", out int stock);
            item.Stock = stock;

            return item;
        }

        public static List<Item> FromDataTableToItemsList(DataTable table) 
        {
            List<Item> itemList = new List<Item>();
            foreach (DataRow row in table.Rows)
            {
                if (row is not null)
                    itemList.Add(FromDataRowToItem(row));
            }
            return itemList;
        }
    }
}
