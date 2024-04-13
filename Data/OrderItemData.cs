using System;
using System.Reflection.Emit;
using HHPW.Models;
using Microsoft.EntityFrameworkCore;


namespace HHPW.Data
{
    public class OrderItemData
    {
        public static List<OrderItem> OrderItems = new List<OrderItem>
        {   // seed data with OrderItem
            new OrderItem { Id = 1, OrderId = 1, ItemId = 1 },
            new OrderItem { Id = 2, OrderId = 1, ItemId = 2 },
            new OrderItem { Id = 3, OrderId = 2, ItemId = 3 },
            new OrderItem { Id = 4, OrderId = 3, ItemId = 4 },
            new OrderItem { Id = 5, OrderId = 3, ItemId = 1 }
        };
    }
}