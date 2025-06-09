using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer.Managers.Order
{
    public class OrderManager
    {
        public static int InsertOrder()
        {
            object result = ApplicationDB.ExcuteScalar("INSERT INTO Orders (Date, TotalPrice) VALUES (GETDATE(), 0); SELECT SCOPE_IDENTITY();");

            if (result != null && int.TryParse(result.ToString(), out int orderId))
            {
                return orderId;
            }
            else
            {
                throw new Exception("Failed to insert order and retrieve OrderId.");
            }
        }
        public static void AddOrderItems(int orderId, int itemId)
        {
            Item item = ItemManager.GetItemById(itemId);

            if (item == null || item.Stock == 0)
                return;
            bool exists = CheckItemsExistInOrderItems(orderId, itemId);
            string updateTotalPrice = $"UPDATE ORDERS SET TOTALPRICE = TOTALPRICE + {item.Price} WHERE ID = {orderId}";
            if (exists == false)
            {
                string query = $"INSERT INTO ORDERITEMS (ORDERID , ITEMID , QUANTITY) VALUES ({orderId} , {itemId} , 1)";
                ApplicationDB.ExcuteNonQuery(updateTotalPrice);
                int affectedRows = ApplicationDB.ExcuteNonQuery(query);
                if (affectedRows > 0)
                {
                    string updateQuery = $"UPDATE ITEMS SET STOCK = STOCK - 1 WHERE Id = {item.Id}";
                    ApplicationDB.ExcuteNonQuery(updateQuery);
                }
            }
            else
            {
                string update = $"UPDATE ORDERITEMS SET QUANTITY = (QUANTITY + 1) WHERE ItemId = {itemId} AND ORDERID = {orderId}";
                ApplicationDB.ExcuteNonQuery(updateTotalPrice);
                int affectedRows2 = ApplicationDB.ExcuteNonQuery(update);
                if (affectedRows2 > 0)
                {
                    {
                        string updateStock = $"UPDATE ITEMS SET STOCK = STOCK - 1 WHERE Id = {item.Id}";

                        ApplicationDB.ExcuteNonQuery(updateStock);
                    }
                }
            }
        }
        public static bool CheckItemsExistInOrderItems(int orderId, int itemId)
        {
            string query = $"SELECT COUNT(*) FROM ORDERITEMS WHERE ORDERID = {orderId} AND ITEMID = {itemId}";
            int count = Convert.ToInt32(ApplicationDB.ExcuteScalar(query));
            return count > 0;
        }
    }
}
