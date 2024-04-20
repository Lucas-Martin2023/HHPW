using System;
using HHPW.Models;
using Microsoft.EntityFrameworkCore;


namespace HHPW.Data
{
    public class ItemData
    {
        public static List<Item> Items = new List<Item>
        {   // seed data with Item
            new Item { Id = 1, Name = "Pizza", price = 10 },
            new Item { Id = 2, Name = "Wangs", price = 20 },
            new Item { Id = 3, Name = "Ands", price = 15 },
            new Item { Id = 4, Name = "Thangs", price = 25 }
        };
    }
}