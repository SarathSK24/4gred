namespace ConAppSmartAppointmentBooking
{
    internal class Program
    {
        private static int appointment;

        static void Main(string[] args)
        {
            List<Appointment> value = new List<Appointment>  
        {
            new Appointment { Id = 1, Date = DateTime.Today, Professional = "Dr. Smith", user = "Alice", Description = "Dental Checkup" },
            new Appointment { Id = 2, Date = DateTime.Today, Professional = "Dr. Adams", user = "Bob", Description = "Eye Exam" },
            new Appointment { Id = 3, Date =DateTime.Today, Professional = "Dr. Smith", user = "Charlie", Description = "Consultation" }
        };
          
            Ibookingservice s = new bookingservices(value);
            var todaysAppointments = s.GetAppointmentsByDate( DateTime.Today);
            var drSmithAppointments = s.GetAppointmentsByProfession("Dr. Smith");
            var aliceAppointments = s.GetAppointmentsByUser("Alice");
            Console.WriteLine("Today's Appointments:");
            foreach (var a in todaysAppointments) 
            {
                Console.WriteLine($"  {a.Description} - {a.user}");
            }
                
            Console.WriteLine("\nDr. Smith's Appointments:");
            foreach (var a in drSmithAppointments) 
            {

                Console.WriteLine($"  {a.Description} - {a.user}");

            }
            Console.WriteLine("\nAlice's Appointments:");
            foreach (var a in aliceAppointments) 
            {
                Console.WriteLine($"  {a.Description} - {a.user}");
            }

            





        }
    }
}
