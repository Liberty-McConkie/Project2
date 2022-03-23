using System;
using System.Linq;

namespace Project2.Models
{
    public interface IAppointmentRepository
    {
        IQueryable<Appointment> Appointments { get; }

        public void SaveAppointment(Appointment a);
    }
    
}
