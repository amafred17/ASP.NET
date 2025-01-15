﻿namespace ItemListApp.Models
{
    public class CartItem
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalCost => Price * Quantity;
    }
}