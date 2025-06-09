﻿
namespace BusinessLogicLayer
{
    public class Item
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsAvailable{ get; set; }
        public int Stock { get; set; }
    }
}
