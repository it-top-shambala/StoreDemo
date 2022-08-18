namespace StoreDemo.Lib.Models;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Type? Type { get; set; }
    public bool IsActive { get; set; }
}