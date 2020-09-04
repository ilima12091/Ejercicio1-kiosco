using System;
using System.Text;

namespace Appointment
{
    public class AppointmentService
    {
        private static int id = 0;
        private int appointmentId;
        public DateTime date {get; set;}
        public Patient patient {get; set;}
        public Doctor doctor {get; set;}
        public AppointmentPlace appointmentPlace {get; set;}
        public AppointmentService(DateTime date, int patientId, string patientName, int patientAge, string patientPhoneNumber, string appointmentPlaceAddress, int doctorId, string doctorName, string doctorSpeciality)
        {
                Patient patient = new Patient(patientId, patientName, patientAge, patientPhoneNumber);
                Doctor doctor = new Doctor(doctorId, doctorName, doctorSpeciality);
                AppointmentPlace appointmentPlace = new AppointmentPlace(appointmentPlaceAddress);
                this.patient = patient;
                this.doctor = doctor;
                this.appointmentPlace = appointmentPlace;
                this.date = date;
                this.appointmentId = AppointmentService.id;
                AppointmentService.id++;
        }
    }
}
