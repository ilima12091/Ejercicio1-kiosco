using System;

namespace SRP
{
    // No encontré algo que no cumpliera con SRP o expert ya que no hay más de una razón de cambio para Libro y además las responsabilidades están bien distribuidas
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            libro1.AlmacenarLibro("A","7");
            libro2.AlmacenarLibro("B","3");

        }
    }
}
