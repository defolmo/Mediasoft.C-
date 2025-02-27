using Microsoft.EntityFrameworkCore;
using NoteApp.Models;

namespace NoteApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Note> Notes { get; set; }
    }
}