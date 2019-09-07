/// <summary>
/// Application Data Context
/// </summary>

namespace WebApp.DataAccess.Database
{
    #region import namespaces

    using System.Data.Entity;
    using WebApp.DataAccess.Entities;

    #endregion

    public class WebAppDataContext : DbContext
    {
        public WebAppDataContext() : base("DefaultConnection")
        {
        }

        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<MessageType> MessageTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // more database related restrictions  
        }
    }
}
