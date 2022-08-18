// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System.Collections.Generic;
using StoreDemo.Lib.CRUD;
using StoreDemo.Lib.Models;
using Xunit;

namespace StoreDemo.Lib.Test;

public class ProductsCrudTest
{
    [Fact]
    public void GetAllProducts_Test()
    {
        var expected = new List<Product>
        {
            new() { Id = 1, Name = "Apple", Type = new Type { Id = 1, Name = "computer" }, IsActive = true },
            new() { Id = 2, Name = "PC", Type = new Type { Id = 1, Name = "computer" }, IsActive = true },
            new() { Id = 3, Name = "BMW", Type = new Type { Id = 2, Name = "car" }, IsActive = true },
            new() { Id = 4, Name = "Lada", Type = new Type { Id = 2, Name = "car" }, IsActive = false }
        };

        var actual = new ProductsCrud().GetAllProducts();

        Assert.Equal(expected, actual);
    }
}
