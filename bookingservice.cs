using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppSmartAppointmentBooking
{
    public class bookingservices : Ibookingservice
    {
        List<Appointment> _appointments;
        public bookingservices(List<Appointment> appointments)
        {
            _appointments = appointments;
        }
        public IEnumerable<Appointment> GetAppointmentsByDate(DateTime date) 
        {
            return _appointments.Where (a => a.Date.Date == date);

        }
        public IEnumerable<Appointment> GetAppointmentsByUser(string user)
        {
            return _appointments.Where(a => a.user.Equals(user, StringComparison.OrdinalIgnoreCase));
        }
        public IEnumerable<Appointment> GetAppointmentsByProfession(string Professional)
        {
            return _appointments.Where(a => a.Professional.Equals(Professional, StringComparison.OrdinalIgnoreCase));
        }

    }
}
