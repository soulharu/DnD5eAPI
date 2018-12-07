using DnD5e.API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DnD5e.API.Data.Context
{
    public class APIContext : DbContext
    {
        public DbSet<Spell> Spells { get; set; }

        public APIContext(DbContextOptions<APIContext> options)
            :base(options)
        {
        }
    }
}
