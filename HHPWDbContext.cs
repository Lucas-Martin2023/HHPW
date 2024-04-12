using HHPW.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;

public class HHPWDbContext : DbContext
{

    public DbSet<Item> Items { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<User> Users { get; set; }

    public HHPWDbContext(DbContextOptions<HHPWDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // seed data with Item
        modelBuilder.Entity<Item>().HasData(new Item[]
        {
            new Item { Id = 1, Name = "Widget", price = 10 },
            new Item { Id = 2, Name = "Gadget", price = 20 },
            new Item { Id = 3, Name = "Thingamajig", price = 15 },
            new Item { Id = 4, Name = "Doohickey", price = 25 }
        });
        modelBuilder.Entity<Order>().HasData(new Order[]
        {
            new Order { Id = 1, userId = 1, Name = "John Doe", Status = true, Phone = 1234567890, Email = "john@example.com", PaymentType = "Credit Card", OrderType = "Online", Total = 50, Tip = 5, Date = DateTime.Now.AddDays(-2) },
            new Order { Id = 2, userId = 2, Name = "Jane Smith", Status = false, Phone = 9876543210, Email = "jane@example.com", PaymentType = "PayPal", OrderType = "In-store", Total = 30, Tip = 3, Date = DateTime.Now.AddDays(-1) },
            new Order { Id = 3, userId = 3, Name = "Alice Johnson", Status = true, Phone = 5551234567, Email = "alice@example.com", PaymentType = "Cash", OrderType = "Delivery", Total = 45, Tip = 4, Date = DateTime.Now }
        });

        // Seed data with OrderItem
        modelBuilder.Entity<OrderItem>().HasData(new OrderItem
        {
            new OrderItem { Id = 1, OrderId = 1, ItemId = 1 },
            new OrderItem { Id = 2, OrderId = 1, ItemId = 2 },
            new OrderItem { Id = 3, OrderId = 2, ItemId = 3 },
            new OrderItem { Id = 4, OrderId = 3, ItemId = 4 },
            new OrderItem { Id = 5, OrderId = 3, ItemId = 1 }
        });

        // Seed data with User
        modelBuilder.Entity<User>().HasData(new User
        {
            new User { Id = 1, Uid = 101, Name = "John" },
            new User { Id = 2, Uid = 102, Name = "Jane" },
            new User { Id = 3, Uid = 103, Name = "Alice" }
        });
    }
}