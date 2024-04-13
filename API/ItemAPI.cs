using HHPW.Models;
using Microsoft.EntityFrameworkCore;

namespace HHPW.API
{
    public static class ItemAPI
    {
        public static void Map(WebApplication app)
        {
            // Create Item
            app.MapPost("/api/createItem", (HHPWDbContext db, Item newItem) =>
            {
                db.Items.Add(newItem);
                db.SaveChanges();
                return Results.Created($"/api/createItem/{newItem.Id}", newItem);
            });
        }
    }
}
