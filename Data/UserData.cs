using System;
using System.Reflection.Emit;
using HHPW.Models;
using Microsoft.EntityFrameworkCore;


namespace HHPW.Data
{
    public class UserData
    {
        public static List<User> Users = new List<User>
        {   // seed data with User
            new User { Id = 1, Uid = 101, Name = "John" },
            new User { Id = 2, Uid = 102, Name = "Jane" },
            new User { Id = 3, Uid = 103, Name = "Alice" }
        };
    }
}