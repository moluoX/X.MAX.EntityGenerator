using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.MAX.EntityGenerator.Domain.Entity;

namespace X.MAX.EntityGenerator.Domain
{
    public class UserTableContext : DbContext
    {
        public UserTableContext(DbContextOptions<UserTableContext> options) : base(options)
        {
        }

        public DbSet<UserTable> UserTables { get; set; }
        public DbSet<UserTableColumn> UserTableColumns { get; set; }
        public DbSet<UserTableComment> UserTableComments { get; set; }
        public DbSet<UserColumnComment> UserColumnComments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTableColumn>().HasKey(x => new { x.TABLE_NAME, x.COLUMN_NAME });
            modelBuilder.Entity<UserColumnComment>().HasKey(x => new { x.TABLE_NAME, x.COLUMN_NAME });
        }
    }
}
