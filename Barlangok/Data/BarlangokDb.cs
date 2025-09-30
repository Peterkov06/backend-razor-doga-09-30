using Barlangok.Models;
using Microsoft.EntityFrameworkCore;

namespace Barlangok.Data
{
    public class BarlangokDb : DbContext
    {
        public BarlangokDb(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BarlangModel> barlangok;
    }
}
