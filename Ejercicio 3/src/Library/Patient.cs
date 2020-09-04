using System;

namespace Appointment
{
    public class Patient
    {
        private int id;
        private string name;
        private int age;
        private string phoneNumber;
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
                    Console.WriteLine("Error seteando la id del paciente");
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
                    Console.WriteLine("Error seteando el nombre del paciente");
                }
            }
        }
        public int Age {
            get {
                return this.age;
            }
            set {
                if(value != 0)
                {
                    this.age = value;
                }
                else
                {
                    Console.WriteLine("Error seteando la edad del paciente");
                }
            }
        }
        public string PhoneNumber {
            get {
                return this.phoneNumber;
            }
            set {
                if(!string.IsNullOrEmpty(value))
                {
                    this.phoneNumber = value;
                }
                else
                {
                    Console.WriteLine("Error seteando el número del paciente");
                }
            }
        }

        public Patient(int id, string name, int age, string phoneNumber)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.PhoneNumber = phoneNumber;
        }
    }
}