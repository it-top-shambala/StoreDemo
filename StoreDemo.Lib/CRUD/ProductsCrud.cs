// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System.Data;
using Microsoft.Data.Sqlite;
using StoreDemo.Lib.Models;
using Type = StoreDemo.Lib.Models.Type;

namespace StoreDemo.Lib.CRUD;

public class ProductsCrud
{
    private const string ConnectionString = "Data Source=store.db;";
    private readonly SqliteConnection _db;

    public ProductsCrud()
    {
        _db = new SqliteConnection(ConnectionString);
    }

    public IEnumerable<Product> GetAllProducts()
    {
        var products = new List<Product>();
        
        _db.Open();

        var sql = @"
SELECT product_id AS id,
       product_name AS name,
       tab_types.type_id AS type_id,
       type_name, is_active
FROM tab_products
    JOIN tab_types
        ON tab_types.type_id = tab_products.type_id;";
        var command = new SqliteCommand(sql, _db);
        var result = command.ExecuteReader();
        while (result.Read())
        {
            products.Add(new Product
            {
                Id = result.GetInt32("id"),
                Name = result.GetString("name"),
                Type = new Type
                {
                    Id = result.GetInt32("type_id"),
                    Name = result.GetString("type_name")
                },
                IsActive = result.GetBoolean("is_active")
            });
        }
        
        _db.Close();

        return products;
    }
}