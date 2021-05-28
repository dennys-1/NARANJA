using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NARANJA.Models;
namespace NARANJA.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<NARANJA.Models.Reservas> Reservas {get; set;}
        
        public DbSet<NARANJA.Models.Platos> Platos { get; set; }
    }
}
