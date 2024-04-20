using System.ComponentModel.DataAnnotations;

namespace HHPW.Models;

public class Order
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsOpen { get; set; }
    public long Phone { get; set; }
    public string? Email { get; set; }
    public string? OrderType { get; set; }
    public decimal Total { get; set; }
    public int Tip { get; set; }
    public DateTime Date { get; set; }
    public string? PaymentType { get; set; }
    public int userId { get; set; }

}
