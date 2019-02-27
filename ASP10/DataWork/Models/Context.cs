using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;

namespace DataWork.Models
{
    public class Context : DbContext
    {
        public DbSet<Respons> Respons { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Teg> Tegs { get; set; }
    }

    public class ContextIdent : IdentityDbContext<ApplicationUser>
    {
        public ContextIdent() : base("Context") { }
        public static ContextIdent Create()
        {
            return new ContextIdent();
        }
    }
}
