using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreOntario.Models
{
    //First create DbContext class
    // However, instead of derived from DbContext, we can derived from IdentityDbContext, which is pre-define by ASP.NET
    //public class IdentityDataContext : DbContext 
    public class IdentityDataContext : IdentityDbContext<IdentityUser>
    {
        // Second, register with the dependency injection 
        // Third step: add  dbcontext in startup.cs
        public IdentityDataContext(DbContextOptions<IdentityDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
