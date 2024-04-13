using HHPW.Models;
using Microsoft.EntityFrameworkCore;

namespace HHPW.API
{
    public static class UserAPI
    {
        public static void Map(WebApplication app)
        {
            // Create User
            app.MapPost("/api/createUser", (HHPWDbContext db, User newUser) =>
            {
                db.Users.Add(newUser);
                db.SaveChanges();
                return Results.Created($"/api/createUser/{newUser.Id}", newUser);
            });
        }
    }
}
