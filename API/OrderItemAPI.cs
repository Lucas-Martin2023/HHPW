using HHPW.Models;
using Microsoft.EntityFrameworkCore;

namespace HHPW.API
{
    public static class OrderItemAPI
    {
        public static void Map(WebApplication app)
        {
            // Add Item to Order
            app.MapPost("/api/addItemToOrder/{orderId}/{itemId}", (HHPWDbContext db, int orderId, int itemId) =>
            {
                var order = db.Orders.Find(orderId);
                var item = db.Items.Find(itemId);

                if (order == null || item == null)
                {
                    return Results.NotFound("Order or Item not found.");
                }

                // Create a new order item and associate it with the order
                var orderItem = new OrderItem
                {
                    OrderId = orderId,
                    ItemId = itemId,
                    Amount = 1 // You can adjust the amount as needed
                };

                db.OrderItems.Add(orderItem);
                db.SaveChanges();

                return Results.Created($"/api/addItemToOrder/{orderId}/{itemId}", orderItem);
            });

            // Get One OrderItem
            app.MapGet("/api/getOneOrderItem/{id}", (HHPWDbContext db, int id) =>
            {
                var orderItemID = db.OrderItems.FirstOrDefault(c => c.Id == id);

                if (orderItemID == null)
                {
                    return Results.NotFound("The Order Item Was Not Found.");
                }

                return Results.Ok(orderItemID);
            });

            // Get All Items For One Order
            app.MapGet("/api/getAllItemsForOneOrder/{orderId}", (HHPWDbContext db, int orderId) =>
            {
                var orderItems = db.OrderItems
                                   .Where(oi => oi.OrderId == orderId)
                                   .Include(oi => oi.Item)
                                   .ToList();

                if (orderItems == null || orderItems.Count == 0)
                {
                    return Results.NotFound("No Items Found For This Order.");
                }

                // Prepare the response data
                var orderDetails = db.Orders
                                    .Where(o => o.Id == orderId)
                                    .FirstOrDefault();

                var response = new
                {
                    OrderDetails = orderDetails,
                    Items = orderItems.Select(oi => new
                    {
                        ItemName = oi.Item.Name,
                        ItemPrice = oi.Item.price
                    })
                };

                return Results.Ok(response);
            });

            // Delete One OrderItem
            app.MapDelete("/api/DeleteOneOrderItem/{id}", (HHPWDbContext db, int id) =>
            {
                OrderItem orderItemToDelete = db.OrderItems.SingleOrDefault(orderItemToDelete => orderItemToDelete.Id == id);
                if (orderItemToDelete == null)
                {
                    return Results.NotFound();
                }
                db.OrderItems.Remove(orderItemToDelete);
                db.SaveChanges();
                return Results.NoContent();
            });


        }
    }
}