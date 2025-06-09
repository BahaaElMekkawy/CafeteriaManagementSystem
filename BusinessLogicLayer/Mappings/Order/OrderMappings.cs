using System;
using System.Collections.Generic;
using System.Data;

namespace BusinessLogicLayer
{
    public static class OrderMappings
    {
        public static Order FromDataRowToOrder(DataRow row)
        {
            Order order = new Order();
            int.TryParse(row["Id"]?.ToString() ?? "-1", out int id);
            order.Id = id;

            double.TryParse(row["TotalPrice"]?.ToString(), out double totalPrice);
            order.TotalPrice = totalPrice;

            DateOnly.TryParse(row["Date"]?.ToString(), out DateOnly date);
            order.Date = date;

            return order;
        }
    }
}
