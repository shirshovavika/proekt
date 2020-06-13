using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using programmirovanje.Models;

public class ApplicationContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationContext() : base("IdentityDb") { }

    public static ApplicationContext Create()
    {
        return new ApplicationContext();
    }

    public System.Data.Entity.DbSet<ApplicationRole> IdentityRoles { get; set; }

    //public System.Data.Entity.DbSet<programmirovanje.Models.Book> Books { get; set; }
}