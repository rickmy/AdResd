using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AdResd.Models;

namespace AdResd.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AdResd.Models.Residencia> Residencias { get; set; }
        public DbSet<AdResd.Models.TipoResidencia> TipoResidencias { get; set; }
        public DbSet<AdResd.Models.EncargadoPago> EncargadoPagos { get; set; }

    }
}
