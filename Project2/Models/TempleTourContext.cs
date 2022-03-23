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

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Tourist> Tourists { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Appointment>().HasData(
                new Appointment { AppointmentId = 1, TimeSlot = "8:00 a.m. - 9:00 a.m." },
                new Appointment { AppointmentId = 2, TimeSlot = "9:00 a.m. - 10:00 a.m." },
                new Appointment { AppointmentId = 3, TimeSlot = "10:00 a.m. - 11:00 a.m." },
                new Appointment { AppointmentId = 4, TimeSlot = "11:00 a.m. - 12:00 p.m." },
                new Appointment { AppointmentId = 5, TimeSlot = "12:00 p.m. - 1:00 p.m." },
                new Appointment { AppointmentId = 6, TimeSlot = "1:00 p.m. - 2:00 p.m." },
                new Appointment { AppointmentId = 7, TimeSlot = "2:00 p.m. - 3:00 p.m." },
                new Appointment { AppointmentId = 8, TimeSlot = "3:00 p.m. - 4:00 p.m." },
                new Appointment { AppointmentId = 9, TimeSlot = "4:00 p.m. - 5:00 p.m." },
                new Appointment { AppointmentId = 10, TimeSlot = "5:00 p.m. - 6:00 p.m." },
                new Appointment { AppointmentId = 11, TimeSlot = "6:00 p.m. - 7:00 p.m." },
                new Appointment { AppointmentId = 12, TimeSlot = "7:00 p.m. - 8:00 p.m." },
                new Appointment { AppointmentId = 13, TimeSlot = "8:00 p.m. - 9:00 p.m." });

        }

    }
}