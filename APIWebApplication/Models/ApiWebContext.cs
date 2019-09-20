using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APIWebApplication.Models
{
    public partial class ApiWebContext : DbContext
    {
        public ApiWebContext()
        {
        }

        public ApiWebContext(DbContextOptions<ApiWebContext> options)
            : base(options)
        {
        }

        // Unable to generate entity type for table 'dbo.User'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-I0CR0MQ;Initial Catalog=ApiWeb;Integrated Security=True;Persist Security Info=False;MultipleActiveResultSets = true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");
        }
    }
}
