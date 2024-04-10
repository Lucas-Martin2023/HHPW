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
        });
        // seed data with Order
        modelBuilder.Entity<Order>().HasData(new Order[]
        {
        });

        // Seed data with OrderItem
        modelBuilder.Entity<OrderItem>().HasData(new OrderItem
        {
        });

        // Seed data with User
        modelBuilder.Entity<User>().HasData(new User
        {
        });
    }
}