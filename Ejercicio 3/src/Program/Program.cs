using System;

namespace Appointment
{
    class Program
    {
        static void Main(string[] args)
        {
            AppointmentService appointment = new AppointmentService(DateTime.Now, 12, "carlos", 123, "12312312", "asdas", 12, "asd", "asdasd");
        }
    }
}
