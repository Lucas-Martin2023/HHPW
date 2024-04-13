using HHPW.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.Extensions.Hosting;
using HHPW.Data;

public class HHPWDbContext : DbContext
{

    public DbSet<Item> Items { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<User> Users { get; set; }

    public HHPWDbContext(DbContextOptions<HHPWDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>().HasData(ItemData.Items);
        modelBuilder.Entity<Order>().HasData(OrderData.Orders);
        modelBuilder.Entity<OrderItem>().HasData(OrderItemData.OrderItems);
        modelBuilder.Entity<User>().HasData(UserData.Users);
    }
}