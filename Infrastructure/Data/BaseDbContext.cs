using Microsoft.EntityFrameworkCore;

namespace Eventide.Common.Infrastructure.Data;

public abstract class BaseDbContext : DbContext
{
    protected BaseDbContext(DbContextOptions options) : base(options) { }
}