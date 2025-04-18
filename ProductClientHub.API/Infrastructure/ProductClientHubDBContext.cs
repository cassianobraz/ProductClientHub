﻿using Microsoft.EntityFrameworkCore;
using ProductClientHub.API.Entities;

namespace ProductClientHub.API.Infrastructure;

public class ProductClientHubDBContext : DbContext
{
    public DbSet<Client> Clients { get; set; } = default!;
    public DbSet<Product> Products { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\cassa\\OneDrive\\Documentos\\C#\\ROCKET\\ProductClientHubDB.db");
    }
}
