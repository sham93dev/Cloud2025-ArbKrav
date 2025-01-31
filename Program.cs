using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;
using System;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/", async () =>
{
    string connectionString = "Server=mysql;Database=shamil-database-arbeidskrav;User=root;Password=ShamilPass123;";
    
    try
    {
        using var connection = new MySqlConnection(connectionString);
        await connection.OpenAsync();
        return Results.Ok("Velkommen til Cloud 2025! Det funket!");
    }
    catch (Exception ex)
    {
        return Results.Problem("Kunne ikke koble til databasen. Feilmelding: " + ex.Message);
    }
});

app.MapGet("/api/test", () => Results.Ok("API-test vellykket! 🚀"));

app.Run();
