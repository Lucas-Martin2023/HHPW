﻿using System.ComponentModel.DataAnnotations;

namespace HHPW.Models;

public class OrderItem
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ItemId { get; set; }
    public int Amount { get; set; }
    public Item Item { get; set; }

}
