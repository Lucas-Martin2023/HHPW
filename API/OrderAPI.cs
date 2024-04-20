using HHPW.Models;
using Microsoft.EntityFrameworkCore;

namespace HHPW.API
{
    public static class OrderAPI
    {
        public static void Map(WebApplication app)
        {
            // Create One Order
            app.MapPost("/api/createOneOrder", (HHPWDbContext db, Order newOrder) =>
            {
                db.Orders.Add(newOrder);
                db.SaveChanges();
                return Results.Created($"/api/createOneOrder/{newOrder.Id}", newOrder);
            });

            // Get All Orders
            app.MapGet("/api/getAllOrders", (HHPWDbContext db) =>
            {
                return db.Orders.ToList();
            });

            // Get One Order
            app.MapGet("/api/getOneorder/{id}", (HHPWDbContext db, int id) =>
            {
                var orderID = db.Orders.FirstOrDefault(c => c.Id == id);

                if (orderID == null)
                {
                    return Results.NotFound("Order Not Found.");
                }

                return Results.Ok(orderID);
            });

            // Update One Order
            app.MapPut("/api/updateOneOrder/{id}", (HHPWDbContext db, int id, Order updatedOrder) =>
            {
                Order orderToUpdate = db.Orders.SingleOrDefault(order => order.Id == id);

                if (orderToUpdate == null)
                {
                    return Results.NotFound();
                }

                orderToUpdate.Name = updatedOrder.Name;
                orderToUpdate.Phone = updatedOrder.Phone;
                orderToUpdate.Email = updatedOrder.Email;
                orderToUpdate.OrderType = updatedOrder.OrderType;

                db.SaveChanges();
                return Results.NoContent();
            });

            // Close Order
            app.MapPut("/api/closeOrder/{id}", (HHPWDbContext db, int id, string paymentType, decimal tipAmount) =>
            {
                var order = db.Orders.Find(id);

                if (order == null)
                {
                    return Results.NotFound("Order not found.");
                }

                if (order.IsOpen == false)
                {
                    return Results.BadRequest("Order has already been closed.");
                }

                // Update order details
                order.IsOpen = false; // Change status to closed
                order.PaymentType = paymentType;
                order.Tip = (int)tipAmount;

                db.SaveChanges();

                return Results.NoContent();
            });

            // Delete One Order
            app.MapDelete("/api/deleteOneOrder/{id}", (HHPWDbContext db, int id) =>
            {
                var order = db.Orders.Find(id);
                if (order == null) return Results.NotFound();

                db.Orders.Remove(order);
                db.SaveChanges();
                return Results.NoContent();

            });
        }
    }
}
