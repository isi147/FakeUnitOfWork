namespace ConsoleApp9.Models;

public class Invoice
{
    public int Id { get; set; }
    public List<Item> Items { get; set; }
    public decimal TotalPrice { get; set; }
}
