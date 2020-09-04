using System;

namespace Appointment
{
    public class Doctor
    {
        private int id;
        private string name;
        private string speciality;
        public int Id {
            get {
                return this.id;
            }
            set {
                if(value != 0)
                {
                    this.id = value;
                }
                else
                {
                    Console.WriteLine("Error seteando la id del doctor");
                }
            }
        }
        public string Name {
            get {
                return this.name;
            }
            set {
                if(!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("Error seteando el nombre del doctor");
                }
            }
        }
        public string Speciality {
            get {
                return this.speciality;
            }
            set {
                if(!string.IsNullOrEmpty(value))
                {
                    this.speciality = value;
                }
                else
                {
                    Console.WriteLine("Error seteando la especialidad del doctor");
                }
            }
        }

        public Doctor(int id, string name, string speciality)
        {
            this.Id = id;
            this.Name = name;
            this.Speciality = speciality;
        }
    }
}