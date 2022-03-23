using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class TempleTourContext : DbContext
    {
        public TempleTourContext()
        {

        }

        public TempleTourContext(DbContextOptions<TempleTourContext> options)
            : base (options)
        {
        }
        public DbSet<Tourist> Tourists { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Tourist>().HasData(
                new Tourist { TouristId = 1, EmailAddress = "test@test.com", GroupName = "Awesome", PhoneNumber = "555-555-1234", SizeOfGroup = 10, AppointmentStart = "2022-03-23T10:00:00" });
        }

    }
}