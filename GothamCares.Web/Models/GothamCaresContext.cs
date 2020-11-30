using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GothamCares.Web.Models
{
    public class GothamCaresContext : DbContext
    {
        public GothamCaresContext(DbContextOptions<GothamCaresContext> options): base(options)
        {

        }
        public DbSet<Outlet> Outlets { get; set; }
    }
}
