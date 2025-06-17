using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppSmartAppointmentBooking
{
    public interface Ibookingservice
    {
        IEnumerable<Appointment> GetAppointmentsByDate(DateTime date);
        IEnumerable<Appointment> GetAppointmentsByUser(string user);
        IEnumerable<Appointment> GetAppointmentsByProfession(string Descrip);
    }
}
