using System;
using System.Collections.Generic;
using System.Data;

using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class ItemManager
    {
        public static List<Item> GetAllItems()
        {
            List<Item> items = new List<Item>();
            DataTable table = ApplicationDB.GetDataTable("SELECT * FROM Items");
            items = ItemMappings.FromDataTableToItemsList(table);
            return items;
        }
    }
}
