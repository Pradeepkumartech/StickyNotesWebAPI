using MicroServiceWithDocker.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroServiceWithDocker.DBContexts
{
    public class ManageStickyNotesContext : DbContext
    {
        public ManageStickyNotesContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ManageStickNotes> ManageStickNotes { get; set; }
    }
}
