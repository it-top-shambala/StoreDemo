using System.Collections.Generic;
using StoreDemo.Lib.CRUD;
using StoreDemo.Lib.Models;
using Xunit;

namespace StoreDemo.Lib.Test;

public class TypesCrudTest
{
    [Fact]
    public void GetAllTypes_Test()
    {
        var expected = new List<Type>
        {
            new()
            {
                Id = 1,
                Name = "computer"
            },
            new()
            {
                Id = 2,
                Name = "car"
            }
        };

        var actual = new TypesCrud().GetAllTypes();
        
        Assert.Equal(expected, actual);
    }
}