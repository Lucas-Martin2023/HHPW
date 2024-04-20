using HHPW.Data;
using HHPW.Models;
using Microsoft.EntityFrameworkCore;

namespace HHPW.API
{
    public static class UserAPI
    {
        public static void Map(WebApplication app)
        {
            // Get One User
            app.MapGet("/api/GetOneuser/{id}", (HHPWDbContext db, int id) =>
            {
                var userID = db.Users.FirstOrDefault(c => c.Id == id);

                if (userID == null)
                {
                    return Results.NotFound("User Was Not Found.");
                }

                return Results.Ok(userID);
            });

            //Check User
            app.MapGet("/checkUser/{uid}", (HHPWDbContext db, string uid) =>
            {
                var user = db.Users.Where(x => x.Uid == uid).ToList();

                if (uid == null)
                {
                    return Results.NotFound();
                }
                else
                {
                    return Results.Ok(user);
                }
            });
        }
    }
}
