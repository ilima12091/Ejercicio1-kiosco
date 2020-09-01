using System;

namespace Expert_SRP // No cumple con el SRP ya que la clase tiene más de una razón para cambiar
{
    public class Kiosco 
    {
        // Se debería modificar este método en caso de que se quiera vender otro producto además de los alfajores
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            // No cumple con expert proque la suma que maneja el precio del alfajor debería ser manejada por la clase Alfajor porque es el experto en la información
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }
        // La responsabilidad de convertir a pesos debería estar en otra clase y además debería modificarse si se quiere agregar otro tipo de moneda
        private Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}