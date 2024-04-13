using HHPW.Models;
using Microsoft.EntityFrameworkCore;

namespace HHPW.API
{
    public static class OrderItemAPI
    {
        public static void Map(WebApplication app)
        {
            // Create OrderItem
            app.MapPost("/api/createOrderItem", (HHPWDbContext db, OrderItem newOrderItem) =>
            {
                db.OrderItems.Add(newOrderItem);
                db.SaveChanges();
                return Results.Created($"/api/createOrderItem/{newOrderItem.Id}", newOrderItem);
            });
        }
    }
}
