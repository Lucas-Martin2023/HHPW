using System;
using System.Reflection.Emit;
using HHPW.Models;
using Microsoft.EntityFrameworkCore;


namespace HHPW.Data
{
    public class OrderData
    {
        public static List<Order> Orders = new List<Order>
        {   // seed data with Order
            new Order { Id = 1, userId = 1, Name = "John Doe", Status = true, Phone = 1234567890, Email = "john@example.com", PaymentType = "Credit Card", OrderType = "Online", Total = 50, Tip = 5, Date = DateTime.Now.AddDays(-2) },
            new Order { Id = 2, userId = 2, Name = "Jane Smith", Status = false, Phone = 9876543210, Email = "jane@example.com", PaymentType = "PayPal", OrderType = "In-store", Total = 30, Tip = 3, Date = DateTime.Now.AddDays(-1) },
            new Order { Id = 3, userId = 3, Name = "Alice Johnson", Status = true, Phone = 5551234567, Email = "alice@example.com", PaymentType = "Cash", OrderType = "Delivery", Total = 45, Tip = 4, Date = DateTime.Now }
        };
    }
}