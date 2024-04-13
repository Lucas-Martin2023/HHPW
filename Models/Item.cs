using System.ComponentModel.DataAnnotations;

namespace HHPW.Models;

public class Item
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int price { get; set; }

}
