using CatTail.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CatTail.API.Data;

public class CatContext : DbContext
{
    public CatContext(){}
    public CatContext(DbContextOptions<CatContext> options) : base(options){}

    public DbSet<Cat> Cats { get; set; }
}