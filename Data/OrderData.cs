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
            new Order { Id = 1, userId = 1, Name = "John Doe", IsOpen = true, Phone = 1234567890, Email = "john@example.com", PaymentType = "Check", OrderType = "Phone", Total = 50, Tip = 5, Date = DateTime.Now.AddDays(-2) },
            new Order { Id = 2, userId = 2, Name = "Jane Smith", IsOpen = false, Phone = 9876543210, Email = "jane@example.com", PaymentType = "Debit", OrderType = "In-Person", Total = 30, Tip = 3, Date = DateTime.Now.AddDays(-1) },
            new Order { Id = 3, userId = 3, Name = "Alice Johnson", IsOpen = true, Phone = 5551234567, Email = "alice@example.com", PaymentType = "Cash", OrderType = "Phone", Total = 45, Tip = 4, Date = DateTime.Now }
        };
    }
}