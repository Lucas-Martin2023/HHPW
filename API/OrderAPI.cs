using HHPW.Models;
using Microsoft.EntityFrameworkCore;

namespace HHPW.API
{
    public static class OrderAPI
    {
        public static void Map(WebApplication app)
        {
            // Create Order
            app.MapPost("/api/createOrder", (HHPWDbContext db, Order newOrder) =>
            {
                db.Orders.Add(newOrder);
                db.SaveChanges();
                return Results.Created($"/api/createOrder/{newOrder.Id}", newOrder);
            });
        }
    }
}
