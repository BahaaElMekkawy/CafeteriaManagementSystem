

namespace BusinessLogicLayer
{
    public class OrderItems : Item
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public double Total => Quantity * Price; 
    }
}
