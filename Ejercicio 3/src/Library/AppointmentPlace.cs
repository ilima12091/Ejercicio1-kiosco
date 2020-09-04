using System;

namespace Appointment
{
    public class AppointmentPlace
    {
        private string address;
        public string Address {
            get {
                return this.address;
            }
            set {
                if(!string.IsNullOrEmpty(value))
                {
                    this.address = value;
                }
                else
                {
                    Console.WriteLine("Error seteando el address");
                }
            }
        }

        public AppointmentPlace(string address)
        {
            this.Address = address;
        }
    }
}