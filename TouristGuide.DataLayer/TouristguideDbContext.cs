using Microsoft.EntityFrameworkCore;
using System;
using TouristGuide.Entities;

namespace TouristGuide.DataLayer
{
    public class TouristguideDbContext : DbContext
    {
        public TouristguideDbContext(DbContextOptions<TouristguideDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
            //Database.Migrate();
        }
        /// <summary>
        /// Creating DbSet for Table
        /// </summary>
        public DbSet<Place> Places { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<TourGuide> TourGuides { get; set; }
        public DbSet<ContactUs> ContactUss { get; set; }
        public DbSet<AboutIndia> AboutIndias { get; set; }
    }
}
