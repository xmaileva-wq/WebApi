using Microsoft.EntityFrameworkCore;

public class WebApiContext(DbContextOptions<WebApiContext> options) : DbContext(options)
{
    public DbSet<WebApi.Models.Curso> Curso { get; set; } = default!;
}
