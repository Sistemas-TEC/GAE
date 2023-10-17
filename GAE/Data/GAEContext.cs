using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GAE.Models;

namespace GAE.Data
{
    public class GAEContext : DbContext
    {
        public GAEContext (DbContextOptions<GAEContext> options)
            : base(options)
        {
        }

        public DbSet<Facility> Facility { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<FacilityCategory> FacilityCategory { get; set; }
        public DbSet<FacilityHasEquipment> FacilityHasEquipment { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<GAE.Models.Assembly> Assembly { get; set; } = default!;
    }
}
