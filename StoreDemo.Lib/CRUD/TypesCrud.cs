// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System.Data;
using Microsoft.Data.Sqlite;
using Type = StoreDemo.Lib.Models.Type;

namespace StoreDemo.Lib.CRUD;

public class TypesCrud
{
    private const string ConnectionString = "Data Source=store.db;";
    private readonly SqliteConnection _db;

    public TypesCrud()
    {
        _db = new SqliteConnection(ConnectionString);
    }

    public IEnumerable<Type> GetAllTypes()
    {
        var types = new List<Type>();
        
        _db.Open();

        var sql = "SELECT type_id, type_name FROM tab_types;";
        var command = new SqliteCommand(sql, _db);
        var result = command.ExecuteReader();
        while (result.Read())
        {
            types.Add(new Type
            {
                Id = result.GetInt32("type_id"),
                Name = result.GetString("type_name")
            });
        }
        
        _db.Close();

        return types;
    }
}