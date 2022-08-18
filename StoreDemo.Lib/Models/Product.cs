// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

namespace StoreDemo.Lib.Models;

public record Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Type? Type { get; set; }
    public bool IsActive { get; set; }
}
