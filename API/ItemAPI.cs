using HHPW.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace HHPW.API
{
    public static class ItemAPI
    {
        public static void Map(WebApplication app)
        {

            // Create One Item
            app.MapPost("/api/createOneItem", (HHPWDbContext db, Item newItem) =>
            {
                db.Items.Add(newItem);
                db.SaveChanges();
                return Results.Created($"/api/createOneItem/{newItem.Id}", newItem);
            });

            // Get All Items
            app.MapGet("/api/getAllItems", (HHPWDbContext db) =>
            {
                return db.Items.ToList();
            });

            // Get One Item
            app.MapGet("/api/getOneItem/{id}", (HHPWDbContext db, int id) =>
            {
                var itemID = db.Items.FirstOrDefault(c => c.Id == id);

                if (itemID == null)
                {
                    return Results.NotFound("Item Not Found.");
                }

                return Results.Ok(itemID);
            });


        }
    }
}
