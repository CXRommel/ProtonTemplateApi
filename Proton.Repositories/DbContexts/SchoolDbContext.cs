using Microsoft.EntityFrameworkCore;
using Proton.Repositories.Entities;

namespace Proton.Repositories.DbContexts;

public class SchoolDbContext(DbContextOptions<SchoolDbContext> options)
    : DbContext(options)
{
    public DbSet<UserEntity> Users { get; set; }
}