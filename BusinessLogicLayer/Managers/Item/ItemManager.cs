﻿using System;
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

        public static Item GetItemById(int id)
        {
            string query = $"SELECT * FROM Items WHERE Id = {id}";

            DataTable dt = ApplicationDB.GetDataTable(query);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            Item item = new Item
            {
                Id = Convert.ToInt32(row["Id"]),
                Name = row["Name"].ToString(),
                Price = Convert.ToDouble(row["Price"]),
                Description = row["Description"].ToString(),
                Stock = Convert.ToInt32(row["Stock"]),
                IsAvailable = Convert.ToBoolean(row["IsAvailable"])
            };

            return item;
        }

        public static int InsertItem(string name, decimal price, int stock, string desc)
        {
            string query = $"insert into items (name, price, description,stock) values ('{name}',{price},'{desc}', {stock})";

            return ApplicationDB.ExcuteNonQuery(query);
        }


        public static int DeleteItem(int id)
        {
            string query = $"delete from items where id={id} ";

            return ApplicationDB.ExcuteNonQuery(query);
        }


    }
}
