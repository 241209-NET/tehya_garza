using CatTail.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CatTail.API.Data;

public partial class CatContext : DbContext
{
    public CatContext(){}
    public CatContext(DbContextOptions<CatContext> options) : base(options){}

    public virtual DbSet<Cat> Cats { get; set; }
}